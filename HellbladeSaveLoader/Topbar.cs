using System;
using System.Drawing;
using System.Windows.Forms;

namespace HellbladeSaveLoader
{
    public partial class Topbar : UserControl
    {

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        private Form _owner;
        private bool _isDragging = false;
        private Point _cursorOffset;

        public Topbar(Form owner)
        {
            InitializeComponent();

            _owner = owner;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            _owner.WindowState = FormWindowState.Minimized;
        }

        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            Point c = Cursor.Position;

            _isDragging = true;
            _cursorOffset = new Point(c.X - _owner.Location.X, c.Y - _owner.Location.Y);
        }

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if(_isDragging)
            {
                Point cursor = Cursor.Position;
                _owner.Location = new Point(cursor.X - _cursorOffset.X, cursor.Y - _cursorOffset.Y);
                
            }
        }

        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }
    }
}
