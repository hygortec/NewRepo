using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta_Facil
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        bool aux = false;
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void acaoAoPassarMouse(object sender, EventArgs e)
        {
            x = aleatorio.Next(12, 432);
            y = aleatorio.Next(12, 432);
            /*do
            {
                x = aleatorio.Next(12, 432);
                y = aleatorio.Next(12, 432);
                if ((x > 280 && x < 338) && (y > 12 && y < 174))
                {
                    aux = true;
                }else if((x > 93 && x < 100) && (y > 147 && y < 326))
                {
                    aux = true;
                }

            } while (aux);
           // aux = false;            

            //MessageBox.Show(Convert.ToString(i));            
            //MessageBox.Show(Convert.ToString(btnNao.Location));
            */
            btnNao.Location = new Point(x, y);       
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu já sabia!!!");
        }
    }
}
