
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            button65.BackColor = Color.LightGreen;
            textBox1.BackColor = Color.AntiqueWhite;
            textBox1.Text = "  Select One Place For First Minister >>>";
            EnableButtons();
            InVisiblePictures();           
        }


        
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SelectButton(button);            
        }

      
    }
}