namespace _01_07_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String KeyGenerator()
        {
            String[] key = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "B", "H" };
            var index = (new Random().Next(key.Length));
            return key[index];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = KeyGenerator();
        }
    }
}