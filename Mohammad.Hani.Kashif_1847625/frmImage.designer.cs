namespace Mohammad.Hani.Kashif_1847625
{
    partial class frmImage
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.picTry = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            this.picTry.Location = new System.Drawing.Point(27, 63);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(351, 215);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            this.btnBack.Location = new System.Drawing.Point(158, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnLoadImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadImage.Location = new System.Drawing.Point(27, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(351, 45);
            this.btnLoadImage.TabIndex = 6;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 409);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTry);
            this.Name = "frmImage";
            this.Text = "Picture Box using Embedded Resources";
            this.Load += new System.EventHandler(this.frmImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadImage;
    }
}