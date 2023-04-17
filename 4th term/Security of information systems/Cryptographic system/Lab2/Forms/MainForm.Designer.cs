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
      this.MottoAddPicture = new System.Windows.Forms.PictureBox();
      this.Alabel = new System.Windows.Forms.Label();
      this.Motto = new System.Windows.Forms.RadioButton();
      this.NonLinear = new System.Windows.Forms.RadioButton();
      this.LinearRadio = new System.Windows.Forms.RadioButton();
      this.MottoBox = new System.Windows.Forms.TextBox();
      this.Clabel = new System.Windows.Forms.Label();
      this.Blabel = new System.Windows.Forms.Label();
      this.Key3 = new System.Windows.Forms.TextBox();
      this.Key2 = new System.Windows.Forms.TextBox();
      this.Key1 = new System.Windows.Forms.TextBox();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.InfoMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.designerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ExpandControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.encryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.decryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_panel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MottoAddPicture)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Menu_panel
      // 
      this.Menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
      this.Menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Menu_panel.Controls.Add(this.MottoAddPicture);
      this.Menu_panel.Controls.Add(this.Alabel);
      this.Menu_panel.Controls.Add(this.Motto);
      this.Menu_panel.Controls.Add(this.NonLinear);
      this.Menu_panel.Controls.Add(this.LinearRadio);
      this.Menu_panel.Controls.Add(this.MottoBox);
      this.Menu_panel.Controls.Add(this.Clabel);
      this.Menu_panel.Controls.Add(this.Blabel);
      this.Menu_panel.Controls.Add(this.Key3);
      this.Menu_panel.Controls.Add(this.Key2);
      this.Menu_panel.Controls.Add(this.Key1);
      this.Menu_panel.Location = new System.Drawing.Point(0, 24);
      this.Menu_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Menu_panel.Name = "Menu_panel";
      this.Menu_panel.Size = new System.Drawing.Size(882, 136);
      this.Menu_panel.TabIndex = 5;
      // 
      // MottoAddPicture
      // 
      this.MottoAddPicture.BackColor = System.Drawing.Color.White;
      this.MottoAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
      this.MottoAddPicture.Image = global::Cryptographic_system.Properties.Resources.Add_Button2;
      this.MottoAddPicture.Location = new System.Drawing.Point(542, 25);
      this.MottoAddPicture.Name = "MottoAddPicture";
      this.MottoAddPicture.Size = new System.Drawing.Size(18, 18);
      this.MottoAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.MottoAddPicture.TabIndex = 20;
      this.MottoAddPicture.TabStop = false;
      this.MottoAddPicture.Visible = false;
      this.MottoAddPicture.Click += new System.EventHandler(this.MottoAddPicture_Click);
      // 
      // Alabel
      // 
      this.Alabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Alabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Alabel.Location = new System.Drawing.Point(36, 81);
      this.Alabel.Name = "Alabel";
      this.Alabel.Size = new System.Drawing.Size(30, 23);
      this.Alabel.TabIndex = 19;
      this.Alabel.Text = "A:";
      // 
      // Motto
      // 
      this.Motto.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Motto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Motto.Location = new System.Drawing.Point(374, 25);
      this.Motto.Name = "Motto";
      this.Motto.Size = new System.Drawing.Size(104, 24);
      this.Motto.TabIndex = 18;
      this.Motto.TabStop = true;
      this.Motto.Text = "Motto";
      this.Motto.UseVisualStyleBackColor = true;
      this.Motto.CheckedChanged += new System.EventHandler(this.Motto_CheckedChanged);
      // 
      // NonLinear
      // 
      this.NonLinear.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.NonLinear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.NonLinear.Location = new System.Drawing.Point(219, 25);
      this.NonLinear.Name = "NonLinear";
      this.NonLinear.Size = new System.Drawing.Size(104, 24);
      this.NonLinear.TabIndex = 17;
      this.NonLinear.TabStop = true;
      this.NonLinear.Text = "NonLinear";
      this.NonLinear.UseVisualStyleBackColor = true;
      this.NonLinear.CheckedChanged += new System.EventHandler(this.NonLinear_CheckedChanged);
      // 
      // LinearRadio
      // 
      this.LinearRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LinearRadio.Location = new System.Drawing.Point(66, 25);
      this.LinearRadio.Name = "LinearRadio";
      this.LinearRadio.Size = new System.Drawing.Size(104, 24);
      this.LinearRadio.TabIndex = 16;
      this.LinearRadio.TabStop = true;
      this.LinearRadio.Text = "Linear";
      this.LinearRadio.UseVisualStyleBackColor = true;
      this.LinearRadio.CheckedChanged += new System.EventHandler(this.LinearRadio_CheckedChanged);
      // 
      // MottoBox
      // 
      this.MottoBox.AllowDrop = true;
      this.MottoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.MottoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.MottoBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MottoBox.Location = new System.Drawing.Point(562, 25);
      this.MottoBox.MaxLength = 2000;
      this.MottoBox.MinimumSize = new System.Drawing.Size(140, 50);
      this.MottoBox.Multiline = true;
      this.MottoBox.Name = "MottoBox";
      this.MottoBox.Size = new System.Drawing.Size(300, 101);
      this.MottoBox.TabIndex = 14;
      this.MottoBox.TextChanged += new System.EventHandler(this.MottoBox_TextChanged);
      this.MottoBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MottoBox_DragDrop);
      this.MottoBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MottoBox_DragEnter);
      this.MottoBox.DragOver += new System.Windows.Forms.DragEventHandler(this.MottoBox_DragOver);
      this.MottoBox.DragLeave += new System.EventHandler(this.MottoBox_DragLeave);
      this.MottoBox.Enter += new System.EventHandler(this.MottoBox_Enter);
      this.MottoBox.Leave += new System.EventHandler(this.MottoBox_Leave);
      // 
      // Clabel
      // 
      this.Clabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Clabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Clabel.Location = new System.Drawing.Point(338, 81);
      this.Clabel.Name = "Clabel";
      this.Clabel.Size = new System.Drawing.Size(30, 23);
      this.Clabel.TabIndex = 13;
      this.Clabel.Text = "C:";
      // 
      // Blabel
      // 
      this.Blabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Blabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Blabel.Location = new System.Drawing.Point(183, 81);
      this.Blabel.Name = "Blabel";
      this.Blabel.Size = new System.Drawing.Size(30, 23);
      this.Blabel.TabIndex = 12;
      this.Blabel.Text = "B:";
      // 
      // Key3
      // 
      this.Key3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Key3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key3.Location = new System.Drawing.Point(374, 77);
      this.Key3.Name = "Key3";
      this.Key3.Size = new System.Drawing.Size(111, 38);
      this.Key3.TabIndex = 10;
      this.Key3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key3.TextChanged += new System.EventHandler(this.Key3_TextChanged);
      // 
      // Key2
      // 
      this.Key2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Key2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key2.Location = new System.Drawing.Point(219, 77);
      this.Key2.Name = "Key2";
      this.Key2.Size = new System.Drawing.Size(111, 38);
      this.Key2.TabIndex = 9;
      this.Key2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key2.TextChanged += new System.EventHandler(this.Key2_TextChanged);
      // 
      // Key1
      // 
      this.Key1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.Key1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Key1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Key1.Location = new System.Drawing.Point(66, 77);
      this.Key1.Name = "Key1";
      this.Key1.Size = new System.Drawing.Size(111, 38);
      this.Key1.TabIndex = 8;
      this.Key1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Key1.TextChanged += new System.EventHandler(this.Key1_TextChanged);
      // 
      // TextBox
      // 
      this.TextBox.AllowDrop = true;
      this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TextBox.Location = new System.Drawing.Point(14, 174);
      this.TextBox.Multiline = true;
      this.TextBox.Name = "TextBox";
      this.TextBox.Size = new System.Drawing.Size(849, 367);
      this.TextBox.TabIndex = 7;
      this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileMenu, this.InfoMenu, this.runToolStripMenuItem, this.encryptToolStripMenuItem1, this.decryptToolStripMenuItem1 });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(882, 28);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
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
      this.MinimumSize = new System.Drawing.Size(860, 308);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Trithemius";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Menu_panel.ResumeLayout(false);
      this.Menu_panel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MottoAddPicture)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem hideControlsToolStripMenuItem;

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem1;

    private System.Windows.Forms.ToolStripMenuItem ExpandControlsToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem MainMenuStripMenuItem;

    private System.Windows.Forms.RadioButton NonLinear;
    private System.Windows.Forms.RadioButton Motto;

    private System.Windows.Forms.RadioButton LinearRadio;

    private System.Windows.Forms.TextBox MottoBox;

    private System.Windows.Forms.Label Alabel;
    private System.Windows.Forms.Label Blabel;
    private System.Windows.Forms.Label Clabel;

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

        private System.Windows.Forms.PictureBox MottoAddPicture;
    }
}

