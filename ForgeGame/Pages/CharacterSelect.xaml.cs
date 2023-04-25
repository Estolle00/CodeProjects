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
    /// Interaction logic for CharacterSelect.xaml
    /// </summary>
    public partial class CharacterSelect : Page
    {
        Board board;
        int count = 0;
        MediaPlayer media;
        MediaPlayer voice;

        public CharacterSelect(Board b)
        {
            InitializeComponent();
            this.board = b;
            media = new MediaPlayer();
            voice = new MediaPlayer();
            media.Volume = .2;
            media.Open(new Uri("../../Audio/Music/guest.mp3", UriKind.Relative));
            media.Play();
        }

        private void Btn_Shanoa_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("shanoa.png");
            voice.Open(new Uri("../../Audio/Sounds/shanoa.wav", UriKind.Relative));
            voice.Play();
            btn_Shanoa.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Simon_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("simon.png");
            voice.Open(new Uri("../../Audio/Sounds/simon.wav", UriKind.Relative));
            voice.Play();
            btn_Simon.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Charlotte_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("charlotte.png");
            voice.Open(new Uri("../../Audio/Sounds/charlotte.wav", UriKind.Relative));
            voice.Play();
            btn_Charlotte.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Maria_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("maria.png");
            voice.Open(new Uri("../../Audio/Sounds/maria.wav", UriKind.Relative));
            voice.Play();
            btn_Maria.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Soma_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("soma.png");
            voice.Open(new Uri("../../Audio/Sounds/soma.wav", UriKind.Relative));
            voice.Play();
            btn_Soma.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Sypha_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("sypha.png");
            voice.Open(new Uri("../../Audio/Sounds/sypha.wav", UriKind.Relative));
            voice.Play();
            btn_Sypha.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Trevor_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("trevor.png");
            voice.Open(new Uri("../../Audio/Sounds/trevor.wav", UriKind.Relative));
            voice.Play();
            btn_Trevor.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void Btn_Alucard_Click(object sender, RoutedEventArgs e)
        {
            CreatePlayer("alucard.png");
            voice.Open(new Uri("../../Audio/Sounds/alucard.wav", UriKind.Relative));
            voice.Play();
            btn_Alucard.Visibility = Visibility.Hidden;
            ReadyCheck();
        }

        private void ReadyCheck()
        {
            if (count == board.NumPlayers - 1)
            {
                media.Stop();
                MainWindow.PlayMusic();
                board.RollAll();
                this.NavigationService.Navigate(new Map(board));
            } else
            {
                count++;
                lbl_player.Content = String.Format("Player {0}, select your character.", count + 1);
            }

        }

        private void CreatePlayer(string img)
        {
            Player player = new Player(count + 1, img, board.FaceList);
            board.PlayerArray[count] = player;
        }

        private void ShowName(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            String name = btn.Name.Remove(0, 4);
            lbl_name.Content = name;
        }

        private void ClearName(object sender, RoutedEventArgs e)
        {
            lbl_name.Content = "";
        }
    }
}
