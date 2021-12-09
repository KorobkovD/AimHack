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
            new AimForm().Show();
            showAimButton.Text = "Скрыть";
        }
        else
        {
            activeAimForm.Close();
            showAimButton.Text = "Показать";
        }
    }
}
