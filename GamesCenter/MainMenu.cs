using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesCenter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            Form frmSnake = new Snake.SnakeFrm();
            frmSnake.Show();
        }
    }
}
