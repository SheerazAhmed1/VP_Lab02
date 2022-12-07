namespace Activity07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int units = Convert.ToInt32(this.textBox1.Text);
            int temp;
            int price;

            if(units <= 100)
            {
                price = units * 2;
                label2.Text="Your Bill is Rs."+price;
            }
            else if (units>100 && units <= 200)
            {
                temp = units - 100;
                price = temp * 3;
                price += 100 * 2;
                label2.Text = "Your Bill is Rs." + price;
            }
            else if(units>200 && units <= 300)
            {
                temp = units - 200;
                price = temp * 4;
                price += (100 * 2)+(100*3);
                label2.Text = "Your Bill is Rs." + price;
            }
            else if (units > 300)
            {
                temp = units - 300;
                price = temp * 7;
                price += (100 * 2) + (100 * 3) + (100 * 4);
                label2.Text = "Your Bill is Rs." + price;
            }
        }
    }
}