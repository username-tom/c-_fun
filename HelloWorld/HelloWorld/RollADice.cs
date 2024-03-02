namespace HelloWorld
{
    public partial class RollADice : Form
    {

        int diceRoll = 6;
        Random rnd = new Random();

        public RollADice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            diceRoll = rnd.Next(1, 7);
            LblOutput.Text = diceRoll.ToString();
        }
    }
}
