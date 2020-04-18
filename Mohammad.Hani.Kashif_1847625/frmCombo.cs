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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");

        }
        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {   
            
            MessageBox.Show(CmbDays.Text);      

        }
        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);            
        }
        private void BtnShowSelected3_Click(object sender, EventArgs e)
        {

            var item= CmbDays.SelectedItem;
            if(item !=null)
            MessageBox.Show(item.ToString()); 
        }
        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }
        private void btnRemoveByName_Click(object sender, EventArgs e)
        {

            CmbDays.Items.Remove("Friday");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item"); 
            }
        }
        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }

        }
    }
}
