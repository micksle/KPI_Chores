using System.ComponentModel;

namespace Cryptographic_system.Lab5.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.designerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.IVbox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.IVlabel = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.CFBRadio = new System.Windows.Forms.RadioButton();
            this.ECBRadio = new System.Windows.Forms.RadioButton();
            this.CBCRadio = new System.Windows.Forms.RadioButton();
            this.grpIV = new System.Windows.Forms.GroupBox();
            this.trippleDESRadio = new System.Windows.Forms.RadioButton();
            this.radioButtonDes = new System.Windows.Forms.RadioButton();
            this.AesRadio = new System.Windows.Forms.RadioButton();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpIV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileMenu, this.InfoMenu, this.runToolStripMenuItem, this.encryptToolStripMenuItem1, this.decryptToolStripMenuItem1 });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 7;
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openFileToolStripMenuItem, this.saveFileToolStripMenuItem, this.toolStripSeparator2, this.closeFileToolStripMenuItem, this.MainMenuStripMenuItem });
            this.FileMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 24);
            this.FileMenu.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeFileToolStripMenuItem.Text = "Reset";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // MainMenuStripMenuItem
            // 
            this.MainMenuStripMenuItem.Name = "MainMenuStripMenuItem";
            this.MainMenuStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MainMenuStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.MainMenuStripMenuItem.Text = "Main menu";
            this.MainMenuStripMenuItem.Click += new System.EventHandler(this.MainMenuStripMenuItem_Click);
            // 
            // InfoMenu
            // 
            this.InfoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.designerInfoToolStripMenuItem });
            this.InfoMenu.Name = "InfoMenu";
            this.InfoMenu.Size = new System.Drawing.Size(47, 24);
            this.InfoMenu.Text = "Info";
            // 
            // designerInfoToolStripMenuItem
            // 
            this.designerInfoToolStripMenuItem.Name = "designerInfoToolStripMenuItem";
            this.designerInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.designerInfoToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.designerInfoToolStripMenuItem.Text = "Designer info";
            this.designerInfoToolStripMenuItem.Click += new System.EventHandler(this.designerInfoToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.encryptToolStripMenuItem, this.decryptToolStripMenuItem, this.toolStripSeparator1, this.ExpandControlsToolStripMenuItem, this.hideControlsToolStripMenuItem });
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.encryptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // ExpandControlsToolStripMenuItem
            // 
            this.ExpandControlsToolStripMenuItem.Name = "ExpandControlsToolStripMenuItem";
            this.ExpandControlsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.ExpandControlsToolStripMenuItem.Text = "Expand controls";
            this.ExpandControlsToolStripMenuItem.Click += new System.EventHandler(this.ExpandControlsToolStripMenuItem_Click);
            // 
            // hideControlsToolStripMenuItem
            // 
            this.hideControlsToolStripMenuItem.Name = "hideControlsToolStripMenuItem";
            this.hideControlsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.hideControlsToolStripMenuItem.Text = "Hide controls";
            this.hideControlsToolStripMenuItem.Click += new System.EventHandler(this.hideControlsToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem1
            // 
            this.encryptToolStripMenuItem1.Name = "encryptToolStripMenuItem1";
            this.encryptToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.encryptToolStripMenuItem1.Text = "Encrypt";
            this.encryptToolStripMenuItem1.Visible = false;
            this.encryptToolStripMenuItem1.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem1
            // 
            this.decryptToolStripMenuItem1.Name = "decryptToolStripMenuItem1";
            this.decryptToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.decryptToolStripMenuItem1.Text = "Decrypt";
            this.decryptToolStripMenuItem1.Visible = false;
            this.decryptToolStripMenuItem1.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.Menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu_panel.Controls.Add(this.IVbox);
            this.Menu_panel.Controls.Add(this.KeyBox);
            this.Menu_panel.Controls.Add(this.IVlabel);
            this.Menu_panel.Controls.Add(this.grpMode);
            this.Menu_panel.Controls.Add(this.grpIV);
            this.Menu_panel.Controls.Add(this.KeyLabel);
            this.Menu_panel.Location = new System.Drawing.Point(0, 22);
            this.Menu_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(882, 149);
            this.Menu_panel.TabIndex = 8;
            // 
            // IVbox
            // 
            this.IVbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IVbox.Location = new System.Drawing.Point(601, 90);
            this.IVbox.Name = "IVbox";
            this.IVbox.Size = new System.Drawing.Size(182, 34);
            this.IVbox.TabIndex = 31;
            this.IVbox.TextChanged += new System.EventHandler(this.IVbox_TextChanged);
            // 
            // KeyBox
            // 
            this.KeyBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyBox.Location = new System.Drawing.Point(601, 25);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(182, 34);
            this.KeyBox.TabIndex = 30;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // IVlabel
            // 
            this.IVlabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IVlabel.Location = new System.Drawing.Point(530, 90);
            this.IVlabel.Name = "IVlabel";
            this.IVlabel.Size = new System.Drawing.Size(65, 34);
            this.IVlabel.TabIndex = 29;
            this.IVlabel.Text = "IV:";
            // 
            // grpMode
            // 
            this.grpMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpMode.Controls.Add(this.CFBRadio);
            this.grpMode.Controls.Add(this.ECBRadio);
            this.grpMode.Controls.Add(this.CBCRadio);
            this.grpMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpMode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpMode.Location = new System.Drawing.Point(40, 77);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(426, 54);
            this.grpMode.TabIndex = 27;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Choose mode";
            // 
            // CFBRadio
            // 
            this.CFBRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CFBRadio.Location = new System.Drawing.Point(326, 21);
            this.CFBRadio.Name = "CFBRadio";
            this.CFBRadio.Size = new System.Drawing.Size(74, 30);
            this.CFBRadio.TabIndex = 21;
            this.CFBRadio.TabStop = true;
            this.CFBRadio.Text = "CFB";
            this.CFBRadio.UseVisualStyleBackColor = true;
            this.CFBRadio.CheckedChanged += new System.EventHandler(this.CFBRadio_CheckedChanged);
            // 
            // ECBRadio
            // 
            this.ECBRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ECBRadio.Location = new System.Drawing.Point(195, 21);
            this.ECBRadio.Name = "ECBRadio";
            this.ECBRadio.Size = new System.Drawing.Size(104, 30);
            this.ECBRadio.TabIndex = 20;
            this.ECBRadio.TabStop = true;
            this.ECBRadio.Text = "ECB";
            this.ECBRadio.UseVisualStyleBackColor = true;
            this.ECBRadio.CheckedChanged += new System.EventHandler(this.ECBRadio_CheckedChanged);
            // 
            // CBCRadio
            // 
            this.CBCRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCRadio.Location = new System.Drawing.Point(76, 21);
            this.CBCRadio.Name = "CBCRadio";
            this.CBCRadio.Size = new System.Drawing.Size(104, 30);
            this.CBCRadio.TabIndex = 19;
            this.CBCRadio.TabStop = true;
            this.CBCRadio.Text = "CBC";
            this.CBCRadio.UseVisualStyleBackColor = true;
            this.CBCRadio.CheckedChanged += new System.EventHandler(this.CBCRadio_CheckedChanged);
            // 
            // grpIV
            // 
            this.grpIV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpIV.Controls.Add(this.trippleDESRadio);
            this.grpIV.Controls.Add(this.radioButtonDes);
            this.grpIV.Controls.Add(this.AesRadio);
            this.grpIV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpIV.Location = new System.Drawing.Point(40, 13);
            this.grpIV.Name = "grpIV";
            this.grpIV.Size = new System.Drawing.Size(426, 58);
            this.grpIV.TabIndex = 26;
            this.grpIV.TabStop = false;
            this.grpIV.Text = "Choose IV";
            // 
            // trippleDESRadio
            // 
            this.trippleDESRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trippleDESRadio.Location = new System.Drawing.Point(195, 19);
            this.trippleDESRadio.Name = "trippleDESRadio";
            this.trippleDESRadio.Size = new System.Drawing.Size(104, 36);
            this.trippleDESRadio.TabIndex = 23;
            this.trippleDESRadio.TabStop = true;
            this.trippleDESRadio.Text = "3-DES";
            this.trippleDESRadio.UseVisualStyleBackColor = true;
            this.trippleDESRadio.CheckedChanged += new System.EventHandler(this.trippleDESRadio_CheckedChanged);
            // 
            // radioButtonDes
            // 
            this.radioButtonDes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDes.Location = new System.Drawing.Point(76, 22);
            this.radioButtonDes.Name = "radioButtonDes";
            this.radioButtonDes.Size = new System.Drawing.Size(104, 30);
            this.radioButtonDes.TabIndex = 22;
            this.radioButtonDes.TabStop = true;
            this.radioButtonDes.Text = "DES";
            this.radioButtonDes.UseVisualStyleBackColor = true;
            this.radioButtonDes.CheckedChanged += new System.EventHandler(this.radioButtonDes_CheckedChanged);
            // 
            // AesRadio
            // 
            this.AesRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AesRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AesRadio.Location = new System.Drawing.Point(326, 22);
            this.AesRadio.Name = "AesRadio";
            this.AesRadio.Size = new System.Drawing.Size(88, 30);
            this.AesRadio.TabIndex = 18;
            this.AesRadio.TabStop = true;
            this.AesRadio.Text = "AES";
            this.AesRadio.UseVisualStyleBackColor = true;
            this.AesRadio.CheckedChanged += new System.EventHandler(this.AesRadio_CheckedChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyLabel.Location = new System.Drawing.Point(530, 25);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(65, 34);
            this.KeyLabel.TabIndex = 25;
            this.KeyLabel.Text = "Key:";
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(12, 186);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(849, 355);
            this.TextBox.TabIndex = 9;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 308);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpIV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox IVbox;

        private System.Windows.Forms.TextBox KeyBox;

        private System.Windows.Forms.Label IVlabel;

        private System.Windows.Forms.GroupBox grpMode;

        private System.Windows.Forms.GroupBox grpIV;

        private System.Windows.Forms.TextBox TextBox;

        private System.Windows.Forms.Label KeyLabel;

        private System.Windows.Forms.RadioButton radioButtonDes;
        private System.Windows.Forms.RadioButton trippleDESRadio;

        private System.Windows.Forms.RadioButton AesRadio;

        private System.Windows.Forms.RadioButton CBCRadio;
        private System.Windows.Forms.RadioButton ECBRadio;
        private System.Windows.Forms.RadioButton CFBRadio;

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.RadioButton Motto;
        private System.Windows.Forms.RadioButton NonLinear;
        private System.Windows.Forms.RadioButton LinearRadio;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoMenu;
        private System.Windows.Forms.ToolStripMenuItem designerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExpandControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem1;

        #endregion
    }
}