using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ForgeGame.Forms
{
    public partial class SelectDiceForm2 : Form
    {
        Board board;
        int player;
        public SelectDiceForm2(Board b, int p)
        {
            InitializeComponent();
            this.board = b;
            this.player = p;
            this.StartPosition = FormStartPosition.CenterScreen;

            img_A0.Image = (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[0].Image);
            img_A1.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[1].Image);
            img_A2.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[2].Image);
            img_A3.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[3].Image);
            img_A4.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[4].Image);
            img_A5.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[5].Image);

            img_B0.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[0].Image);
            img_B1.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[1].Image);
            img_B2.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[2].Image);
            img_B3.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[3].Image);
            img_B4.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[4].Image);
            img_B5.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceB[5].Image);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            board.RollOne(0, player);
            board.RollOne(0, player);
            board.RollOne(0, player);
            board.RollOne(0, player);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            board.RollOne(1, player);
            board.RollOne(1, player);
            board.RollOne(1, player);
            board.RollOne(1, player);
            this.Close();
        }
    }
}
