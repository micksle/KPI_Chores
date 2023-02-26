using System.ComponentModel;

namespace Security_of_information_systems.Forms
{
    partial class DecryptForm
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
            this.DecryptTextField = new System.Windows.Forms.RichTextBox();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Menu_panel.SuspendLayout();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptTextField
            // 
            this.DecryptTextField.BackColor = System.Drawing.SystemColors.Menu;
            this.DecryptTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecryptTextField.Font = new System.Drawing.Font("MV Boli", 12F);
            this.DecryptTextField.Location = new System.Drawing.Point(17, 38);
            this.DecryptTextField.Name = "DecryptTextField";
            this.DecryptTextField.Size = new System.Drawing.Size(777, 362);
            this.DecryptTextField.TabIndex = 0;
            this.DecryptTextField.Text = "";
            this.DecryptTextField.TextChanged += new System.EventHandler(this.DecryptTextField_TextChanged);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FloralWhite;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.SaveFileButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileButton.Location = new System.Drawing.Point(272, 7);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(106, 39);
            this.SaveFileButton.TabIndex = 8;
            this.SaveFileButton.Text = "Save file";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FloralWhite;
            this.DecryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.DecryptButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(162, 7);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(106, 39);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt\r\n";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Menu_panel.Controls.Add(this.SaveFileButton);
            this.Menu_panel.Controls.Add(this.DecryptButton);
            this.Menu_panel.Controls.Add(this.OpenFileButton);
            this.Menu_panel.Controls.Add(this.BackButton);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(800, 53);
            this.Menu_panel.TabIndex = 8;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FloralWhite;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.OpenFileButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.Location = new System.Drawing.Point(11, 7);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(147, 39);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Chose file";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FloralWhite;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BackButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(382, 7);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 39);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_panel.Controls.Add(this.DecryptTextField);
            this.Main_panel.ForeColor = System.Drawing.Color.Coral;
            this.Main_panel.Location = new System.Drawing.Point(-6, 37);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(813, 418);
            this.Main_panel.TabIndex = 9;
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Main_panel);
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecryptForm";
            this.Menu_panel.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox DecryptTextField;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel Main_panel;

        #endregion
    }
}