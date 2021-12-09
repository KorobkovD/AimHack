using System.Runtime.InteropServices;

namespace AimHack;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void showAim_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// ������ ������ ���� ����������
    /// </summary>
    private void SetWindowAsGhost()
    {
        //��������� �������� ����� ����, � ����������� ��� � ����������� ������������
        int extendedStyle = GetWindowLongPtr(Handle, GWL_EXSTYLE);
        SetWindowLongPtr(Handle, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
    }

    /// <summary>
    /// �������� �������� ����, ��� 64-������� ����������
    /// </summary>
    /// <param name="hWnd">���������� ����</param>
    /// <param name="index">Id ��������</param>
    /// <returns>����� ������� ����</returns>
    [DllImport("user32.dll")]
    public static extern int GetWindowLongPtr(IntPtr hwnd, int index);

    /// <summary>
    /// ������������� �������� ����, ��� 64-������� ����������
    /// </summary>
    /// <param name="hWnd">���������� ����</param>
    /// <param name="index">Id ��������</param>
    /// <param name="newStyle">����� ����� �������</param>
    /// <returns>���������� ����� ������, ���� 0 - � ������ ������</returns>
    [DllImport("user32.dll")]
    public static extern int SetWindowLongPtr(IntPtr hwnd, int index, int newStyle);

    /// <summary>
    /// ��������� ����������� �����, ��� SetWindowLongPtr
    /// </summary>
    public const int WS_EX_TRANSPARENT = 0x00000020;

    /// <summary>
    /// ��������� ��������� �����, ��� SetWindowLongPtr
    /// </summary>
    public const int GWL_EXSTYLE = (-20);
}