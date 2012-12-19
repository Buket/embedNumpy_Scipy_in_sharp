using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using IronPython.Hosting;
using IronPython.Runtime;
using System.Dynamic;
using NumpyDotNet;


namespace EmbedIronPython
{
    public partial class Form1 : Form
    {
        ScriptEngine _engine;
        ScriptSource _source;
        ScriptScope _scope;
        List<string> LibsPath;
        dynamic _builtin;
        Dictionary<string, object> _options;

        public Form1()
        {
            InitializeComponent();

            _options = new Dictionary<string, object>();
            
            Python.CreateRuntimeSetup(_options);
            
            _options.Add("Frames", true);

            _engine = Python.CreateRuntime(_options).GetEngine("python");//setup.Options["Frames"] = true;
            
            try
            {
                _builtin = _engine.GetBuiltinModule();
                SetWorkDir();
                _scope = _engine.CreateScope();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error initialization");
            }
            
        }
        
        private void SetWorkDir()
        {            
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(".");
            string _path_app = di.FullName,
                   _path_python = _path_app.Remove(_path_app.LastIndexOf("\\"));
            
            _path_python.Remove(_path_python.LastIndexOf("\\"));
            _path_app = _path_python.Remove(_path_python.LastIndexOf("\\"));            
            _path_app +="\\" + "IronPython 2.7";            
            LibsPath = new List<string>();
            LibsPath.Add(_path_app);
            LibsPath.Add(_path_app + "\\DLLs");
            LibsPath.Add(_path_app + "\\Lib");
            LibsPath.Add(_path_app + "\\Lib\\site-packages");
            _engine.SetSearchPaths(LibsPath);
        }
        
        private void toolStripMenuItem_Compile_Click(object sender, EventArgs e)
        {
            Compile();            
        }

        private void toolStripMenuItem_ClearScope_Click(object sender, EventArgs e)
        {
            ClearScope();
        }
        
        private void tSBtn_Compile_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void tSBtn_ClearScope_Click(object sender, EventArgs e)
        {
            ClearScope();
        }

        private void toolStripMenuItem_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" m11e@yandex.ru ", "Help");
        }

        private void tSMenu_TextOutClean_Click(object sender, EventArgs e)
        {
            ClearOut();
        }
        
        private void Compile()
        {           
                        
            try
            {
                _source = _engine.CreateScriptSourceFromString("import clr" + Environment.NewLine + "clr.AddReference('mtrand')" + Environment.NewLine);
                _source.Execute(_scope);
                _source = _engine.CreateScriptSourceFromString(textBox_CodeIn.Text);

                dynamic res2 = _source.Execute(_scope);
                if (res2 != null)
                    textBox_CodeOut.Text += Environment.NewLine + ">>> " + _builtin.str(res2);
                textBox_CodeOut.SelectionStart = textBox_CodeOut.TextLength;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error compile");                
            }
            toolStripStatusLabel.Text = "Compile done";
        }
        
        private void ClearScope()
        {           
            _scope = _engine.CreateScope();            
            toolStripStatusLabel.Text = "Scope cleared";
        }

        private void ClearOut()
        {
            toolStripStatusLabel.Text = "Clear Output";
            textBox_CodeOut.Clear();
            toolStripStatusLabel.Text = "Output Cleared";
        }

        private void tSButton_Clear_Click(object sender, EventArgs e)
        {
            ClearOut();
        }
        
    }
}
