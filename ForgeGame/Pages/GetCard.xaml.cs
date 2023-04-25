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

namespace ForgeGame.Pages
{
    /// <summary>
    /// Interaction logic for GetCard.xaml
    /// </summary>
    public partial class GetCard : Page
    {
        Board board;
        int player;
        int cardID;
        MediaPlayer media;
        public GetCard(Board b, int p, int c)
        {
            InitializeComponent();
            board = b;
            player = p;
            cardID = c;

            lbl_message.Content = board.CardList[cardID].Name;
            img_monster.Source = new BitmapImage(new Uri("/ForgeGame;component/" + board.CardList[cardID].Image, UriKind.Relative));
            media = new MediaPlayer();
            media.Open(new Uri("../../Audio/Sounds/_3.wav", UriKind.Relative));
            media.Play();
        }

        private void Btn_goAgain_Click(object sender, RoutedEventArgs e)
        {
            if (board.PlayerArray[player].Hearts >= 2)
            {
                board.PlayerArray[player].Hearts = board.PlayerArray[player].Hearts - 2;
                this.NavigationService.Navigate(new Map(board));
            } else
            {
                MessageBox.Show("You'll need to have at least 2 hearts to go again!");
            }
        }

        private void Btn_end_Click(object sender, RoutedEventArgs e)
        {
            board.EndTurn();
            this.NavigationService.Navigate(new Map(board));
        }
    }
}
