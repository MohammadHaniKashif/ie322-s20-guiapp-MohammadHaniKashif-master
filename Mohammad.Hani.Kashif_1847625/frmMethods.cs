using System;
using System.Windows.Forms;

namespace Mohammad.Hani.Kashif_1847625
{
    public partial class frmMethods : Form
    {
        double a, b;

        double Balance = 1000;


        public frmMethods()
        {
            InitializeComponent();
        }

        private void frmMethods_Load(object sender, EventArgs e)
        {
            
        }



        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TxtA.Text);
                b = Convert.ToDouble(TxtB.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }
            

            MessageBox.Show("Sum of a and b is " + Add(a, b) +
               "" + "\nDifference of a and b is " + Subtract(a, b) +
               "" + "\nProduct of a and b is " + Multiply(a, b) +
               "" + "\nDividing  a by b is " + Divide(a, b) +
               "" + "\nRemainder of a and b is " + Rem(a, b)
              ,"Result" );               
        }

        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Subtract(double a, double b)
        {
            return a - b;
        }
        private double Multiply(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }
        private double Rem(double a, double b)
        {
            return a % b;
        }

        private void Deposit(double n)
        {
            Balance += n;
        }
        private void Withdraw(double n)
        {
            Balance -= n;
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            Deposit(200);
            CheckBalance();
            MessageBox.Show("Your current Balance is: " + Balance);
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw(500);
            CheckBalance();
            MessageBox.Show("Your current Balance is: " + Balance);
        }

        private void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            CheckBalance();
            MessageBox.Show("Your current Balance is: " + Balance);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private double CheckBalance()
        {
            return (Balance);
        }



    }
}
