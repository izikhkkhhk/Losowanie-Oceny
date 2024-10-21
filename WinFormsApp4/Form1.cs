namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        
        public async void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Wylosowa³eœ:";
            time = 10;
            for (int i = 0; i < 30; i++)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Text = textBox3.Text;
                textBox3.Text = textBox4.Text;
                textBox4.Text = textBox5.Text;
                textBox5.Text = random.Next(1, 7).ToString();
                time += 10;
                await losowanie();
            }
            label2.Text = label2.Text + " Ocena " + textBox3.Text;
            
        }
        int time = 2;
        async Task losowanie()
        {
            time += 2;
            await Task.Delay(time);
        }
    }
}
