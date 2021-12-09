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
    /// Делаем данное окно призрачным
    /// </summary>
    private void SetWindowAsGhost()
    {
        //Пролучаем активный стиль окна, и проставляем его с добавлением прозрачности
        int extendedStyle = GetWindowLongPtr(Handle, GWL_EXSTYLE);
        SetWindowLongPtr(Handle, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
    }

    /// <summary>
    /// Получаем свойства окна, для 64-битного приложения
    /// </summary>
    /// <param name="hWnd">Дескриптор окна</param>
    /// <param name="index">Id свойства</param>
    /// <returns>Маска свойств окна</returns>
    [DllImport("user32.dll")]
    public static extern int GetWindowLongPtr(IntPtr hwnd, int index);

    /// <summary>
    /// Устанавливаем свойства окна, для 64-битного приложения
    /// </summary>
    /// <param name="hWnd">Дескриптор окна</param>
    /// <param name="index">Id свойства</param>
    /// <param name="newStyle">Новая маска свойств</param>
    /// <returns>Предыдущая маска стилей, либо 0 - в случае ошибки</returns>
    [DllImport("user32.dll")]
    public static extern int SetWindowLongPtr(IntPtr hwnd, int index, int newStyle);

    /// <summary>
    /// Константа прозрачного стиля, для SetWindowLongPtr
    /// </summary>
    public const int WS_EX_TRANSPARENT = 0x00000020;

    /// <summary>
    /// Константа получения стиля, для SetWindowLongPtr
    /// </summary>
    public const int GWL_EXSTYLE = (-20);
}