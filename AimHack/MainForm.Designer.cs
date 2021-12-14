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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.showAimButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAimButton
            // 
            this.showAimButton.Location = new System.Drawing.Point(12, 12);
            this.showAimButton.Name = "showAimButton";
            this.showAimButton.Size = new System.Drawing.Size(75, 23);
            this.showAimButton.TabIndex = 0;
            this.showAimButton.Text = "Показать";
            this.showAimButton.UseVisualStyleBackColor = true;
            this.showAimButton.Click += new System.EventHandler(this.showAimButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 47);
            this.Controls.Add(this.showAimButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AimHack";
            this.ResumeLayout(false);

    }

    #endregion

    private Button showAimButton;
}