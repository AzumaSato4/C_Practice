namespace HelloForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloButtonClicked(object sender, EventArgs e)
        {
            helloLable.Text = "Hello World";
        }
    }
}
