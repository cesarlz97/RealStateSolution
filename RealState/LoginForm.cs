using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class LoginForm : Form
    {
        private enum LoginFormMode
        {
            LoginMode,
            RegisterMode,

        }

        private LoginFormMode mode = LoginFormMode.LoginMode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mode == LoginFormMode.LoginMode)
            {
                this.labelPasswordConfirm.Visible = true;
                this.textBoxPasswordConfirm.Visible = true;

                this.buttonLoginRegister.Text = "Registrarse";
                this.linkLabelRegister.Text = "Volver a login";

                this.mode = LoginFormMode.RegisterMode;
            }
            else
            {
                this.labelPasswordConfirm.Visible = false;
                this.textBoxPasswordConfirm.Visible = false;

                this.buttonLoginRegister.Text = "Entrar";
                this.linkLabelRegister.Text = "Registrarse";

                this.mode = LoginFormMode.LoginMode;
            }
        }

        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            
            this.Hide();
            mainForm.Show();
        }
    }
}
