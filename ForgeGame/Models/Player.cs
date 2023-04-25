using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeGame
{
    public class Player
    {
        private int playerID;
        private int gold;
        private int maxGold;
        private int hearts;
        private int maxHearts;
        private int crystals;
        private int maxCrystals;
        private int points;
        private int currentLocation;

        private List<Card> cardList;

        private Face[] diceA;
        private Face[] diceB;

        private Face lastA;
        private Face lastB;

        private string image;

        public Player(int playerID, string image, List<Face> faceList)
        {
            this.playerID = playerID;
            this.gold = 0;
            this.maxGold = 12;
            this.hearts = 0;
            this.maxHearts = 8;
            this.crystals = 0;
            this.maxCrystals = 8;
            this.points = 0;
            this.currentLocation = 15;
            this.cardList = new List<Card>();
            // Set starting faces for dice
            this.diceA = new Face[6];
            this.diceA[0] = faceList[0];
            this.diceA[1] = faceList[0];
            this.diceA[2] = faceList[0];
            this.diceA[3] = faceList[0];
            this.diceA[4] = faceList[0];
            this.diceA[5] = faceList[5];

            this.diceB = new Face[6];
            this.diceB[0] = faceList[0];
            this.diceB[1] = faceList[0];
            this.diceB[2] = faceList[0];
            this.diceB[3] = faceList[0];
            this.diceB[4] = faceList[1];
            this.diceB[5] = faceList[3];

            this.lastA = this.diceA[0];
            this.lastB = this.diceB[0];

            this.image = image;
        }

        public int PlayerID { get => playerID; set => playerID = value; }
        public int Gold { get => gold; set => gold = value; }
        public int MaxGold { get => maxGold; set => maxGold = value; }
        public int Hearts { get => hearts; set => hearts = value; }
        public int MaxHearts { get => maxHearts; set => maxHearts = value; }
        public int Crystals { get => crystals; set => crystals = value; }
        public int MaxCrystals { get => maxCrystals; set => maxCrystals = value; }
        public int Points { get => points; set => points = value; }
        public List<Card> CardList { get => cardList; set => cardList = value; }
        public Face[] DiceA { get => diceA; set => diceA = value; }
        public Face[] DiceB { get => diceB; set => diceB = value; }
        public string Image { get => image; set => image = value; }
        public Face LastA { get => lastA; set => lastA = value; }
        public Face LastB { get => lastB; set => lastB = value; }
        public int CurrentLocation { get => currentLocation; set => currentLocation = value; }
    }
}
