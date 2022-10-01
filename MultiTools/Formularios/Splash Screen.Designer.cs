
namespace MultiTools.Formularios
{
    partial class Splash_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Fondo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.panelWith = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.icono = new System.Windows.Forms.PictureBox();
            this.Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.Fondo;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Fondo
            // 
            this.Fondo.Controls.Add(this.icono);
            this.Fondo.Controls.Add(this.panelLoading);
            this.Fondo.Controls.Add(this.panelWith);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.FillColor = System.Drawing.Color.Fuchsia;
            this.Fondo.FillColor2 = System.Drawing.Color.Navy;
            this.Fondo.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Fondo.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(698, 362);
            this.Fondo.TabIndex = 0;
            this.Fondo.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.Fuchsia;
            this.panelLoading.Location = new System.Drawing.Point(0, 328);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(54, 34);
            this.panelLoading.TabIndex = 1;
            // 
            // panelWith
            // 
            this.panelWith.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWith.Location = new System.Drawing.Point(0, 328);
            this.panelWith.Name = "panelWith";
            this.panelWith.Size = new System.Drawing.Size(698, 34);
            this.panelWith.TabIndex = 0;
            this.panelWith.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWith_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.icono;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // icono
            // 
            this.icono.BackColor = System.Drawing.Color.Transparent;
            this.icono.Image = global::MultiTools.Properties.Resources.icons8_evernote_96px;
            this.icono.Location = new System.Drawing.Point(206, 61);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(287, 161);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 2;
            this.icono.TabStop = false;
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.Fondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Fondo;
        private Guna.UI2.WinForms.Guna2Panel panelLoading;
        private Guna.UI2.WinForms.Guna2Panel panelWith;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox icono;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}