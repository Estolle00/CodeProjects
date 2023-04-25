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
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        Board board;
        int currentPlayer;
        public Map(Board b)
        {
            InitializeComponent();
            this.board = b;
            currentPlayer = board.CurrentPlayer - 1;
            img_player.Source = new BitmapImage(new Uri("/ForgeGame;component/../images/idle/" + board.PlayerArray[currentPlayer].Image, UriKind.Relative));
            lbl_gold.Content = board.PlayerArray[currentPlayer].Gold;
            lbl_crystals.Content = board.PlayerArray[currentPlayer].Crystals;
            lbl_hearts.Content = board.PlayerArray[currentPlayer].Hearts;
            lbl_points.Content = board.PlayerArray[currentPlayer].Points;
            lbl_turn.Content = board.Turn + 1;

            //Update current location
            switch (board.PlayerArray[currentPlayer].CurrentLocation)
            {
                default:
                    lbl_location.Content = "Starting point";
                    break;
                case 0:
                    lbl_location.Content = "Warakiya Village";
                    break;
                case 1:
                    lbl_location.Content = "Cave Entrance";
                    break;
                case 2:
                    lbl_location.Content = "Haunted Ship";
                    break;
                case 3:
                    lbl_location.Content = "Tower of Terror";
                    break;
                case 4:
                    lbl_location.Content = "Catacombs";
                    break;
                case 5:
                    lbl_location.Content = "Alucard's Tomb";
                    break;
                case 6:
                    lbl_location.Content = "The Church";
                    break;
                case 7:
                    lbl_location.Content = "The Murky Marsh";
                    break;
                case 8:
                    lbl_location.Content = "Mad Forest";
                    break;
                case 9:
                    lbl_location.Content = "Lair of the Cyclops";
                    break;
                case 10:
                    lbl_location.Content = "The Crossway";
                    break;
                case 11:
                    lbl_location.Content = "Sunken City";
                    break;
                case 12:
                    lbl_location.Content = "Underground Passage";
                    break;
                case 13:
                    lbl_location.Content = "Clock Tower";
                    break;
                case 14:
                    lbl_location.Content = "Castlevania Keep";
                    break;
                case 15:
                    lbl_location.Content = "Starting point";
                    break;
            }

        }

        private void Btn_warakiya_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 0));
        }

        private void Btn_church_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 6));
        }

        private void Btn_forest_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 8));
        }

        private void Btn_marsh_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 7));
        }

        private void Btn_cyclops_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 9));
        }

        private void Btn_cave_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 1));
        }

        private void Btn_passage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 12));
        }

        private void Btn_ship_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 2));
        }

        private void Btn_catacombs_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 4));
        }

        private void Btn_alucard_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 5));
        }

        private void Btn_city_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 11));
        }

        private void Btn_tower_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 3));
        }

        private void Btn_bridge_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 10));
        }

        private void Btn_clock_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 13));
        }

        private void Btn_keep_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardPage(board, 14));
        }

        private void Btn_forge_Click(object sender, RoutedEventArgs e)
        {
           this.NavigationService.Navigate(new Forge(board));
        }

        private void Btn_dice_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewDice(this.board));
        }

        private void Btn_roll_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewCards(board));
        }

        private void Btn_end_Click(object sender, RoutedEventArgs e)
        {
            board.EndTurn();
            if (board.Turn == 9)
            {
                Player winner = null;
                int highScore = 0;

                foreach (Player p in board.PlayerArray)
                {
                    if (p.Points > highScore)
                    {
                        highScore = p.Points;
                        winner = p;
                    }
                }
                MainWindow.musicPlayer.Stop();
                this.NavigationService.Navigate(new Pages.VictoryPage(winner));
            }
            else
            {
                this.NavigationService.Navigate(new Map(board));
            }
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
