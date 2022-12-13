namespace _01_15_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var r1 = Enumerable.Range(0, 32).ToArray();
            r1 = r1.OrderBy(x => random.Next()).ToArray();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            for (var i=0; i < r1.Length; i++)
            {   
                if(i%4==0)
                listBox1.Items.Add((Karten)r1[i]);
                else if (i % 4 == 1)
                    listBox2.Items.Add((Karten)r1[i]);
                else if (i % 4 == 2)
                    listBox3.Items.Add((Karten)r1[i]);
                else 
                    listBox4.Items.Add((Karten)r1[i]);
            }
            
            
                
        }
    }
}