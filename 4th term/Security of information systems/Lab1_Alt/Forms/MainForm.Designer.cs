namespace Lab1_Alt.Forms
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
            this.BruteButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BruteButton
            // 
            this.BruteButton.BackColor = System.Drawing.Color.FloralWhite;
            this.BruteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BruteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BruteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BruteButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BruteButton.Location = new System.Drawing.Point(467, 7);
            this.BruteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BruteButton.Name = "BruteButton";
            this.BruteButton.Size = new System.Drawing.Size(169, 39);
            this.BruteButton.TabIndex = 7;
            this.BruteButton.Text = "Brute decrypt";
            this.BruteButton.UseVisualStyleBackColor = false;
            this.BruteButton.Click += new System.EventHandler(this.BruteButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FloralWhite;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.OpenFileButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.Location = new System.Drawing.Point(129, 7);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(114, 39);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FloralWhite;
            this.EncryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.EncryptButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(247, 7);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(109, 39);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("MV Boli", 13F);
            this.TextBox.Location = new System.Drawing.Point(24, 67);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(817, 378);
            this.TextBox.TabIndex = 5;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.BackColor = System.Drawing.Color.FloralWhite;
            this.CreateFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CreateFileButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileButton.Location = new System.Drawing.Point(11, 7);
            this.CreateFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(114, 39);
            this.CreateFileButton.TabIndex = 5;
            this.CreateFileButton.Text = "Save file";
            this.CreateFileButton.UseVisualStyleBackColor = false;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.FloralWhite;
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.InfoButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.Location = new System.Drawing.Point(640, 7);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(106, 39);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Menu_panel.Controls.Add(this.BruteButton);
            this.Menu_panel.Controls.Add(this.OpenFileButton);
            this.Menu_panel.Controls.Add(this.EncryptButton);
            this.Menu_panel.Controls.Add(this.CreateFileButton);
            this.Menu_panel.Controls.Add(this.InfoButton);
            this.Menu_panel.Controls.Add(this.DecryptButton);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(868, 53);
            this.Menu_panel.TabIndex = 4;
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FloralWhite;
            this.DecryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.DecryptButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(360, 7);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(103, 39);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(868, 457);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Menu_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BruteButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button DecryptButton;

        #endregion
    }
}