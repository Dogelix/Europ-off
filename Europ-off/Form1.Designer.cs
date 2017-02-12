namespace Europ_off
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.GamePanel = new System.Windows.Forms.Panel();
            this.ProvinceEditorPanel = new System.Windows.Forms.Panel();
            this.ProvinceList = new System.Windows.Forms.ListBox();
            this.ProvinceManpowerTextbox = new System.Windows.Forms.TextBox();
            this.ProvinceProductionTextbox = new System.Windows.Forms.TextBox();
            this.ProvinceTaxTextbox = new System.Windows.Forms.TextBox();
            this.ProvinceIDTextbox = new System.Windows.Forms.TextBox();
            this.ProvinceManpowerLabel = new System.Windows.Forms.Label();
            this.ProvinceProductionLabel = new System.Windows.Forms.Label();
            this.ProvinceTaxLabel = new System.Windows.Forms.Label();
            this.ProvienceIDLabel = new System.Windows.Forms.Label();
            this.ProvienceEditorSave = new System.Windows.Forms.Button();
            this.ProvinceColorPicker = new System.Windows.Forms.Button();
            this.ProvinceColorLabel = new System.Windows.Forms.Label();
            this.ProvinceNameTextbox = new System.Windows.Forms.TextBox();
            this.ProvienceNameLabel = new System.Windows.Forms.Label();
            this.CloseProvienceEditor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provienceEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.GamePanel.SuspendLayout();
            this.ProvinceEditorPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.Controls.Add(this.ProvinceEditorPanel);
            this.GamePanel.Location = new System.Drawing.Point(12, 27);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(992, 552);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // ProvinceEditorPanel
            // 
            this.ProvinceEditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceEditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceList);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceManpowerTextbox);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceProductionTextbox);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceTaxTextbox);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceIDTextbox);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceManpowerLabel);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceProductionLabel);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceTaxLabel);
            this.ProvinceEditorPanel.Controls.Add(this.ProvienceIDLabel);
            this.ProvinceEditorPanel.Controls.Add(this.ProvienceEditorSave);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceColorPicker);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceColorLabel);
            this.ProvinceEditorPanel.Controls.Add(this.ProvinceNameTextbox);
            this.ProvinceEditorPanel.Controls.Add(this.ProvienceNameLabel);
            this.ProvinceEditorPanel.Controls.Add(this.CloseProvienceEditor);
            this.ProvinceEditorPanel.Location = new System.Drawing.Point(781, 3);
            this.ProvinceEditorPanel.Name = "ProvinceEditorPanel";
            this.ProvinceEditorPanel.Size = new System.Drawing.Size(208, 546);
            this.ProvinceEditorPanel.TabIndex = 0;
            this.ProvinceEditorPanel.Visible = false;
            // 
            // ProvinceList
            // 
            this.ProvinceList.FormattingEnabled = true;
            this.ProvinceList.Location = new System.Drawing.Point(17, 158);
            this.ProvinceList.Name = "ProvinceList";
            this.ProvinceList.Size = new System.Drawing.Size(176, 316);
            this.ProvinceList.TabIndex = 14;
            this.ProvinceList.SelectedIndexChanged += new System.EventHandler(this.ProvinceList_SelectedIndexChanged);
            // 
            // ProvinceManpowerTextbox
            // 
            this.ProvinceManpowerTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceManpowerTextbox.Location = new System.Drawing.Point(93, 106);
            this.ProvinceManpowerTextbox.Name = "ProvinceManpowerTextbox";
            this.ProvinceManpowerTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceManpowerTextbox.TabIndex = 13;
            // 
            // ProvinceProductionTextbox
            // 
            this.ProvinceProductionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceProductionTextbox.Location = new System.Drawing.Point(93, 81);
            this.ProvinceProductionTextbox.Name = "ProvinceProductionTextbox";
            this.ProvinceProductionTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceProductionTextbox.TabIndex = 12;
            // 
            // ProvinceTaxTextbox
            // 
            this.ProvinceTaxTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceTaxTextbox.Location = new System.Drawing.Point(93, 58);
            this.ProvinceTaxTextbox.Name = "ProvinceTaxTextbox";
            this.ProvinceTaxTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceTaxTextbox.TabIndex = 11;
            // 
            // ProvinceIDTextbox
            // 
            this.ProvinceIDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceIDTextbox.Enabled = false;
            this.ProvinceIDTextbox.Location = new System.Drawing.Point(93, 34);
            this.ProvinceIDTextbox.Name = "ProvinceIDTextbox";
            this.ProvinceIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceIDTextbox.TabIndex = 10;
            // 
            // ProvinceManpowerLabel
            // 
            this.ProvinceManpowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceManpowerLabel.AutoSize = true;
            this.ProvinceManpowerLabel.Location = new System.Drawing.Point(14, 109);
            this.ProvinceManpowerLabel.Name = "ProvinceManpowerLabel";
            this.ProvinceManpowerLabel.Size = new System.Drawing.Size(60, 13);
            this.ProvinceManpowerLabel.TabIndex = 9;
            this.ProvinceManpowerLabel.Text = "Manpower:";
            // 
            // ProvinceProductionLabel
            // 
            this.ProvinceProductionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceProductionLabel.AutoSize = true;
            this.ProvinceProductionLabel.Location = new System.Drawing.Point(14, 84);
            this.ProvinceProductionLabel.Name = "ProvinceProductionLabel";
            this.ProvinceProductionLabel.Size = new System.Drawing.Size(64, 13);
            this.ProvinceProductionLabel.TabIndex = 8;
            this.ProvinceProductionLabel.Text = "Production :";
            // 
            // ProvinceTaxLabel
            // 
            this.ProvinceTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceTaxLabel.AutoSize = true;
            this.ProvinceTaxLabel.Location = new System.Drawing.Point(46, 61);
            this.ProvinceTaxLabel.Name = "ProvinceTaxLabel";
            this.ProvinceTaxLabel.Size = new System.Drawing.Size(28, 13);
            this.ProvinceTaxLabel.TabIndex = 7;
            this.ProvinceTaxLabel.Text = "Tax:";
            // 
            // ProvienceIDLabel
            // 
            this.ProvienceIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvienceIDLabel.AutoSize = true;
            this.ProvienceIDLabel.Location = new System.Drawing.Point(53, 37);
            this.ProvienceIDLabel.Name = "ProvienceIDLabel";
            this.ProvienceIDLabel.Size = new System.Drawing.Size(21, 13);
            this.ProvienceIDLabel.TabIndex = 6;
            this.ProvienceIDLabel.Text = "ID:";
            // 
            // ProvienceEditorSave
            // 
            this.ProvienceEditorSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvienceEditorSave.Location = new System.Drawing.Point(7, 489);
            this.ProvienceEditorSave.Name = "ProvienceEditorSave";
            this.ProvienceEditorSave.Size = new System.Drawing.Size(186, 23);
            this.ProvienceEditorSave.TabIndex = 5;
            this.ProvienceEditorSave.Text = "Save";
            this.ProvienceEditorSave.UseVisualStyleBackColor = true;
            // 
            // ProvinceColorPicker
            // 
            this.ProvinceColorPicker.BackColor = System.Drawing.Color.White;
            this.ProvinceColorPicker.Location = new System.Drawing.Point(93, 132);
            this.ProvinceColorPicker.Name = "ProvinceColorPicker";
            this.ProvinceColorPicker.Size = new System.Drawing.Size(20, 20);
            this.ProvinceColorPicker.TabIndex = 4;
            this.ProvinceColorPicker.UseVisualStyleBackColor = false;
            this.ProvinceColorPicker.Click += new System.EventHandler(this.ProvinceColorPicker_Click);
            // 
            // ProvinceColorLabel
            // 
            this.ProvinceColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceColorLabel.AutoSize = true;
            this.ProvinceColorLabel.Location = new System.Drawing.Point(40, 136);
            this.ProvinceColorLabel.Name = "ProvinceColorLabel";
            this.ProvinceColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ProvinceColorLabel.TabIndex = 3;
            this.ProvinceColorLabel.Text = "Color:";
            // 
            // ProvinceNameTextbox
            // 
            this.ProvinceNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvinceNameTextbox.Location = new System.Drawing.Point(93, 11);
            this.ProvinceNameTextbox.Name = "ProvinceNameTextbox";
            this.ProvinceNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceNameTextbox.TabIndex = 2;
            // 
            // ProvienceNameLabel
            // 
            this.ProvienceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvienceNameLabel.AutoSize = true;
            this.ProvienceNameLabel.Location = new System.Drawing.Point(36, 14);
            this.ProvienceNameLabel.Name = "ProvienceNameLabel";
            this.ProvienceNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ProvienceNameLabel.TabIndex = 1;
            this.ProvienceNameLabel.Text = "Name:";
            // 
            // CloseProvienceEditor
            // 
            this.CloseProvienceEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProvienceEditor.Location = new System.Drawing.Point(7, 518);
            this.CloseProvienceEditor.Name = "CloseProvienceEditor";
            this.CloseProvienceEditor.Size = new System.Drawing.Size(186, 23);
            this.CloseProvienceEditor.TabIndex = 0;
            this.CloseProvienceEditor.Text = "Close";
            this.CloseProvienceEditor.UseVisualStyleBackColor = true;
            this.CloseProvienceEditor.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadMapToolStripMenuItem.Text = "Load Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provienceEditorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // provienceEditorToolStripMenuItem
            // 
            this.provienceEditorToolStripMenuItem.Name = "provienceEditorToolStripMenuItem";
            this.provienceEditorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.provienceEditorToolStripMenuItem.Text = "Provience Editor";
            this.provienceEditorToolStripMenuItem.Click += new System.EventHandler(this.provinceEditorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Europa Map Save (*.ems)| *.ems";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Europa Map Save (*.ems)| *.ems";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 591);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Europ-off";
            this.GamePanel.ResumeLayout(false);
            this.ProvinceEditorPanel.ResumeLayout(false);
            this.ProvinceEditorPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provienceEditorToolStripMenuItem;
        private System.Windows.Forms.Panel ProvinceEditorPanel;
        private System.Windows.Forms.Button CloseProvienceEditor;
        private System.Windows.Forms.TextBox ProvinceNameTextbox;
        private System.Windows.Forms.Label ProvienceNameLabel;
        private System.Windows.Forms.Label ProvinceColorLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ProvinceColorPicker;
        private System.Windows.Forms.Label ProvienceIDLabel;
        private System.Windows.Forms.Button ProvienceEditorSave;
        private System.Windows.Forms.Label ProvinceManpowerLabel;
        private System.Windows.Forms.Label ProvinceProductionLabel;
        private System.Windows.Forms.Label ProvinceTaxLabel;
        private System.Windows.Forms.TextBox ProvinceManpowerTextbox;
        private System.Windows.Forms.TextBox ProvinceProductionTextbox;
        private System.Windows.Forms.TextBox ProvinceTaxTextbox;
        private System.Windows.Forms.TextBox ProvinceIDTextbox;
        private System.Windows.Forms.ListBox ProvinceList;
    }
}

