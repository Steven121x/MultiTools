using MultiTools.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordMessenger;
using MultiTools.Formularios;

namespace MultiTools
{
    public partial class Form1 : Form
    {
        //Variables

        //Variable de tipo de tarea webhook
        private string webHookTipoTarea;
        //Dos variables para la calculadora y obtener el valor de los dos valores del usuario
        private double num1;
        private double num2;
        //Variable de operador | calculadora
        private String operador;
        //Variable del resultado de la operacion con la calculadora
        private double resultado;
        //Variable de author de la tarea
        private string author;
        //Variables para las webhook
        private string webHookURL;
        private string webHook2URL;
        
        public Form1()
        {
            InitializeComponent();

            //Mostrar Ocultar paneles hijos
            PanelCenter.Visible = true;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = false;
            panelCalculadora.Visible = false;
            panelConversor.Visible = false;
            paneIPlookup.Visible = false;

            //Estado y informacion de tu usuario
             


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostrar hora y datos
            lbFecha.Text = DateTime.Now.ToShortDateString();
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void panelizquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = true;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = false;
            panelCalculadora.Visible = false;
            panelConversor.Visible = false;
            paneIPlookup.Visible = false;
        }

        private void btnAdmTareas_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = false;
            panelAdmTarea.Visible = true;
            panelAPI.Visible = false;
            panelCalculadora.Visible = false;
            panelConversor.Visible = false;
            paneIPlookup.Visible = false;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = false;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = false;
            panelCalculadora.Visible = true;
            panelConversor.Visible = false;
            paneIPlookup.Visible = false;
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = false;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = false;
            panelCalculadora.Visible = false;
            panelConversor.Visible = true;
            paneIPlookup.Visible = false;
        }

