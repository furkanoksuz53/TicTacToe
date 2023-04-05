using System.Runtime.CompilerServices;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        int count = 0;
        int winX = 0;
        int winO = 0;
                
        private void c3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;            
            button.Text = count % 2 == 0 ? "X" : "O";
            button.Enabled = false;
            lblCurrentPlayer.Text = count % 2 == 0 ? "Sıradaki oyuncu : O" : "Sıradaki oyuncu : X";
            count++;
            CheckWinner();            
            
        }
        private void CheckWinner()
        {
            if( 
                a1.Text + a2.Text+  a3.Text == "XXX" ||
                b1.Text + b2.Text + b3.Text == "XXX" ||
                c1.Text + c2.Text + c3.Text == "XXX" ||
                a1.Text + b1.Text + c1.Text == "XXX" ||
                a2.Text + b2.Text + c2.Text == "XXX" ||
                a3.Text + b3.Text + c3.Text == "XXX" ||
                a1.Text + b2.Text + c3.Text == "XXX" ||
                a3.Text + b2.Text + c1.Text == "XXX") 
            {
                MessageBox.Show("Oyuncu X kazandı");
                winX++;
                lblX.Text = "Oyuncu X : " + winX;
                Clear();
                
            }
            else if(   
                a1.Text + a2.Text + a3.Text == "OOO" ||
                b1.Text + b2.Text + b3.Text == "OOO" ||
                c1.Text + c2.Text + c3.Text == "OOO" ||
                a1.Text + b1.Text + c1.Text == "OOO" ||
                a2.Text + b2.Text + c2.Text == "OOO" ||
                a3.Text + b3.Text + c3.Text == "OOO" ||
                a1.Text + b2.Text + c3.Text == "OOO" ||
                a3.Text + b2.Text + c1.Text == "OOO") 
            {
                MessageBox.Show("Oyuncu O kazandı");
                winO++;
                lblO.Text ="Oyuncu O : " +winO ;
                Clear();
            }
            else if( count + 1 == 9)
            {
                MessageBox.Show("Berabere");
                Clear();
            }
            else { }

        }
        private void Clear()
        {
            a1.Text = string.Empty;            
            a2.Text = string.Empty;
            a3.Text = string.Empty;
            b1.Text = string.Empty;
            b2.Text = string.Empty;
            b3.Text = string.Empty;
            c1.Text = string.Empty;
            c2.Text = string.Empty;
            c3.Text = string.Empty;
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true; 
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true; 
            c2.Enabled = true;
            c3.Enabled = true;
            count = 0;
            lblCurrentPlayer.Text = "Sıradaki oyuncu : X";

        }
        private void Reset()
        {
            Clear();
            winO = 0;
            winX = 0;
            lblX.Text = "Oyuncu X : " + winX;
            lblO.Text = "Oyuncu O : " + winO;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnHowPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("·Oyuna kimin başlayacağına ve hangi sembolü kullanacağına karar verilir. (Yazı-tura / taş-kağıt-makas gibi yöntemler kullanılabilir.)\r\n\r\n·Oyunculardan biri X, diğeri O sembolünü kullanmalıdır.\r\n\r\n·Oyun sonunda 3 aynı sembolü arka arkaya sıralayan oyuncu, 3 sembolün üzerine çizik atar ve oyunu kazanır.\r\n\r\n·Oyun sonunda 3 aynı sembol arka arkaya sıralanamamış ise oyun beraberedir.");
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Vulture53 on April 5, 2023");
        }
    }
}