namespace Cyz_IDE
{
    partial class frmMain
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
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlsTools = new System.Windows.Forms.ToolStrip();
            this.ddbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.smiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain.SuspendLayout();
            this.tlsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbCode
            // 
            this.rtbCode.AcceptsTab = true;
            this.rtbCode.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCode.Location = new System.Drawing.Point(3, 3);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(648, 379);
            this.rtbCode.TabIndex = 0;
            this.rtbCode.Text = "";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.rtbCode, 0, 0);
            this.tlpMain.Controls.Add(this.tlsTools, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMain.Size = new System.Drawing.Size(654, 408);
            this.tlpMain.TabIndex = 1;
            // 
            // tlsTools
            // 
            this.tlsTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbFile});
            this.tlsTools.Location = new System.Drawing.Point(0, 385);
            this.tlsTools.Name = "tlsTools";
            this.tlsTools.Size = new System.Drawing.Size(654, 23);
            this.tlsTools.TabIndex = 1;
            this.tlsTools.Text = "toolStrip1";
            // 
            // ddbFile
            // 
            this.ddbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiOpen,
            this.smiSave});
            this.ddbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbFile.Name = "ddbFile";
            this.ddbFile.Size = new System.Drawing.Size(38, 20);
            this.ddbFile.Text = "File";
            // 
            // smiOpen
            // 
            this.smiOpen.Name = "smiOpen";
            this.smiOpen.ShortcutKeyDisplayString = "Ctrl+O";
            this.smiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.smiOpen.Size = new System.Drawing.Size(146, 22);
            this.smiOpen.Text = "Open";
            this.smiOpen.ToolTipText = "Open";
            this.smiOpen.Click += new System.EventHandler(this.smiOpen_Click);
            // 
            // smiSave
            // 
            this.smiSave.Name = "smiSave";
            this.smiSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.smiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.smiSave.Size = new System.Drawing.Size(146, 22);
            this.smiSave.Text = "Save";
            this.smiSave.ToolTipText = "Save";
            this.smiSave.Click += new System.EventHandler(this.smiSave_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "CSharp Code|*.cs";
            this.sfdSave.Filter = "CSharp Code|*.cs|All Files|*.*";
            this.sfdSave.Title = "Save File";
            this.sfdSave.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSave_FileOk);
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "CSharp Code|*.cs";
            this.ofdOpen.Filter = "CSharp Code|*.cs|All Files|*.*";
            this.ofdOpen.Title = "Open File";
            this.ofdOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpen_FileOk);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 408);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(218, 146);
            this.Name = "frmMain";
            this.Text = "Cyz - Open Source C# IDE";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlsTools.ResumeLayout(false);
            this.tlsTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip tlsTools;
        private System.Windows.Forms.ToolStripDropDownButton ddbFile;
        private System.Windows.Forms.ToolStripMenuItem smiOpen;
        private System.Windows.Forms.ToolStripMenuItem smiSave;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
    }
}

