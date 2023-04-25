using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeGame
{
    public class Board
    {
        private int turn;
        private int numPlayers;
        private int currentPlayer;

        private List<Face> faceList;

        private List<Card> cardList;

        private Player[] playerArray;

        public Board(int players)
        {
            // Add each face to this list from txt file
            List<Face> faces = new List<Face>();
            string line;
            string[] data;
            System.IO.StreamReader faceFile = new System.IO.StreamReader("faces.txt");
            while ((line = faceFile.ReadLine()) != null)
            {
                data = line.Split(';');
                Face face = new Face(Int32.Parse(data[0]), Int32.Parse(data[1]), data[2],
                                     "images/faces/" + data[3], players);
                faces.Add(face);
            }
            faceFile.Close();

            this.faceList = faces;

            // Add each card to this list from txt file
            List<Card> cards = new List<Card>();

            System.IO.StreamReader cardFile = new System.IO.StreamReader("cards.txt");
            while ((line = cardFile.ReadLine()) != null)
            {
                data = line.Split(';');
                Card card = new Card(Int32.Parse(data[0]), Int32.Parse(data[1]), Int32.Parse(data[2]),
                                     Char.Parse(data[3]), data[4], data[5], data[6], data[7], "images/cards/" + data[8], "images/bg/" + data[9]);
                cards.Add(card);
            }
            cardFile.Close();

            this.cardList = cards;

            this.turn = 0;
            this.numPlayers = players;
            this.playerArray = new Player[players];
            this.currentPlayer = 1;
        }

        public void RollAll()
        {
            Random rnd = new Random();
            for (int i=0; i < this.numPlayers; i++)
            {
                int faceA = rnd.Next(0, 6);
                int faceB = rnd.Next(0, 6);

                this.playerArray[i].LastA = this.playerArray[i].DiceA[faceA];
                this.playerArray[i].LastB = this.playerArray[i].DiceB[faceB];

                DiceEffect(i, this.playerArray[i].DiceA[faceA].FaceID);
                DiceEffect(i, this.playerArray[i].DiceB[faceB].FaceID);
            }
        }

        public void RollOne(int die, int player)
        {
            Random rnd = new Random();
            if (die == 0)
            {
                int faceA = rnd.Next(0, 6);
                this.playerArray[player].LastA = this.playerArray[player].DiceA[faceA];
                DiceEffect(player, this.playerArray[player].DiceA[faceA].FaceID);
            } else if (die == 1)
            {
                int faceB = rnd.Next(0, 6);
                this.playerArray[player].LastB = this.playerArray[player].DiceA[faceB];
                DiceEffect(player, this.playerArray[player].DiceA[faceB].FaceID);
            }
        }

        public void FaceReplace(int oldFace, int newFace, int player, int die)
        {
            if (die == 0 )
            {
                playerArray[player].DiceA[oldFace] = FaceList[newFace];
            } else if (die == 1)
            {
                playerArray[player].DiceB[oldFace] = FaceList[newFace];
            }
        }

        public void DiceEffect(int player, int diceID)
        {
            switch (diceID)
            {
                default: MessageBox.Show("Error while rolling");
                         break;
                // Gold +1
                case 0:
                    if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                    {
                        this.playerArray[player].Gold++;
                    }
                    break;
                // Points +2
                case 1:
                    this.playerArray[player].Points = this.playerArray[player].Points + 2;
                    break;
                // Gold +3
                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    }
                    break;
                // Crystal +1
                case 3:
                    if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                    {
                        this.playerArray[player].Crystals++;
                    }
                    break;
                // Gold +4
                case 4:
                    for (int i = 0; i < 3; i++)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    }
                    break;
                // Heart +1 
                case 5:
                    if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                    {
                        this.playerArray[player].Hearts++;
                    }
                    break;
                // Gold +6
                case 6:
                    for (int i = 0; i < 5; i++)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    }
                    break;
                // Point +1 AND Heart +1
                case 7:
                    this.PlayerArray[player].Points++;
                    if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                    {
                        this.playerArray[player].Hearts++;
                    }
                    break;
                // Gold +2 AND Crystal +1
                case 8:
                    for (int i = 0; i < 1; i++)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    }
                    if (this.PlayerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                    {
                        this.playerArray[player].Crystals++;
                    }
                    break;
                // Gold +1 OR Heart +1 OR Crystal +1
                case 9:
                    FaceForm1 form = new FaceForm1(this.playerArray[player].Image);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    } else if (form.DialogResult == DialogResult.Yes)
                    {
                        if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                        {
                            this.playerArray[player].Hearts++;
                        }
                    } else if (form.DialogResult == DialogResult.No)
                    {
                        if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                        {
                            this.playerArray[player].Crystals++;
                        }
                    }
                    break;
                // Gold +3 OR Points +2
                case 10:
                    FaceForm2 form2 = new FaceForm2(this.playerArray[player].Image);
                    form2.ShowDialog();
                    if (form2.DialogResult == DialogResult.OK)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                            {
                                this.playerArray[player].Gold++;
                            }
                        }
                    }
                    else if (form2.DialogResult == DialogResult.Yes)
                    {
                       this.playerArray[player].Points = this.playerArray[player].Points + 2;
                    }
                    break;
                // Crystals +2
                case 11:
                    for (int i = 0; i < 1; i++)
                    {
                        if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                        {
                            this.playerArray[player].Crystals++;
                        }
                    }
                    break;
                // Hearts +2
                case 12:
                    for (int i = 0; i < 1; i++)
                    {
                        if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                        {
                            this.playerArray[player].Hearts++;
                        }
                    }
                    break;
                // Points +3
                case 13:
                    for (int i = 0; i < 3; i++)
                    {
                        this.playerArray[player].Points++;
                    }
                    break;
                // Gold +1 AND Crystals +1 AND Hearts +1 AND Points +1
                case 14:
                    this.PlayerArray[player].Points++;
                    if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                    {
                        this.playerArray[player].Hearts++;
                    }
                    if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                    {
                        this.playerArray[player].Crystals++;
                    }
                    if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                    {
                        this.playerArray[player].Gold++;
                    }
                    break;
                // Gold +2 OR Hearts +2 OR Crystals +2
                case 15:
                    FaceForm3 form3 = new FaceForm3(this.playerArray[player].Image);
                    form3.ShowDialog();
                    if (form3.DialogResult == DialogResult.OK)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                            {
                                this.playerArray[player].Gold++;
                            }
                        }
                    }
                    else if (form3.DialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                            {
                                this.playerArray[player].Hearts++;
                            }
                        }
                    }
                    else if (form3.DialogResult == DialogResult.No)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                            {
                                this.playerArray[player].Crystals++;
                            }
                        }
                    }
                    break;
                // Points +4
                case 16:
                    for (int i = 0; i < 4; i++)
                    {
                        this.playerArray[player].Points++;
                    }
                        break;
                // Points +2 AND Crystals +2
                case 17:
                    for (int i = 0; i < 2; i++)
                    {
                        this.playerArray[player].Points++;
                        if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                        {
                            this.playerArray[player].Crystals++;
                        }
                    }
                    break;
                // Choose any opponents dice face and obtain reward
                case 18:
                    break;
                // Multiply the resources from other dice by 3
                case 19:
                    if (this.playerArray[player].LastA.FaceID == 19 )
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            DiceEffect(player, this.playerArray[player].LastB.FaceID);
                        }
                    } else if (this.playerArray[player].LastB.FaceID == 19)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            DiceEffect(player, this.playerArray[player].LastA.FaceID);
                        }
                    }
                        break;
            }
        }

        public void CardEffect(int player, int cardID)
        {
            Card playCard = CardList[cardID];
            switch (cardID)
            {
                default:
                    break;
                // Ghost
                case 0:
                    if (PlayerArray[player].Gold < PlayerArray[player].MaxGold)
                    {
                        PlayerArray[player].Gold++;
                    }
                    break;
                // Bat
                case 1:
                    this.playerArray[player].MaxGold = this.playerArray[player].MaxGold + 4;
                    this.playerArray[player].MaxCrystals = this.playerArray[player].MaxCrystals + 4;
                    this.playerArray[player].MaxHearts = this.playerArray[player].MaxHearts + 4;
                    MessageBox.Show("Destroying the Zapf Bat gave you access to it's treasure hoard. Your maximum inventory has increased!");
                    break;
                // S & G
                case 2:
                    Forms.SelectDiceForm form = new Forms.SelectDiceForm(this, player);
                    form.ShowDialog();
                    break;
                // Dragon
                case 3:
                    DragonForm dForm = new DragonForm();
                    dForm.ShowDialog();
                    if (dForm.DialogResult == DialogResult.OK)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                            {
                                this.playerArray[player].Gold++;
                            }
                        }
                    }
                    else if (dForm.DialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                            {
                                this.playerArray[player].Hearts++;
                            }
                        }
                    }
                    else if (dForm.DialogResult == DialogResult.No)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                            {
                                this.playerArray[player].Crystals++;
                            }
                        }
                    }
                    int index = playerArray[player].CardList.FindIndex(c => c.CardID == 3);
                    playerArray[player].CardList.RemoveAt(index);
                    break;
                // Legion
                case 4:
                    this.playerArray[player].Points = this.playerArray[player].Points + 12;
                    break;
                // Succubus
                case 5:
                    Forms.SuccubusForm sForm = new Forms.SuccubusForm(this, player);
                    sForm.ShowDialog();
                    break;
                // Carmilla
                case 6:
                    RollOne(0, player);
                    RollOne(1, player);
                    RollOne(0, player);
                    RollOne(1, player);
                    break;
                // Skeleton
                case 7:
                    if (PlayerArray[player].Gold >= 3)
                    {
                        PlayerArray[player].Gold = PlayerArray[player].Gold - 3;
                        PlayerArray[player].Points = PlayerArray[player].Points + 4;
                    } else
                    {
                        MessageBox.Show("You don't have enough gold to summon the Skeleton!");
                    }
                    break;
                // Werewolf
                case 8:
                    for (int i = 0; i < 3; i++)
                    {
                        if (PlayerArray[player].Gold < PlayerArray[player].MaxGold)
                        {
                            PlayerArray[player].Gold++;
                        }
                        if (PlayerArray[player].Crystals < PlayerArray[player].MaxCrystals)
                        {
                            PlayerArray[player].Crystals++;
                        }
                    }
                    break;
                // Balore
                case 9:
                    FaceForm1 fForm1 = new FaceForm1(this.playerArray[player].Image);
                    fForm1.ShowDialog();
                    if (fForm1.DialogResult == DialogResult.OK)
                    {
                        if (this.playerArray[player].Gold < this.playerArray[player].MaxGold)
                        {
                            this.playerArray[player].Gold++;
                        }
                    }
                    else if (fForm1.DialogResult == DialogResult.Yes)
                    {
                        if (this.playerArray[player].Hearts < this.playerArray[player].MaxHearts)
                        {
                            this.playerArray[player].Hearts++;
                        }
                    }
                    else if (fForm1.DialogResult == DialogResult.No)
                    {
                        if (this.playerArray[player].Crystals < this.playerArray[player].MaxCrystals)
                        {
                            this.playerArray[player].Crystals++;
                        }
                    }
                    break;
                // Minotaur
                case 10:
                    Random rnd = new Random();
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        if (i != player)
                        {
                            int faceA = rnd.Next(0,6);
                            int faceB = rnd.Next(0,6);

                            this.playerArray[i].LastA = this.playerArray[i].DiceA[faceA];
                            this.playerArray[i].LastB = this.playerArray[i].DiceB[faceB];
                            // Dice A
                            if ((this.playerArray[i].LastA.FaceID == 1) || (this.playerArray[i].LastA.FaceID == 17))
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 2;
                            } else if ((this.playerArray[i].LastA.FaceID == 7) || (this.playerArray[i].LastA.FaceID == 14))
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 1;
                            } else if (this.playerArray[i].LastA.FaceID == 13)
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 3;
                            } else if (this.playerArray[i].LastA.FaceID == 16)
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 4;
                            }
                            // Dice B
                            if ((this.playerArray[i].LastB.FaceID == 1) || (this.playerArray[i].LastB.FaceID == 17))
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 2;
                            }
                            else if ((this.playerArray[i].LastB.FaceID == 7) || (this.playerArray[i].LastB.FaceID == 14))
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 1;
                            }
                            else if (this.playerArray[i].LastB.FaceID == 13)
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 3;
                            }
                            else if (this.playerArray[i].LastB.FaceID == 16)
                            {
                                this.playerArray[i].Points = this.playerArray[i].Points - 4;
                            }
                        }
                    }
                    break;
                // Medusa
                case 11:
                    this.playerArray[player].Points = this.playerArray[player].Points + 14;
                    break;
                // Puppet Master
                case 12:
                    Forms.PuppetForm pForm = new Forms.PuppetForm(this, player);
                    pForm.ShowDialog();
                    break;
                // Death
                case 13:
                    Forms.SelectDiceForm2 dtForm = new Forms.SelectDiceForm2(this, player);
                    dtForm.ShowDialog();
                    break;
                case 14:
                    this.playerArray[player].Points = this.playerArray[player].Points + 26;
                    break;
            }
        }

        public void EndTurn()
        {
            foreach (Card c in PlayerArray[currentPlayer - 1].CardList) {
                c.Used = false;
            }

            currentPlayer++;
            if (currentPlayer > numPlayers)
            {
                turn++;
                if (turn > 9)
                {
                    turn--;
                }
                currentPlayer = 1;
            }
            RollAll();
        }

        public int NumPlayers { get => numPlayers; set => numPlayers = value; }
        public int Turn { get => turn; set => turn = value; }
        internal List<Face> FaceList { get => faceList; set => faceList = value; }
        internal Player[] PlayerArray { get => playerArray; set => playerArray = value; }
        internal List<Card> CardList { get => cardList; set => cardList = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
    }
}
