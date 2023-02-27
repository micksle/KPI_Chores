namespace Security_of_information_systems.Forms
{
    partial class KeyForm
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
            this.CodePanel = new System.Windows.Forms.Panel();
            this.Accept = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.LabelText = new System.Windows.Forms.Label();
            this.CodePanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodePanel
            // 
            this.CodePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CodePanel.Controls.Add(this.Accept);
            this.CodePanel.Controls.Add(this.keyBox);
            this.CodePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CodePanel.Location = new System.Drawing.Point(0, 91);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(370, 135);
            this.CodePanel.TabIndex = 0;
            // 
            // Accept
            // 
            this.Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Accept.Font = new System.Drawing.Font("MV Boli", 11F);
            this.Accept.Location = new System.Drawing.Point(120, 88);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(121, 35);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // keyBox
            // 
            this.keyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyBox.Font = new System.Drawing.Font("MV Boli", 14F);
            this.keyBox.Location = new System.Drawing.Point(82, 33);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(195, 38);
            this.keyBox.TabIndex = 0;
            this.keyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.TextPanel.Controls.Add(this.LabelText);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(370, 91);
            this.TextPanel.TabIndex = 1;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("MV Boli", 15F);
            this.LabelText.Location = new System.Drawing.Point(92, 33);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(197, 32);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "Enter key value";
            // 
            // KeyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 226);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.CodePanel);
            this.Name = "KeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.CodePanel.ResumeLayout(false);
            this.CodePanel.PerformLayout();
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button Accept;
    }
}