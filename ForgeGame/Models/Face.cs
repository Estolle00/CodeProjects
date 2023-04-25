using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeGame
{
    public class Face
    {
        private int faceID;
        private int cost;
        private int qty;

        private string description;
        private string image;

        public Face(int faceID, int cost, string description, string image, int qty)
        {
            this.faceID = faceID;
            this.cost = cost;
            this.description = description;
            this.image = image;
            this.qty = qty;
        }

        public int FaceID { get => faceID; set => faceID = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public int Qty { get => qty; set => qty = value; }
    }
}
