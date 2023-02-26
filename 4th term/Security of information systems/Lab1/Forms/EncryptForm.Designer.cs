namespace Security_of_information_systems.Forms
{
    partial class EncryptForm
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
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.EncryptSaveFileButton = new System.Windows.Forms.Button();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Open_file_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.EncryptTextField = new System.Windows.Forms.RichTextBox();
            this.Menu_panel.SuspendLayout();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Menu_panel.Controls.Add(this.EncryptSaveFileButton);
            this.Menu_panel.Controls.Add(this.Encrypt_button);
            this.Menu_panel.Controls.Add(this.Open_file_button);
            this.Menu_panel.Controls.Add(this.Back_button);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(800, 53);
            this.Menu_panel.TabIndex = 6;
            // 
            // EncryptSaveFileButton
            // 
            this.EncryptSaveFileButton.BackColor = System.Drawing.Color.FloralWhite;
            this.EncryptSaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptSaveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptSaveFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.EncryptSaveFileButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptSaveFileButton.Location = new System.Drawing.Point(272, 7);
            this.EncryptSaveFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EncryptSaveFileButton.Name = "EncryptSaveFileButton";
            this.EncryptSaveFileButton.Size = new System.Drawing.Size(106, 39);
            this.EncryptSaveFileButton.TabIndex = 8;
            this.EncryptSaveFileButton.Text = "Save file";
            this.EncryptSaveFileButton.UseVisualStyleBackColor = false;
            this.EncryptSaveFileButton.Click += new System.EventHandler(this.EncryptSaveFileButton_Click);
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Encrypt_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Encrypt_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_button.Location = new System.Drawing.Point(162, 7);
            this.Encrypt_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(106, 39);
            this.Encrypt_button.TabIndex = 6;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = false;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Open_file_button
            // 
            this.Open_file_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Open_file_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Open_file_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_file_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Open_file_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_file_button.Location = new System.Drawing.Point(11, 7);
            this.Open_file_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Open_file_button.Name = "Open_file_button";
            this.Open_file_button.Size = new System.Drawing.Size(147, 39);
            this.Open_file_button.TabIndex = 5;
            this.Open_file_button.Text = "Chose file";
            this.Open_file_button.UseVisualStyleBackColor = false;
            this.Open_file_button.Click += new System.EventHandler(this.Save_file_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Back_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(382, 7);
            this.Back_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(106, 39);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Encrypt_Back_button_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_panel.Controls.Add(this.EncryptTextField);
            this.Main_panel.ForeColor = System.Drawing.Color.Coral;
            this.Main_panel.Location = new System.Drawing.Point(-6, 42);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(813, 418);
            this.Main_panel.TabIndex = 7;
            // 
            // EncryptTextField
            // 
            this.EncryptTextField.BackColor = System.Drawing.SystemColors.Menu;
            this.EncryptTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncryptTextField.Font = new System.Drawing.Font("MV Boli", 12F);
            this.EncryptTextField.Location = new System.Drawing.Point(16, 31);
            this.EncryptTextField.Name = "EncryptTextField";
            this.EncryptTextField.Size = new System.Drawing.Size(783, 364);
            this.EncryptTextField.TabIndex = 0;
            this.EncryptTextField.Text = "";
            this.EncryptTextField.TextChanged += new System.EventHandler(this.EncryptFIleTextField_TextChanged);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Main_panel);
            this.Name = "EncryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptForm";
            this.Menu_panel.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button Open_file_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.RichTextBox EncryptTextField;
        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.Button EncryptSaveFileButton;
    }
}