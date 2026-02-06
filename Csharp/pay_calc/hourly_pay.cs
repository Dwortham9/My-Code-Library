namespace Homework_7
{
    public partial class hourly_pay : Form
    {
        public hourly_pay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pay_Rate = Convert.ToDouble(textBox_Rate.Text);
            double Hours = Convert.ToDouble(textBox_Hours.Text);

            double total = pay_Rate * Hours;

            textBox_Result.Text = total.ToString();

        }
    }
}