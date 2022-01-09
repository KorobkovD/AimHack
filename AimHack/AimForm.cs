using System.Runtime.InteropServices;

namespace AimHack
{
    public partial class AimForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HwndTop = new(-1);

        public AimForm()
        {
            InitializeComponent();
        }

        private void AimForm_Load(object sender, EventArgs e)
        {
            SetWindowPos(Handle, HwndTop, 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0010);
        }
    }
}
