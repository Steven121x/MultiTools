using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiTools.Class;

namespace MultiTools.Formularios
{
    
    public partial class Login : Form
    {
        //Informacion de la applicacion de keyauth para vincularla a mi proyecto
        public static api KeyAuthApp = new api(
           name: "MultiTools",
           ownerid: "271HPXYRbO",
           secret: "f5aaaad12999ec68017f83cd64082fe100e5785d038e883966749a024b9c748d",
           version: "1.0"
        );

        public Login()
        {
           
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Sitema del API para validar el usuario y contraseña
            Login.KeyAuthApp.login(txtUsuario.Text, txtPass.Text);
            if (Login.KeyAuthApp.response.success)
            {
                Form1 main = new Form1();
                main.Show();
                base.Hide();
            }
            else
            {
                //error o contraseña incorrecta
                MessageBox.Show(Login.KeyAuthApp.response.message);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Iniciar el keyauth
            KeyAuthApp.init();
        }
    }
}
