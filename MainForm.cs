using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stahanova14.ModelEF;

namespace Stahanova14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (new ModelEF.ModelEF().Users.Any(x =>
            x.Login == labelLogin.Text &&
            x.Password == labelPsw.Text))
            {
                MessageBox.Show("Пользователь найден");
                return;
            }
            MessageBox.Show("Пользователь не найден, пройдите проверку Captcha!");
            new CaptchForm().ShowDialog();
        }
    }
}
