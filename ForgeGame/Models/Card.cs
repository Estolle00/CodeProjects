using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeGame
{
    public class Card
    {
        private int cardID;
        private int cost;
        private int pointValue;

        private char costType;

        private string name;
        private string description;
        private string effect;
        private string playType;
        private string image;
        private string background;

        private bool used;

        public Card(int cardID, int cost, int pointValue, char costType, string name, string description, string effect, string playType, string image, string background)
        {
            this.cardID = cardID;
            this.cost = cost;
            this.pointValue = pointValue;
            this.costType = costType;
            this.name = name;
            this.description = description;
            this.effect = effect;
            this.playType = playType;
            this.image = image;
            this.background = background;
            this.used = false;
        }

        public int CardID { get => cardID; set => cardID = value; }
        public int Cost { get => cost; set => cost = value; }
        public char CostType { get => costType; set => costType = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string PlayType { get => playType; set => playType = value; }
        public string Image { get => image; set => image = value; }
        public int PointValue { get => pointValue; set => pointValue = value; }
        public string Background { get => background; set => background = value; }
        public string Effect { get => effect; set => effect = value; }
        public bool Used { get => used; set => used = value; }
    }
}
