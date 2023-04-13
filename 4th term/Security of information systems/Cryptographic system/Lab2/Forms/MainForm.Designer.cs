namespace Cryptographic_system.Lab2.Forms
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.Menu_panel = new System.Windows.Forms.Panel();
      this.Key3 = new System.Windows.Forms.TextBox();
      this.Key2 = new System.Windows.Forms.TextBox();
      this.Key1 = new System.Windows.Forms.TextBox();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.InfoMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.designerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_panel.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Menu_panel
      // 
      this.Menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
      this.Menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Menu_panel.Controls.Add(this.Key3);
      this.Menu_panel.Controls.Add(this.Key2);
      this.Menu_panel.Controls.Add(this.Key1);
      this.Menu_panel.Location = new System.Drawing.Point(0, 28);
      this.Menu_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Menu_panel.Name = "Menu_panel";
      this.Menu_panel.Size = new System.Drawing.Size(882, 110);
      this.Menu_panel.TabIndex = 5;
      // 
      // Key3
      // 
      this.Key3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key3.Location = new System.Drawing.Point(283, 49);
      this.Key3.Name = "Key3";
      this.Key3.Size = new System.Drawing.Size(111, 38);
      this.Key3.TabIndex = 10;
      this.Key3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key3.Visible = false;
      this.Key3.TextChanged += new System.EventHandler(this.Key3_TextChanged);
      // 
      // Key2
      // 
      this.Key2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key2.Location = new System.Drawing.Point(155, 49);
      this.Key2.Name = "Key2";
      this.Key2.Size = new System.Drawing.Size(111, 38);
      this.Key2.TabIndex = 9;
      this.Key2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key2.Visible = false;
      this.Key2.TextChanged += new System.EventHandler(this.Key2_TextChanged);
      // 
      // Key1
      // 
      this.Key1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key1.Location = new System.Drawing.Point(26, 49);
      this.Key1.Name = "Key1";
      this.Key1.Size = new System.Drawing.Size(111, 38);
      this.Key1.TabIndex = 8;
      this.Key1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key1.Visible = false;
      this.Key1.TextChanged += new System.EventHandler(this.Key1_TextChanged);
      // 
      // TextBox
      // 
      this.TextBox.AllowDrop = true;
      this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TextBox.Location = new System.Drawing.Point(12, 159);
      this.TextBox.Multiline = true;
      this.TextBox.Name = "TextBox";
      this.TextBox.Size = new System.Drawing.Size(860, 382);
      this.TextBox.TabIndex = 7;
      this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // FileMenu
      // 
      this.FileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openFileToolStripMenuItem, this.saveFileToolStripMenuItem, this.closeFileToolStripMenuItem });
      this.FileMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(44, 24);
      this.FileMenu.Text = "File";
      // 
      // openFileToolStripMenuItem
      // 
      this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
      this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openFileToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
      this.openFileToolStripMenuItem.Text = "Open file";
      this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
      // 
      // saveFileToolStripMenuItem
      // 
      this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
      this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
      this.saveFileToolStripMenuItem.Text = "Save file";
      this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
      // 
      // closeFileToolStripMenuItem
      // 
      this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
      this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
      this.closeFileToolStripMenuItem.Text = "Close file";
      this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
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
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileMenu, this.InfoMenu, this.runToolStripMenuItem });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(882, 28);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // runToolStripMenuItem
      // 
      this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.encryptToolStripMenuItem, this.decryptToolStripMenuItem });
      this.runToolStripMenuItem.Name = "runToolStripMenuItem";
      this.runToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.runToolStripMenuItem.Text = "Run";
      // 
      // encryptToolStripMenuItem
      // 
      this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
      this.encryptToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.encryptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
      this.encryptToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
      this.encryptToolStripMenuItem.Text = "Encrypt";
      this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
      // 
      // decryptToolStripMenuItem
      // 
      this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
      this.decryptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.decryptToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
      this.decryptToolStripMenuItem.Text = "Decrypt";
      this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
      this.ClientSize = new System.Drawing.Size(882, 553);
      this.Controls.Add(this.TextBox);
      this.Controls.Add(this.Menu_panel);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(15, 15);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "System";
      this.Menu_panel.ResumeLayout(false);
      this.Menu_panel.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem FileMenu;
    private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem InfoMenu;
    private System.Windows.Forms.ToolStripMenuItem designerInfoToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.TextBox Key2;
    private System.Windows.Forms.TextBox Key3;

    private System.Windows.Forms.TextBox Key1;

    private System.Windows.Forms.TextBox TextBox;

    private System.Windows.Forms.Panel Menu_panel;

    #endregion
  }
}

