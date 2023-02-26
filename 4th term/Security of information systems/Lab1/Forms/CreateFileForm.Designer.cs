namespace Security_of_information_systems.Forms
{
    partial class CreateFileForm
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
            this.CreateFileBackbutton = new System.Windows.Forms.Button();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Save_file_button = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.SaveFIleTextField = new System.Windows.Forms.RichTextBox();
            this.Menu_panel.SuspendLayout();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFileBackbutton
            // 
            this.CreateFileBackbutton.BackColor = System.Drawing.Color.FloralWhite;
            this.CreateFileBackbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateFileBackbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateFileBackbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CreateFileBackbutton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileBackbutton.Location = new System.Drawing.Point(163, 7);
            this.CreateFileBackbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreateFileBackbutton.Name = "CreateFileBackbutton";
            this.CreateFileBackbutton.Size = new System.Drawing.Size(106, 39);
            this.CreateFileBackbutton.TabIndex = 0;
            this.CreateFileBackbutton.Text = "Back";
            this.CreateFileBackbutton.UseVisualStyleBackColor = false;
            this.CreateFileBackbutton.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Menu_panel.Controls.Add(this.Save_file_button);
            this.Menu_panel.Controls.Add(this.CreateFileBackbutton);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(800, 53);
            this.Menu_panel.TabIndex = 4;
            // 
            // Save_file_button
            // 
            this.Save_file_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Save_file_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_file_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_file_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Save_file_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_file_button.Location = new System.Drawing.Point(11, 7);
            this.Save_file_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Save_file_button.Name = "Save_file_button";
            this.Save_file_button.Size = new System.Drawing.Size(147, 39);
            this.Save_file_button.TabIndex = 5;
            this.Save_file_button.Text = "Save file";
            this.Save_file_button.UseVisualStyleBackColor = false;
            this.Save_file_button.Click += new System.EventHandler(this.Create_file_button_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_panel.Controls.Add(this.SaveFIleTextField);
            this.Main_panel.ForeColor = System.Drawing.Color.Coral;
            this.Main_panel.Location = new System.Drawing.Point(0, 52);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(813, 418);
            this.Main_panel.TabIndex = 5;
            // 
            // SaveFIleTextField
            // 
            this.SaveFIleTextField.BackColor = System.Drawing.SystemColors.Menu;
            this.SaveFIleTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveFIleTextField.Font = new System.Drawing.Font("MV Boli", 12F);
            this.SaveFIleTextField.Location = new System.Drawing.Point(3, 3);
            this.SaveFIleTextField.Name = "SaveFIleTextField";
            this.SaveFIleTextField.Size = new System.Drawing.Size(791, 390);
            this.SaveFIleTextField.TabIndex = 0;
            this.SaveFIleTextField.Text = "";
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Main_panel);
            this.Name = "CreateFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateFileForm";
            this.Load += new System.EventHandler(this.CreateFileForm_Load);
            this.Menu_panel.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateFileBackbutton;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button Save_file_button;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.RichTextBox SaveFIleTextField;
    }
}