        private void btnIpLookup_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = false;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = false;
            panelCalculadora.Visible = false;
            panelConversor.Visible = false;
            paneIPlookup.Visible = true;
        }

        private void btnApi_Click(object sender, EventArgs e)
        {
            PanelCenter.Visible = false;
            panelAdmTarea.Visible = false;
            panelAPI.Visible = true;
            panelCalculadora.Visible = false;
            panelConversor.Visible = false;
            paneIPlookup.Visible = false;
        }

        private void panelCalculadora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void panelAdmTarea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
        }

        private void paneIPlookup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtInputIp_Enter(object sender, EventArgs e)
        {
        }

        private void txtInputIp_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtInputIp_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            GetInfoIp();
        }

        public void GetInfoIp()
        {
            //Obtener informacion sobre una ip con un metodo de clase del objeto
            IPlookup Search = new IPlookup();
            Search.GetAdress(txtInputIp.Text.ToString());
            txtInformacionIp.Text = Search.GetInformacion().ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Metodo calcular divisas
            CalcularDivisas();
        }

        public void CalcularDivisas()
        {
            Divisas Calcular = new Divisas(); //Creando objeto / Instancia
            try //Try catch para capturar alguna excepxion por el usuario
            {
                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Porfavor rellena el campo, esta vacio !");
                }
            }
            catch (Exception)
            {
            }
            if (cbDivisas.SelectedIndex == 0) //Condiciones para revisar las casillas del cbDivisas y saber que metodo llamar
            {
                Calcular.UsdToDop(double.Parse(txtCantidad.Text));
                //txtResultado.Text = Calcular.resultadoAll.ToString(); 
                txtResultado.Text = Calcular.GetResultadoDi().ToString();
            }
            if (cbDivisas.SelectedIndex == 1)
            {
                Calcular.DopToUsd(double.Parse(txtCantidad.Text));
                txtResultado.Text = Calcular.GetResultadoDi().ToString();
            }
            if (cbDivisas.SelectedIndex == 2)
            {
                Calcular.UsdToEur(double.Parse(txtCantidad.Text));
                txtResultado.Text = Calcular.GetResultadoDi().ToString();
            }
            if (cbDivisas.SelectedIndex == 3)
            {
                Calcular.SolesToUsd(double.Parse(txtCantidad.Text));
                txtResultado.Text = Calcular.GetResultadoDi().ToString();
            }
            if (cbDivisas.SelectedIndex == 4)
            {
                Calcular.MxToUsd(double.Parse(txtCantidad.Text));
                txtResultado.Text = Calcular.GetResultadoDi().ToString();
            }

        }

        private void panelConversor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 4;
        }

        private void btnDelTodo2_Click(object sender, EventArgs e)
        {
            txtPanel.Clear();
        }

        private void uno_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 1;
            Console.Beep(1000, 20);

        }

        private void dos_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 2;
            Console.Beep(1000, 20);

        }

        private void tres_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 3;
            Console.Beep(1000, 20);


        }

        private void cinco_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 5;
            Console.Beep(1000, 20);

        }

        private void seis_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 6;
            Console.Beep(1000, 20);

        }

        private void siete_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 7;
            Console.Beep(1000, 20);

        }

        private void ocho_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 8;
            Console.Beep(1000, 20);

        }

        private void nueve_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 9;
            Console.Beep(1000, 20);

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cero_Click(object sender, EventArgs e)
        {
            txtPanel.Text += 0;
            Console.Beep(1000, 20);

        }

        private void punto_Click(object sender, EventArgs e)
        {
            txtPanel.Text += ".";
            Console.Beep(1000, 20);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text.Substring(0, txtPanel.Text.Count() - 1); //Borrar Substring por SubString
            Console.Beep(1000, 20);

        }

        private void btnDelTodo_Click(object sender, EventArgs e)
        {
            txtPanel.Clear();
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPanel.Text);
            operador = "%";
            Console.Beep(1000, 20);
            txtPanel.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPanel.Text);
            operador = "/";
            Console.Beep(1000, 20);
            txtPanel.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPanel.Text);
            operador = "x";
            Console.Beep(1000, 20);
            txtPanel.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPanel.Text);
            operador = "-";
            Console.Beep(1000, 20);
            txtPanel.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPanel.Text);
            operador = "+";
            Console.Beep(1000, 20);
            txtPanel.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Console.Beep(1000, 20);
            if (operador == "+")
            {
                num2 = double.Parse(txtPanel.Text);
                txtPanel.Clear();
                resultado = num1 + num2;
                txtPanel.Text = resultado.ToString();
            }
            if (operador == "-")
            {
                num2 = double.Parse(txtPanel.Text);
                txtPanel.Clear();
                resultado = num1 - num2;
                txtPanel.Text = resultado.ToString();
            }
            if (operador == "x")
            {
                num2 = double.Parse(txtPanel.Text);
                txtPanel.Clear();
                resultado = num1 * num2;
                txtPanel.Text = resultado.ToString();
            }
            if (operador == "/")
            {
                num2 = double.Parse(txtPanel.Text);
                txtPanel.Clear();
                resultado = num1 / num2;
                txtPanel.Text = resultado.ToString();
            }
            if (operador == "%")
            {
                num2 = double.Parse(txtPanel.Text);
                txtPanel.Clear();
                try
                {
                    resultado = num1 % num2;
                }
                catch (Exception)
                {
                    MessageBox.Show("Solo calcular el %");
                }

                txtPanel.Text = resultado.ToString();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ConsumirAPI();
        }

        public void ConsumirAPI()
        {
            ConsumidorAPI Consumir = new ConsumidorAPI();
            Consumir.ConsumirAPI(txtInputAPI.Text);
            //txtResultadoAPI.Text = Consumir.resultadoAPI.ToString();
            txtResultadoAPI.Text = Consumir.GetResultado().ToString();
        }

        private void panelAPI_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
        int discordColor = 1;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            author = txtAuthor.Text;
           if(cbTipoTarea.SelectedIndex == 0)
           {
                webHookTipoTarea = "Tarea Pendiente";
                new DiscordMessage()
                 .SetUsername(webHookTipoTarea)
                 .AddEmbed()
                 .SetAuthor(author)
                 .SetColor(discordColor)
                 .SetTitle(txtTitlee.Text.ToString())
                 .SetDescription(txtDescripcion.Text.ToString())
                 .Build()
                 .SendMessage(webHook2URL);
           }
           if(cbTipoTarea.SelectedIndex == 1)
           {
                webHookTipoTarea = "Tarea Completada";
                new DiscordMessage()
                .SetUsername(webHookTipoTarea)
                .AddEmbed()
                .SetAuthor(author)
                .SetColor(discordColor)
                .SetTitle(txtTitlee.Text.ToString())
                .SetDescription(txtDescripcion.Text.ToString())
                .Build()
                .SendMessage(webHookURL);
           } 
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtInputAPI_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void btnEnviarWebHook_Click(object sender, EventArgs e)
        {
            if (txtWebHook.Text == "" && txtWebHook2.Text == "")
            {
                MessageBox.Show("Porfavor rellena los campos!");
            }
            if(txtWebHook.Text == "" || txtWebHook2.Text == "")
            {
                MessageBox.Show("Porfavor rellena los campos!");
            }
            else
            {
                webHookURL = txtWebHook.Text.ToString();
                webHook2URL = txtWebHook2.Text.ToString();
                panelWebHook.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User.Text = "" + Login.KeyAuthApp.user_data.username;
            expiry.Text = "" + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            ip.Text = "" + Login.KeyAuthApp.user_data.ip;
        }

        //Metodo para definir el tiempo de expiracion de tu usuario en expiry.text
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void panelInfoKeyauth_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (btnOcultar.Checked == false)
            {
                ip.Text = ip.Text = "" + Login.KeyAuthApp.user_data.ip;
            }
            if(btnOcultar.Checked == true)
            {
                ip.Text = "**********";
            }

        }
    }
}
