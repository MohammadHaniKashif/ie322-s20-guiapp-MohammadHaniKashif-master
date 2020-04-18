using System;

using System.Drawing;

using System.Windows.Forms;

using System.IO;    
using System.Reflection;    
namespace Mohammad.Hani.Kashif_1847625
{
    public partial class frmImage : Form
    {
        private object pictureBox1;

        public Image MessageBox { get; private set; }

        public frmImage()
        {
            InitializeComponent();
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            pictureBox1 = Image.FromFile("C:\\Users\\Moham\\OneDrive\\Desktop\\Mohammad.Hani.Kashif_1847625\\Mohammad.Hani.Kashif_1847625\\MHK.jpg");

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }

        private void frmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
