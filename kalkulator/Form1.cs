namespace kalkulator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        Control ActiveControl;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || (operation_pressed))
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value= Double.Parse(textBox_result.Text);
            operation_pressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            switch (operation)
            {
                case "+": textBox_result.Text = (value + double.Parse(textBox_result.Text)).ToString(); break;
                case "-": textBox_result.Text = (value - double.Parse(textBox_result.Text)).ToString(); break;
                case ":": textBox_result.Text = (value / double.Parse(textBox_result.Text)).ToString(); break;
                case "X": textBox_result.Text = (value * double.Parse(textBox_result.Text)).ToString(); break;
            }
        }
    }
}