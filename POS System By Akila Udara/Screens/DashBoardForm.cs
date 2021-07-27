using POS_System_By_Akila_Udara.ProductsF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_By_Akila_Udara.Screens
{
    public partial class DashBoardForm : MetroFramework.Forms.MetroForm
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();
            dps.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
