namespace WinFormMethodF123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            lblResult.Text = "";
            txtName.Focus();

        }
        private void InputDatavalid(TextBox name, TextBox age)
        {
            
        }


        private void btnBMI_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);


            double height = 0;
            double weight = 0;
            if (CheckDouble(txtHeight, txtWeight)) 
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //process  BMI
            double bmi = BMI(height, weight);//method bmi
            //double bmi = weight / Math.Pow(height / 100, 2)

            //output 
            lblResult.Text = bmi.ToString();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDatavalid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDatavalid(txtName, txtAge);
        }

        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h, 2);
            return bmi;
        }

        private bool CheckDouble(TextBox txtH, TextBox txtW) 
        {
            double h = 0;
            double w = 0;
            if ((double.TryParse(txtH.Text, out h) == false) || (double.TryParse(txtW.Text, out w) == false))
            {
                MessageBox.Show("Error");
                return false;
            }
            return true;

        }
    }
}

