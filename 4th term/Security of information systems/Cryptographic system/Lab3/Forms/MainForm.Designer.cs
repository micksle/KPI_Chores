using System.ComponentModel;

namespace Cryptographic_system.Lab3.Forms
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
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.SeedField = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.expandControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.Menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu_panel.Controls.Add(this.SeedLabel);
            this.Menu_panel.Controls.Add(this.SeedField);
            this.Menu_panel.Location = new System.Drawing.Point(0, 24);
            this.Menu_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(882, 119);
            this.Menu_panel.TabIndex = 6;
            // 
            // SeedLabel
            // 
            this.SeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SeedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeedLabel.Location = new System.Drawing.Point(41, 22);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(112, 32);
            this.SeedLabel.TabIndex = 19;
            this.SeedLabel.Text = "Seed value:";
            // 
            // SeedField
            // 
            this.SeedField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SeedField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeedField.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeedField.Location = new System.Drawing.Point(41, 57);
            this.SeedField.Name = "SeedField";
            this.SeedField.Size = new System.Drawing.Size(146, 38);
            this.SeedField.TabIndex = 8;
            this.SeedField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SeedField.TextChanged += new System.EventHandler(this.Seed_TextChanged);
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(12, 160);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(849, 374);
            this.TextBox.TabIndex = 8;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.infoToolStripMenuItem, this.runToolStripMenuItem, this.encryptToolStripMenuItem, this.decryptToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openFileToolStripMenuItem, this.saveFileToolStripMenuItem, this.toolStripSeparator1, this.resetToolStripMenuItem, this.mainMenuToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.designerInfoToolStripMenuItem });
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // designerInfoToolStripMenuItem
            // 
            this.designerInfoToolStripMenuItem.Name = "designerInfoToolStripMenuItem";
            this.designerInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.designerInfoToolStripMenuItem.Text = "Designer info";
            this.designerInfoToolStripMenuItem.Click += new System.EventHandler(this.designerInfoToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.encryptToolStripMenuItem1, this.decryptToolStripMenuItem1, this.toolStripSeparator2, this.expandControlsToolStripMenuItem, this.hideControlsToolStripMenuItem });
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // encryptToolStripMenuItem1
            // 
            this.encryptToolStripMenuItem1.Name = "encryptToolStripMenuItem1";
            this.encryptToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.encryptToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.encryptToolStripMenuItem1.Text = "Encrypt";
            this.encryptToolStripMenuItem1.Click += new System.EventHandler(this.encryptToolStripMenuItem1_Click);
            // 
            // decryptToolStripMenuItem1
            // 
            this.decryptToolStripMenuItem1.Name = "decryptToolStripMenuItem1";
            this.decryptToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.decryptToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.decryptToolStripMenuItem1.Text = "Decrypt";
            this.decryptToolStripMenuItem1.Click += new System.EventHandler(this.decryptToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // expandControlsToolStripMenuItem
            // 
            this.expandControlsToolStripMenuItem.Name = "expandControlsToolStripMenuItem";
            this.expandControlsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.expandControlsToolStripMenuItem.Text = "Expand controls";
            this.expandControlsToolStripMenuItem.Click += new System.EventHandler(this.expandControlsToolStripMenuItem_Click);
            // 
            // hideControlsToolStripMenuItem
            // 
            this.hideControlsToolStripMenuItem.Name = "hideControlsToolStripMenuItem";
            this.hideControlsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.hideControlsToolStripMenuItem.Text = "Hide controls";
            this.hideControlsToolStripMenuItem.Click += new System.EventHandler(this.hideControlsToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Visible = false;
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem1_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Visible = false;
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem1_Click);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem hideControlsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandControlsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.TextBox TextBox;

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.TextBox SeedField;

        #endregion
    }
}