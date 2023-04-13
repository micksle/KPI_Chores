using System.ComponentModel;

namespace Cryptographic_system.Lab1.Forms
{
    partial class KeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyForm));
            this.CodePanel = new System.Windows.Forms.Panel();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.KeyText = new System.Windows.Forms.Label();
            this.CodePanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodePanel
            // 
            this.CodePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CodePanel.Controls.Add(this.Accept_Button);
            this.CodePanel.Controls.Add(this.keyBox);
            this.CodePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CodePanel.Location = new System.Drawing.Point(0, 84);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(357, 135);
            this.CodePanel.TabIndex = 2;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Accept_Button.Font = new System.Drawing.Font("MV Boli", 11F);
            this.Accept_Button.Location = new System.Drawing.Point(120, 88);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(121, 35);
            this.Accept_Button.TabIndex = 1;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            this.Accept_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Accept_Button_KeyDown);
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
            this.TextPanel.Controls.Add(this.KeyText);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(357, 91);
            this.TextPanel.TabIndex = 3;
            // 
            // KeyText
            // 
            this.KeyText.AutoSize = true;
            this.KeyText.Font = new System.Drawing.Font("MV Boli", 15F);
            this.KeyText.Location = new System.Drawing.Point(92, 33);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(196, 32);
            this.KeyText.TabIndex = 0;
            this.KeyText.Text = "Enter key value";
            // 
            // KeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 219);
            this.Controls.Add(this.CodePanel);
            this.Controls.Add(this.TextPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(375, 266);
            this.MinimumSize = new System.Drawing.Size(375, 266);
            this.Name = "KeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyForm";
            this.CodePanel.ResumeLayout(false);
            this.CodePanel.PerformLayout();
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label KeyText;

        #endregion
    }
}