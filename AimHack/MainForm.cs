namespace AimHack;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void showAimButton_Click(object sender, EventArgs e)
    {
        var activeAimForm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == nameof(AimForm));
        if (activeAimForm == null)
        {
            var aimForm = new AimForm();
            aimForm.StartPosition = FormStartPosition.Manual;
            aimForm.Top = (Screen.PrimaryScreen.Bounds.Height - aimForm.Height) / 2;
            aimForm.Left = (Screen.PrimaryScreen.Bounds.Width - aimForm.Width) / 2;
            aimForm.Size = new Size(15, 15);
            aimForm.Show();
            showAimButton.Text = "Скрыть";
        }
        else
        {
            activeAimForm.Close();
            showAimButton.Text = "Показать";
        }
    }
}
