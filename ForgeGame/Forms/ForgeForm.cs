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
    public partial class ForgeForm : Form
    {
        Board board;
        int player;
        int newFace;
        public ForgeForm(Board b, int p, int n)
        {
            InitializeComponent();
            this.board = b;
            this.player = p;
            this.newFace = n;
            this.StartPosition = FormStartPosition.CenterScreen;

            img_A0.Image =  (Bitmap)Image.FromFile("../../" + board.PlayerArray[player].DiceA[0].Image);
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
            board.FaceReplace(0, newFace, player, 0);
            this.Close();
        }

        private void img_A1_Click(object sender, EventArgs e)
        {
            board.FaceReplace(1, newFace, player, 0);
            this.Close();
        }

        private void img_A2_Click(object sender, EventArgs e)
        {
            board.FaceReplace(2, newFace, player, 0);
            this.Close();
        }

        private void img_A3_Click(object sender, EventArgs e)
        {
            board.FaceReplace(3, newFace, player, 0);
            this.Close();
        }

        private void img_A4_Click(object sender, EventArgs e)
        {
            board.FaceReplace(4, newFace, player, 0);
            this.Close();
        }

        private void img_A5_Click(object sender, EventArgs e)
        {
            board.FaceReplace(5, newFace, player, 0);
            this.Close();
        }

        private void img_B0_Click(object sender, EventArgs e)
        {
            board.FaceReplace(0, newFace, player, 1);
            this.Close();
        }

        private void img_B1_Click(object sender, EventArgs e)
        {
            board.FaceReplace(1, newFace, player, 1);
            this.Close();
        }

        private void img_B2_Click(object sender, EventArgs e)
        {
            board.FaceReplace(2, newFace, player, 1);
            this.Close();
        }

        private void img_B3_Click(object sender, EventArgs e)
        {
            board.FaceReplace(3, newFace, player, 1);
            this.Close();
        }

        private void img_B4_Click(object sender, EventArgs e)
        {
            board.FaceReplace(4, newFace, player, 1);
            this.Close();
        }

        private void img_B5_Click(object sender, EventArgs e)
        {
            board.FaceReplace(5, newFace, player, 1);
            this.Close();
        }
    }
}
