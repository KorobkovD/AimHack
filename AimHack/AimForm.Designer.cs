namespace AimHack
{
    partial class AimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AimForm));
            this.aimPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aimPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aimPictureBox
            // 
            this.aimPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aimPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aimPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aimPictureBox.Image = global::AimHack.Resources._default;
            this.aimPictureBox.Location = new System.Drawing.Point(0, 0);
            this.aimPictureBox.Name = "aimPictureBox";
            this.aimPictureBox.Size = new System.Drawing.Size(30, 30);
            this.aimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aimPictureBox.TabIndex = 0;
            this.aimPictureBox.TabStop = false;
            // 
            // AimForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(30, 30);
            this.ControlBox = false;
            this.Controls.Add(this.aimPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aim";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.AimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aimPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox aimPictureBox;
    }
}