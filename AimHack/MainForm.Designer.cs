namespace AimHack;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.showAim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAim
            // 
            this.showAim.Location = new System.Drawing.Point(12, 12);
            this.showAim.Name = "showAim";
            this.showAim.Size = new System.Drawing.Size(75, 23);
            this.showAim.TabIndex = 0;
            this.showAim.Text = "Показать";
            this.showAim.UseVisualStyleBackColor = true;
            this.showAim.Click += new System.EventHandler(this.showAim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 100);
            this.Controls.Add(this.showAim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private Button showAim;
}