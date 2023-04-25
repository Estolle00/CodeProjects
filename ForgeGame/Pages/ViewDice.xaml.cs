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
    /// Interaction logic for ViewDice.xaml
    /// </summary>
    public partial class ViewDice : Page
    {
        Board board;
        int player;
        public ViewDice(Board b)
        {
            InitializeComponent();
            this.board = b;
            player = board.CurrentPlayer - 1;

            //Display die faces
            img_A0.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[0].Image, UriKind.Relative));
            img_A1.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[1].Image, UriKind.Relative));
            img_A2.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[2].Image, UriKind.Relative));
            img_A3.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[3].Image, UriKind.Relative));
            img_A4.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[4].Image, UriKind.Relative));
            img_A5.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceA[5].Image, UriKind.Relative));

            img_B0.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[0].Image, UriKind.Relative));
            img_B1.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[1].Image, UriKind.Relative));
            img_B2.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[2].Image, UriKind.Relative));
            img_B3.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[3].Image, UriKind.Relative));
            img_B4.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[4].Image, UriKind.Relative));
            img_B5.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.PlayerArray[player].DiceB[5].Image, UriKind.Relative));
        }

        private void Desc_A0(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[0].Description;
        }

        private void Desc_A1(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[1].Description;
        }

        private void Desc_A2(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[2].Description;
        }

        private void Desc_A3(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[3].Description;
        }

        private void Desc_A4(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[4].Description;
        }

        private void Desc_A5(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceA[5].Description;
        }

        private void Desc_B0(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[0].Description;
        }

        private void Desc_B1(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[1].Description;
        }

        private void Desc_B2(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[2].Description;
        }

        private void Desc_B3(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[3].Description;
        }

        private void Desc_B4(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[4].Description;
        }

        private void Desc_B5(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = board.PlayerArray[player].DiceB[5].Description;
        }

        private void ClearDescription(object sender, RoutedEventArgs e)
        {
            lbl_desc.Content = "";
        }
        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Map(board));
        }
    }
}
