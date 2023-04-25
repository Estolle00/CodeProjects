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
    /// Interaction logic for HowTo.xaml
    /// </summary>
    public partial class HowTo : Page
    {
        public HowTo()
        {
            InitializeComponent();
        }

        private void Btn_objective_Click(object sender, RoutedEventArgs e)
        {
            TxtBlock.Text =
                "Welcome to the hunt! The goal of this game is simple: get more points than your opponents. How you go about that however, " +
                "is where the challenge is.\n\n" +
                "You can obtain points in multiple ways. One such way requries you to roll your dice and getting a side that earns " +
                "you points. You can also challenge a host of nightmarish monsters, many granting a trove of points upon being defeated " +
                "(as well as unique abilities that will help you and hinder your foes). Each battle comes at a cost, however....\n\n" +
                "Strategize your way to victory, and prove yourself the supreme vampire hunter!";
        }

        private void Btn_currency_Click(object sender, RoutedEventArgs e)
        {
            TxtBlock.Text =
                "Points aren't the only thing that you'll need to win. You'll also need to stock up on three forms of currency for your hunt: " +
                "Gold pieces, hearts, and crystals.\n\n" +
                "Gold is likely the most common form you'll come by. It's primarily used to forge new faces onto your die (more on that in the) " +
                "next section). Rumor has it that a certain monster also allows you to trade gold for points as well...\n\n " +
                "Hearts and crystals are used for challenging monsters. Each monster has cost you must pay to defeat it (for example, you will " +
                "need 1 crystal to defeat a Ghost). The type you'll need as well as how many will differ from monster to monster. Hearts also " +
                "have secondary function. Ordinarily after defeating a monster, your turn is over. However, you may spend two hearts to go once " +
                "again.\n\n" +
                "Keep these things in mind while building your dice!";
        }

        private void Btn_dice_Click(object sender, RoutedEventArgs e)
        {
            TxtBlock.Text =
                "At the beginning of each player's turn, everyone rolls their two dice and obtains their rewards (this is done automatically). To " +
                "truly start raking in the rewards, you'll have to customize your dice.\n\n" + 
                "This can be done by clicking on the 'Forge Dice' button on the map screen. From here, you can spend your hard-won gold on new dice faces. Their effects vary, ranging from choosing your " +
                "own loot to stealing the effects of another players' roll! Simply hover the mouse over the face you want to learn more about, and " +
                "a description will appear. Then, you can choose which face to replace on one of your dice. Your turn is over after this.";
        }

        private void Btn_cards_Click(object sender, RoutedEventArgs e)
        {
            TxtBlock.Text =
                "The world wouldn't need heroes if their weren't villains, right? Scattered throughout the map are different areas, each one the " +
                "home of a dreadful creature of te night. Upon clicking on one of these areas, you are able to see which monster is found there, as " +
                "well as some other information.\n\n" +
                "You can see the cost for fighting the monster, how many points you'll get for defeating them, and their play type.\n" +
                "There's two play types: Instant and Continuous. A monster with an Instant type will activate it's ability immediately upon defeat. " +
                "Continuous abilities cannot be activated that turn, but from the 'Abilities' menu on the map the next turn.";
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Title());
        }
    }
}
