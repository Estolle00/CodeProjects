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
    public partial class FaceForm1 : Form
    {
        public FaceForm1(String name)
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

        private void btn_heart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_crystal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
