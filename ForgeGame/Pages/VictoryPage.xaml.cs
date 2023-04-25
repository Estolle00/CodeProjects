using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for VictoryPage.xaml
    /// </summary>
    public partial class VictoryPage : Page
    {
        MediaPlayer player;
        public VictoryPage(Player p)
        {
            InitializeComponent();
            grid.Background = new SolidColorBrush(Colors.Black);
            String name = p.Image.Remove(p.Image.Length - 4, 4);
            name = char.ToUpper(name[0]) + name.Substring(1);
            Thread.Sleep(5000);
            player = new MediaPlayer();
            player.Open(new Uri("../../Audio/Music/win.mp3", UriKind.Relative));
            player.Play();
            img.Source = new BitmapImage(new Uri("/ForgeGame;component/images/victory/" + p.Image, UriKind.Relative));
            lbl_name.Content = lbl_name.Content + name + "!";
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
