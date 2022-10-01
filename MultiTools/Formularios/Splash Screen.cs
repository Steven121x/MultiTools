using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTools.Formularios
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer para aumentar el ancho del panel para hacer un efecto de carga
            int with = 698;
            if(panelLoading.Width < with)
            {
                panelLoading.Width += 6;
            }
            else
            {
                //Aqui paramos el stop porque ya la condicion no se cumple
                timer1.Stop();
                Login MostrarLogin = new Login();
                this.Hide();
                MostrarLogin.Show();
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelWith_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
