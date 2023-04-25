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
using System.Timers;

namespace ForgeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer musicPlayer;
        public static List<String> songList;
        public MainWindow()
        {
            InitializeComponent();
            songList = new List<string>();
            for (int i = 0; i <= 21; i++)
            {
                songList.Add(i + ".mp3");
            }
            MainFrame.NavigationService.Navigate(new Title());
        }

        public static void PlayMusic()
        {
            musicPlayer = new MediaPlayer();
            Random rnd = new Random();
            int index;
            index = rnd.Next(0, 22);
            musicPlayer.Open(new Uri("../../Audio/Music/" + songList[index], UriKind.Relative));
            musicPlayer.Play();
            musicPlayer.MediaEnded += OnSongEnd;
        }

        private static void OnSongEnd(object sender, object e)
        {
            musicPlayer.Stop();
            PlayMusic();
        }
    }
}
