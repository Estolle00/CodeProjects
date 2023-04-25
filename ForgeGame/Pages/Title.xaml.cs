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
    /// Interaction logic for Title.xaml
    /// </summary>
    public partial class Title : Page
    {
        MediaPlayer media;
        public Title()
        {
            InitializeComponent();
            media = new MediaPlayer();
            media.Open(new Uri("../../Audio/Music/intro.mp3", UriKind.Relative));
            media.Play();
        }

        private void BtnP2_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Board board = new Board(2);
            this.NavigationService.Navigate(new CharacterSelect(board));
        }

        private void BtnP3_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Board board = new Board(3);
            this.NavigationService.Navigate(new CharacterSelect(board));
        }

        private void BtnP4_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Board board = new Board(4);
            this.NavigationService.Navigate(new CharacterSelect(board));
        }

        private void BtnHowTo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.HowTo());
        }
    }
}
