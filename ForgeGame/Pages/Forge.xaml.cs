using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForgeGame
{
    /// <summary>
    /// Interaction logic for Forge.xaml
    /// </summary>
    public partial class Forge : Page
    {
        Board board;
        public Forge(Board b)
        {
            InitializeComponent();
            this.board = b;
            lbl_gold.Content = board.PlayerArray[board.CurrentPlayer - 1].Gold;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Map(board));
        }

        private void Btn_2a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(2)) {
                 
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 2);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_2b_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(3)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 3);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_3a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(4)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 4);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_3b_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(5)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 5);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_4a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(6)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 6);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_4b_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(7)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 7);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_4c_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(8)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 8);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_4d_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(9)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 9);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_5a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(10)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 10);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_6a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(11)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 11);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_8a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(12)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 12);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_8b_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(13)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 13);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_12a_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(14)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 14);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_12b_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(15)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 15);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_12c_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(16)) {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 16);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_12d_Click(object sender, RoutedEventArgs e)
        {
            if (GoldCheck(17))
            {
                Forms.ForgeForm fForm = new Forms.ForgeForm(board, board.CurrentPlayer - 1, 17);
                fForm.ShowDialog();
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void btn_2a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[2].Description;
        }

        private void btn_2b_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[3].Description;
        }

        private void btn_3a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[4].Description;
        }

        private void btn_3b_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[5].Description;
        }

        private void btn_4a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[6].Description;
        }

        private void btn_4b_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[7].Description;
        }

        private void btn_4c_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[8].Description;
        }

        private void btn_4d_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[9].Description;
        }

        private void btn_5a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[10].Description;
        }

        private void btn_6a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[11].Description;
        }

        private void btn_8a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[12].Description;
        }
        private void btn_8b_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[13].Description;
        }

        private void btn_12a_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[14].Description;
        }

        private void btn_12b_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[15].Description;
        }

        private void btn_12c_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[16].Description;
        }

        private void btn_12d_enter(object sender, RoutedEventArgs e)
        {
            txt_description.Text = board.FaceList[17].Description;
        }

        private bool GoldCheck(int id)
        {
            if (board.PlayerArray[board.CurrentPlayer - 1].Gold < board.FaceList[id].Cost)
            {
                MessageBox.Show("You don't have enough gold to buy that!");
                return false;
            }
            else
            {
                board.PlayerArray[board.CurrentPlayer - 1].Gold = board.PlayerArray[board.CurrentPlayer - 1].Gold - board.FaceList[id].Cost;
                return true;
            }
        }
        private void ClearDescription(object sender, RoutedEventArgs e)
        {
            txt_description.Text = "Hover over a dice face to learn more about it.";
        }
    }
}
