using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverTopShooterGame
{
    public partial class TitleScreen : Form
    {
        zombieGame gameScreen = new zombieGame();
        public TitleScreen()
        {
            InitializeComponent();
            
        }
        private void StartGame(object sender, EventArgs e)
        {
            gameScreen.Show();
            gameScreen.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void QuitGame(object sender, EventArgs e)
        {
            gameScreen.Close();
            Close();
        }


    }
}
