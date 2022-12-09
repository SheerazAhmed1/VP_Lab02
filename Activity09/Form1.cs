namespace Activity09
{
    public partial class Form1 : Form
    {
        int firstValue, secondValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstValue=Convert.ToInt32(txtFirstValue.Text);
            secondValue=Convert.ToInt32(txtSecondValue.Text);
            txtResult.Text = (firstValue/secondValue).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(txtFirstValue.Text);
            secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResult.Text = (firstValue - secondValue).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(txtFirstValue.Text);
            secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResult.Text = (firstValue * secondValue).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(txtFirstValue.Text);
            secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResult.Text = (firstValue + secondValue).ToString();
        }
    }
}