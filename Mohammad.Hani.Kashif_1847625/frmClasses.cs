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
    public partial class frmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

       Truck MyTruck = new Truck();


        public frmClasses()
        {
            InitializeComponent();
        }

        private void BtnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start(); 
        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {        
          
            HisCar.Start();  
           

           

        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(30);
           MessageBox.Show(Convert.ToString(MyCar.speed));
        }

        private void BtnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
        }

        private void BtnStartMyTruck_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
