using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeGame
{
    public partial class FaceForm2 : Form
    {
        public FaceForm2(String name)
        {
            InitializeComponent();
            name = name.Remove(name.Length - 4, 4);
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_name.Text = name.ToUpper();
        }

        private void FaceForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_gold_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
