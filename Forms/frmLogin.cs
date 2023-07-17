using BankManagmentSystem_WinForms.Properties;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem_WinForms.Forms
{
    public partial class frmLogin : Form
    {
        enum enPasswordMode
        {
            show, hide
        }
        enPasswordMode mode = enPasswordMode.show;


        public frmLogin()
        {
            InitializeComponent();
            

        }

        private void pbShowHide_Click(object sender, EventArgs e)
        {
            if(mode == enPasswordMode.show)
            {
                pbShowHide.Image = Resources.hide;
                mode = enPasswordMode.hide;

                txtPassword.PasswordChar = '\0';
            }
            else
            {
                pbShowHide.Image = Resources.show;
                mode = enPasswordMode.show;

                txtPassword.PasswordChar = '*';
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUsername(txtUsername.Text.ToString());
            if (user == null)
                MessageBox.Show("Username dosn't exsist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (txtPassword.Text.ToString() != user.password)
                    MessageBox.Show("Wrong password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    this.Visible = false;

                    frmMain frm = new frmMain(user);
                    frm.ShowDialog();


                    this.Visible = true;
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
        }
    }
}
