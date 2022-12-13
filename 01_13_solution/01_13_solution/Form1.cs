namespace _01_13_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int dez = 0;
            label5.Text = "";
            try
            {
                dez = Convert.ToInt32(textBox1.Text);
                
                textBox2.Text = Convert.ToString(dez, 8);
                textBox3.Text = dez.ToString("X");
                textBox4.Text = Convert.ToString(dez, 2); 
            }
            catch (Exception)
            {
                label5.Text = "Fehler bei der Umrechnung";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
           
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}