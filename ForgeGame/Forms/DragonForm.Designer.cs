namespace ForgeGame
{
    partial class DragonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragonForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gold = new System.Windows.Forms.Button();
            this.btn_heart = new System.Windows.Forms.Button();
            this.btn_crystal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your reward:";
            // 
            // btn_gold
            // 
            this.btn_gold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btn_gold.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gold.Location = new System.Drawing.Point(402, 273);
            this.btn_gold.Name = "btn_gold";
            this.btn_gold.Size = new System.Drawing.Size(115, 40);
            this.btn_gold.TabIndex = 1;
            this.btn_gold.Text = "+6 Gold";
            this.btn_gold.UseVisualStyleBackColor = false;
            this.btn_gold.Click += new System.EventHandler(this.btn_gold_Click);
            // 
            // btn_heart
            // 
            this.btn_heart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btn_heart.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_heart.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_heart.Location = new System.Drawing.Point(402, 110);
            this.btn_heart.Name = "btn_heart";
            this.btn_heart.Size = new System.Drawing.Size(109, 40);
            this.btn_heart.TabIndex = 2;
            this.btn_heart.Text = "+2 Hearts";
            this.btn_heart.UseVisualStyleBackColor = false;
            this.btn_heart.Click += new System.EventHandler(this.btn_heart_Click);
            // 
            // btn_crystal
            // 
            this.btn_crystal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btn_crystal.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crystal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_crystal.Location = new System.Drawing.Point(402, 191);
            this.btn_crystal.Name = "btn_crystal";
            this.btn_crystal.Size = new System.Drawing.Size(113, 40);
            this.btn_crystal.TabIndex = 3;
            this.btn_crystal.Text = "+2 Crystals";
            this.btn_crystal.UseVisualStyleBackColor = false;
            this.btn_crystal.Click += new System.EventHandler(this.btn_crystal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DragonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(578, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_crystal);
            this.Controls.Add(this.btn_heart);
            this.Controls.Add(this.btn_gold);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DragonForm";
            this.Text = "FaceForm";
            this.Load += new System.EventHandler(this.FaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gold;
        private System.Windows.Forms.Button btn_heart;
        private System.Windows.Forms.Button btn_crystal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}