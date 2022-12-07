namespace Activity06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month=(Convert.ToInt32(textBox1.Text));

            if(month>=1 && month <= 3)
            {
                label2.Text = "Season is Winter";
            }
            else if(month>=4 && month <= 6)
            {
                label2.Text = "Season is Spring";
            }
            else if(month >=7  && month <= 9)
            {
                label2.Text = "Season is Summer";
            }
            else if(month<=10 && month <= 12)
            {
                label2.Text = "Season is Autumn";
            }
        }
    }
}