namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hello World");
            label1.Text = "Buton Týklandý ";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelJobValue.Text = "Muhendis";
            labelLastNameValue.Text= "Bektaþ";
            labelNameValue.Text = "Doða";
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            labelTransfered.Text = textBox1.Text.ToString();
        }
    }
}