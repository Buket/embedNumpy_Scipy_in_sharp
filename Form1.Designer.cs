namespace EmbedIronPython
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Build = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ClearScope = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_MoreInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_TextOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_TextOutClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_Main = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_ClearScope = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_Scope = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_RunDef = new System.Windows.Forms.ToolStripMenuItem();
            this.tSComboBox_DefList = new System.Windows.Forms.ToolStripComboBox();
            this.textBox_CodeIn = new System.Windows.Forms.TextBox();
            this.textBox_CodeOut = new System.Windows.Forms.TextBox();
            this.tSMenu_User = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBtn_Compile = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_ClearScope = new System.Windows.Forms.ToolStripButton();
            this.tSButton_Clear = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel.Text = "ready";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtn_Compile,
            this.tSBtn_ClearScope,
            this.tSButton_Clear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(456, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Build,
            this.toolStripMenuItem_MoreInfo,
            this.tSMenu_TextOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Build
            // 
            this.toolStripMenuItem_Build.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Compile,
            this.toolStripMenuItem_ClearScope});
            this.toolStripMenuItem_Build.Name = "toolStripMenuItem_Build";
            this.toolStripMenuItem_Build.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem_Build.Text = "Build";
            // 
            // toolStripMenuItem_Compile
            // 
            this.toolStripMenuItem_Compile.Name = "toolStripMenuItem_Compile";
            this.toolStripMenuItem_Compile.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem_Compile.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem_Compile.Text = "Compile";
            this.toolStripMenuItem_Compile.Click += new System.EventHandler(this.toolStripMenuItem_Compile_Click);
            // 
            // toolStripMenuItem_ClearScope
            // 
            this.toolStripMenuItem_ClearScope.Name = "toolStripMenuItem_ClearScope";
            this.toolStripMenuItem_ClearScope.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolStripMenuItem_ClearScope.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem_ClearScope.Text = "Clear Scope";
            this.toolStripMenuItem_ClearScope.Click += new System.EventHandler(this.toolStripMenuItem_ClearScope_Click);
            // 
            // toolStripMenuItem_MoreInfo
            // 
            this.toolStripMenuItem_MoreInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Help});
            this.toolStripMenuItem_MoreInfo.Name = "toolStripMenuItem_MoreInfo";
            this.toolStripMenuItem_MoreInfo.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem_MoreInfo.Text = "More Info";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem_Help.Text = "Help";
            this.toolStripMenuItem_Help.Click += new System.EventHandler(this.toolStripMenuItem_Help_Click);
            // 
            // tSMenu_TextOut
            // 
            this.tSMenu_TextOut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenu_TextOutClean});
            this.tSMenu_TextOut.Name = "tSMenu_TextOut";
            this.tSMenu_TextOut.Size = new System.Drawing.Size(57, 20);
            this.tSMenu_TextOut.Text = "Output";
            // 
            // tSMenu_TextOutClean
            // 
            this.tSMenu_TextOutClean.Name = "tSMenu_TextOutClean";
            this.tSMenu_TextOutClean.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tSMenu_TextOutClean.Size = new System.Drawing.Size(120, 22);
            this.tSMenu_TextOutClean.Text = "Clear";
            this.tSMenu_TextOutClean.Click += new System.EventHandler(this.tSMenu_TextOutClean_Click);
            // 
            // tSMenu_Main
            // 
            this.tSMenu_Main.Name = "tSMenu_Main";
            this.tSMenu_Main.Size = new System.Drawing.Size(46, 20);
            this.tSMenu_Main.Text = "Build";
            // 
            // tSMenu_Compile
            // 
            this.tSMenu_Compile.Name = "tSMenu_Compile";
            this.tSMenu_Compile.Size = new System.Drawing.Size(152, 22);
            this.tSMenu_Compile.Text = "Execute";
            // 
            // tSMenu_ClearScope
            // 
            this.tSMenu_ClearScope.Name = "tSMenu_ClearScope";
            this.tSMenu_ClearScope.Size = new System.Drawing.Size(152, 22);
            this.tSMenu_ClearScope.Text = "Clear Scope";
            // 
            // tSMenu_Scope
            // 
            this.tSMenu_Scope.Name = "tSMenu_Scope";
            this.tSMenu_Scope.Size = new System.Drawing.Size(51, 20);
            this.tSMenu_Scope.Text = "Scope";
            // 
            // tSMenu_RunDef
            // 
            this.tSMenu_RunDef.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSComboBox_DefList});
            this.tSMenu_RunDef.Name = "tSMenu_RunDef";
            this.tSMenu_RunDef.Size = new System.Drawing.Size(152, 22);
            this.tSMenu_RunDef.Text = "Run Def";
            // 
            // tSComboBox_DefList
            // 
            this.tSComboBox_DefList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tSComboBox_DefList.Name = "tSComboBox_DefList";
            this.tSComboBox_DefList.Size = new System.Drawing.Size(121, 23);
            // 
            // textBox_CodeIn
            // 
            this.textBox_CodeIn.AcceptsTab = true;
            this.textBox_CodeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CodeIn.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.textBox_CodeIn.Location = new System.Drawing.Point(7, 60);
            this.textBox_CodeIn.Multiline = true;
            this.textBox_CodeIn.Name = "textBox_CodeIn";
            this.textBox_CodeIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_CodeIn.Size = new System.Drawing.Size(437, 143);
            this.textBox_CodeIn.TabIndex = 4;
            // 
            // textBox_CodeOut
            // 
            this.textBox_CodeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CodeOut.Location = new System.Drawing.Point(7, 209);
            this.textBox_CodeOut.Multiline = true;
            this.textBox_CodeOut.Name = "textBox_CodeOut";
            this.textBox_CodeOut.ReadOnly = true;
            this.textBox_CodeOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_CodeOut.Size = new System.Drawing.Size(437, 235);
            this.textBox_CodeOut.TabIndex = 5;
            // 
            // tSMenu_User
            // 
            this.tSMenu_User.Name = "tSMenu_User";
            this.tSMenu_User.Size = new System.Drawing.Size(71, 20);
            this.tSMenu_User.Text = "More Info";
            // 
            // tSMenu_Help
            // 
            this.tSMenu_Help.Name = "tSMenu_Help";
            this.tSMenu_Help.Size = new System.Drawing.Size(152, 22);
            this.tSMenu_Help.Text = "Help";
            // 
            // tSBtn_Compile
            // 
            this.tSBtn_Compile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn_Compile.Image = global::EmbedIronPython.Properties.Resources.compile1;
            this.tSBtn_Compile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBtn_Compile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Compile.Name = "tSBtn_Compile";
            this.tSBtn_Compile.Size = new System.Drawing.Size(30, 30);
            this.tSBtn_Compile.Text = "Compile";
            this.tSBtn_Compile.ToolTipText = "F5 Compile\\Add To Scope";
            this.tSBtn_Compile.Click += new System.EventHandler(this.tSBtn_Compile_Click);
            // 
            // tSBtn_ClearScope
            // 
            this.tSBtn_ClearScope.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn_ClearScope.Image = global::EmbedIronPython.Properties.Resources.Clean1;
            this.tSBtn_ClearScope.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBtn_ClearScope.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_ClearScope.Name = "tSBtn_ClearScope";
            this.tSBtn_ClearScope.Size = new System.Drawing.Size(30, 30);
            this.tSBtn_ClearScope.Text = "toolStripButton2";
            this.tSBtn_ClearScope.ToolTipText = "F6 ClearScope";
            this.tSBtn_ClearScope.Click += new System.EventHandler(this.tSBtn_ClearScope_Click);
            // 
            // tSButton_Clear
            // 
            this.tSButton_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButton_Clear.Image = global::EmbedIronPython.Properties.Resources.clear;
            this.tSButton_Clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButton_Clear.Name = "tSButton_Clear";
            this.tSButton_Clear.Size = new System.Drawing.Size(30, 30);
            this.tSButton_Clear.Text = "Clear";
            this.tSButton_Clear.ToolTipText = "F7 Clear Output ";
            this.tSButton_Clear.Click += new System.EventHandler(this.tSButton_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 469);
            this.Controls.Add(this.textBox_CodeOut);
            this.Controls.Add(this.textBox_CodeIn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Embed Numpy & Scipy in C#";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtn_Compile;
        private System.Windows.Forms.ToolStripButton tSBtn_ClearScope;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_Main;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_Compile;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_ClearScope;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_Scope;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_RunDef;
        private System.Windows.Forms.ToolStripComboBox tSComboBox_DefList;
        private System.Windows.Forms.TextBox textBox_CodeIn;
        private System.Windows.Forms.TextBox textBox_CodeOut;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_User;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Build;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Compile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ClearScope;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_MoreInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_TextOut;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_TextOutClean;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton tSButton_Clear;
    }
}

