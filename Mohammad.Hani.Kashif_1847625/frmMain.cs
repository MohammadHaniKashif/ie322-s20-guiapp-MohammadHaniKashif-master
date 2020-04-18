using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammad.Hani.Kashif_1847625
{
    public partial class frmMain : Form
    {
        string username = "Mohammad";
        string myPassword = "1847625";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;

        public object BtnLogin { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.ShowDialog();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnManufCell_Click(object sender, EventArgs e)
        {

        }


        private void btnGroupieApp_Click(object sender, EventArgs e)
        {
        }

        private void btnCombo_Click_1(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void btnCombo_Click_2(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnMethod_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            frmClasses frm = new frmClasses();
            frm.ShowDialog();
        }

        private void Btnarray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {

                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {  
                        if (txtPassword.Text != myPassword)
                        {

                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {

                            attempt = 1; 
                            loggedIn = true;
                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            btnLogin.Text = "Logout";
                            MessageBox.Show( "Hi " + username + ", you are logged in.");
                            break; 
                        }

                    }
                }
            }
            else
            {
                btnLogin.Text = "Login";
                MessageBox.Show( "You are logged out.");
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }
            }


        }
    }
}
 


