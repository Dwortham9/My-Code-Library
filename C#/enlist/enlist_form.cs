namespace Homework_9
{
    public partial class enlist_form : Form
    {
        public enlist_form()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int age;
            age = Int32.Parse(textBox1.Text);
            if (age < 17) 
            {
                MessageBox.Show("You are too young to enlist.");
            }
            else if (age == 17)
            {
                MessageBox.Show("You can enlist with parental permission.");
            }
            else if (age >= 18 && age <= 31) 
            {
                MessageBox.Show("You can enlist.");
            }
            else if (age >= 32 && age <= 40)
            {
                MessageBox.Show("You can enlist if you are a reservist.");
            }
            else if (age > 40)
            {
                MessageBox.Show("You are too old to enlist.");
            }


        }
    }
}