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
    public partial class PuppetForm : Form
    {
        Board board;
        int player;
        public PuppetForm(Board b, int p)
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

        private void img_A0_Click(object sender, EventArgs e)
        {
            board.FaceReplace(0, 18, player, 0);
            return;
        }

        private void img_A1_Click(object sender, EventArgs e)
        {
            board.FaceReplace(1, 18, player, 0);
            return;
        }

        private void img_A2_Click(object sender, EventArgs e)
        {
            board.FaceReplace(2, 18, player, 0);
            return;
        }

        private void img_A3_Click(object sender, EventArgs e)
        {
            board.FaceReplace(3, 18, player, 0);
            return;
        }

        private void img_A4_Click(object sender, EventArgs e)
        {
            board.FaceReplace(4, 18, player, 0);
            return;
        }

        private void img_A5_Click(object sender, EventArgs e)
        {
            board.FaceReplace(5, 18, player, 0);
            return;
        }

        private void img_B0_Click(object sender, EventArgs e)
        {
            board.FaceReplace(0, 18, player, 1);
            return;
        }

        private void img_B1_Click(object sender, EventArgs e)
        {
            board.FaceReplace(1, 18, player, 1);
            return;
        }

        private void img_B2_Click(object sender, EventArgs e)
        {
            board.FaceReplace(2, 18, player, 1);
            return;
        }

        private void img_B3_Click(object sender, EventArgs e)
        {
            board.FaceReplace(3, 18, player, 1);
            return;
        }

        private void img_B4_Click(object sender, EventArgs e)
        {
            board.FaceReplace(4, 18, player, 1);
            return;
        }

        private void img_B5_Click(object sender, EventArgs e)
        {
            board.FaceReplace(5, 18, player, 1);
            return;
        }
    }
}
