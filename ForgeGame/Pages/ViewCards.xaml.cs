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
    /// Interaction logic for ViewCards.xaml
    /// </summary>
    public partial class ViewCards : Page
    {
        Board board;
        List<Card> cardList;
        int player;
        public ViewCards(Board b)
        {
            InitializeComponent();
            this.board = b;
            this.player = board.CurrentPlayer - 1;
            cardList = b.PlayerArray[player].CardList;

            for (int i = 0; i < cardList.Count; i++)
            {
                if (cardList[i].PlayType.Equals("c") && (cardList[i].Used == false))
                {
                    list_card.Items.Add(cardList[i].Name + ": " + cardList[i].Effect);
                }
            }

            
        }

        private void Btn_UseAbility_Click(object sender, RoutedEventArgs e)
        {
            int index = list_card.SelectedIndex;
            if (index != -1)
            {
                board.CardEffect(player, board.PlayerArray[player].CardList[index].CardID);
                board.PlayerArray[player].CardList[index].Used = true;
                this.NavigationService.Navigate(new Map(board));
            } else
            {
                MessageBox.Show("You need to select a monster before you can use it's ability.");
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Map(board));
        }
    }
}
