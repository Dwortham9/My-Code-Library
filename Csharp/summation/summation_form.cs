namespace Homework_12
{
    public partial class summation_form : Form
    {
        public summation_form()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(textBox_start.Text);
            int n = Convert.ToInt32(textBox_stop.Text);
            int total = 0;

            for (int i = 0; i <= n; i++)
            {
                total += i;
            }
            textBox_total.Text = total.ToString();
        }
    }
}