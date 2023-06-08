namespace Cryptographic_system.Main
{
    partial class SystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemForm));
            this.Title = new System.Windows.Forms.Label();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.CaesarButton = new System.Windows.Forms.Button();
            this.TrithemiusButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MadeBy = new System.Windows.Forms.Label();
            this.GammaButton = new System.Windows.Forms.Button();
            this.PoemButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SymmetricButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(276, 237);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(440, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "Cryptographic system";
            // 
            // MainPicture
            // 
            this.MainPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPicture.Image = global::Cryptographic_system.Properties.Resources.Logo_half_contrasted;
            this.MainPicture.Location = new System.Drawing.Point(399, 37);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(156, 151);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicture.TabIndex = 1;
            this.MainPicture.TabStop = false;
            // 
            // CaesarButton
            // 
            this.CaesarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CaesarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaesarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaesarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaesarButton.Location = new System.Drawing.Point(197, 349);
            this.CaesarButton.Name = "CaesarButton";
            this.CaesarButton.Size = new System.Drawing.Size(213, 64);
            this.CaesarButton.TabIndex = 2;
            this.CaesarButton.Text = "Caesar cipher";
            this.CaesarButton.UseVisualStyleBackColor = true;
            this.CaesarButton.Click += new System.EventHandler(this.CaesarButton_Click);
            // 
            // TrithemiusButton
            // 
            this.TrithemiusButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrithemiusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrithemiusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrithemiusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrithemiusButton.Location = new System.Drawing.Point(559, 349);
            this.TrithemiusButton.Name = "TrithemiusButton";
            this.TrithemiusButton.Size = new System.Drawing.Size(258, 64);
            this.TrithemiusButton.TabIndex = 3;
            this.TrithemiusButton.Text = "Trithemius cipher";
            this.TrithemiusButton.UseVisualStyleBackColor = true;
            this.TrithemiusButton.Click += new System.EventHandler(this.TrithemiusButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::Cryptographic_system.Properties.Resources.connector1;
            this.pictureBox1.Location = new System.Drawing.Point(416, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MadeBy
            // 
            this.MadeBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MadeBy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MadeBy.Location = new System.Drawing.Point(885, 596);
            this.MadeBy.Name = "MadeBy";
            this.MadeBy.Size = new System.Drawing.Size(112, 19);
            this.MadeBy.TabIndex = 5;
            this.MadeBy.Text = "Made by Mickle";
            // 
            // GammaButton
            // 
            this.GammaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GammaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GammaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GammaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GammaButton.Location = new System.Drawing.Point(559, 443);
            this.GammaButton.Name = "GammaButton";
            this.GammaButton.Size = new System.Drawing.Size(258, 64);
            this.GammaButton.TabIndex = 6;
            this.GammaButton.Text = "Gamma cipher";
            this.GammaButton.UseVisualStyleBackColor = true;
            this.GammaButton.Click += new System.EventHandler(this.GammaCipher_Click);
            // 
            // PoemButton
            // 
            this.PoemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PoemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PoemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoemButton.Location = new System.Drawing.Point(197, 443);
            this.PoemButton.Name = "PoemButton";
            this.PoemButton.Size = new System.Drawing.Size(213, 64);
            this.PoemButton.TabIndex = 7;
            this.PoemButton.Text = "Poem cipher";
            this.PoemButton.UseVisualStyleBackColor = true;
            this.PoemButton.Click += new System.EventHandler(this.PoemButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = global::Cryptographic_system.Properties.Resources.connector1;
            this.pictureBox2.Location = new System.Drawing.Point(417, 457);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // SymmetricButton
            // 
            this.SymmetricButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SymmetricButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SymmetricButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SymmetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymmetricButton.Location = new System.Drawing.Point(367, 527);
            this.SymmetricButton.Name = "SymmetricButton";
            this.SymmetricButton.Size = new System.Drawing.Size(258, 64);
            this.SymmetricButton.TabIndex = 9;
            this.SymmetricButton.Text = "Symmetric cipher";
            this.SymmetricButton.UseVisualStyleBackColor = true;
            this.SymmetricButton.Click += new System.EventHandler(this.SymmetricButton_Click);
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(994, 615);
            this.Controls.Add(this.SymmetricButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PoemButton);
            this.Controls.Add(this.GammaButton);
            this.Controls.Add(this.MadeBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TrithemiusButton);
            this.Controls.Add(this.CaesarButton);
            this.Controls.Add(this.MainPicture);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptographic system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SymmetricButton;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button PoemButton;

        private System.Windows.Forms.Button GammaButton;

        private System.Windows.Forms.Label MadeBy;

        private System.Windows.Forms.Button TrithemiusButton;

        private System.Windows.Forms.Button CaesarButton;

        private System.Windows.Forms.Label Title;

        #endregion

        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}