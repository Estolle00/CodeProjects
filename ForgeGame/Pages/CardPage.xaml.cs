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
    /// Interaction logic for CardPage.xaml
    /// </summary>
    public partial class CardPage : Page
    {
        Board board;
        Card card;
        int player;
        public CardPage(Board b, int cid)
        {
            InitializeComponent();
            this.board = b;
            this.card = board.CardList[cid];
            this.player = board.CurrentPlayer - 1;
            // Populate text info about card
            lbl_name.Content = card.Name;
            txt_effect.Text = card.Effect;
            lbl_cost.Content = card.Cost;
            lbl_points.Content = card.PointValue;
            txt_description.Text = card.Description;
            // Populate card-specific images
            img_background.Source = new BitmapImage(new Uri("/ForgeGame;component/" + card.Background, UriKind.Relative));
            img_player.Source = new BitmapImage(new Uri("/ForgeGame;component/../images/action/" + board.PlayerArray[player].Image, UriKind.Relative));
            if (card.CostType.Equals('c'))
            {
                img_currency.Source = new BitmapImage(new Uri("/ForgeGame;component/../images/crystal.png", UriKind.Relative));
            } else if (card.CostType.Equals('h'))
            {
                img_currency.Source = new BitmapImage(new Uri("/ForgeGame;component/../images/heart.png", UriKind.Relative));
            } else if (card.CostType.Equals('b'))
            {
                img_currency.Source = new BitmapImage(new Uri("/ForgeGame;component/../images/both.png", UriKind.Relative));
            }

            if (card.PlayType.Equals("i"))
            {
                lbl_type.Content = "Instant";
            } else if (card.PlayType.Equals("c"))
            {
                lbl_type.Content = "Continuous";
            }

        }

        private void Btn_map_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Map(board));
        }

        private void Btn_fight_Click(object sender, RoutedEventArgs e)
        {
            // Check if player already has card
            foreach (Card c in board.PlayerArray[player].CardList) {
                if (card.CardID == c.CardID)
                {
                    MessageBox.Show("You've already defeated this monster!");
                    return;
                }
            }
            // Check if player has enough resources
            if (card.CostType.Equals('c'))
            {
                if (board.PlayerArray[player].Crystals < card.Cost)
                {
                    MessageBox.Show("You don't have enough crystals to challenge this monster!");
                    return;
                }
            }
            else if (card.CostType.Equals('h'))
            {
                if (board.PlayerArray[player].Hearts < card.Cost)
                {
                    MessageBox.Show("You don't have enough hearts to confront this creature!");
                    return;
                }
            }
            else if (card.CostType.Equals('b'))
            {
                if ((board.PlayerArray[player].Hearts < 5) || (board.PlayerArray[player].Crystals < 5))
                {
                    MessageBox.Show("You don't have the resources needed to destroy Dracula!");
                    return;
                }
            }
            // Add card to list and update current location for player
     
            if (card.CostType.Equals('c'))
            {
                board.PlayerArray[player].Crystals -= card.Cost;
            }
            else if (card.CostType.Equals('h'))
            {
                board.PlayerArray[player].Hearts -= card.Cost;
            }
            else if (card.CostType.Equals('b'))
            {
                board.PlayerArray[player].Crystals -= 5;
                board.PlayerArray[player].Hearts -= 5;
            }
            board.PlayerArray[player].CurrentLocation = card.CardID;
            board.PlayerArray[player].CardList.Add(card);
            this.NavigationService.Navigate(new Pages.GetCard(board, player, card.CardID));
        }
    }
}
