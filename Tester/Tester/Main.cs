using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Перетаскивание формы

        Point prevMousePosition;
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                prevMousePosition = Control.MousePosition;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point p = Control.MousePosition;
                this.Left += p.X - prevMousePosition.X;
                this.Top += p.Y - prevMousePosition.Y;
                prevMousePosition = p;
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Tool события (свернуть, развернуть, закрыть)
        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized) || WindowState.Equals(FormWindowState.Normal))
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти? Данные могут быть потеряны.", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        #endregion

        private void registrationTextBox_TextChanged(object sender, EventArgs e)
        {
           if((sender as TextBox).Text == "")
            {
                fullNameLabel.Visible = true;
            }
            else
            {
                fullNameLabel.Visible = false;
            }
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if(registrationTextBox.Text != "")
            {
                errorRegistrationLabel.Visible = false;
                testerTabControl.TabIndex = 1;
            }
            else
            {
                errorRegistrationLabel.Visible = true;
            }
        }
    }
}
