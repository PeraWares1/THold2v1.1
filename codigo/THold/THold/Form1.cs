using System;
using System.Windows.Forms;
using System.Media;

namespace THold
{
    public partial class Form1 : Form
    {

        int contUno = 0;
        int min, seg, mil;
        int img = 1;
        SoundPlayer sonido1 = new SoundPlayer(THold.Properties.Resources.chimes);
        static int sd;
        

      

        public Form1()
        {
            InitializeComponent();
        }


        private void iniciar(object sender, EventArgs e)
        {
            if (img == 1)
            {
                img = 2;
            }
            else if(img==2)
            {
                img = 1;

            }

            switch (img)

            {
                case 2:
                    {
                        btniniciar.BackgroundImage = THold.Properties.Resources.Stop;

                        tempo.Start();
                        btniniciar.BackgroundImage = THold.Properties.Resources.Stop;
                        btnreiniciar.Enabled = true;
                        toolTip1.SetToolTip(btniniciar,"Detener conteo");

                        

                        break;
                    }
                case 1:
                    {
                        btniniciar.BackgroundImage = THold.Properties.Resources.Play;
                        tempo.Dispose();
                        btniniciar.BackgroundImage = THold.Properties.Resources.Play;
                        btnreiniciar.Enabled = false;
                        contUno = 0;
                        lbltiempo.Text = contUno.ToString() + "0:00:00";
                        toolTip1.SetToolTip(btniniciar,"Iniciar conteo");
                        sonido1.Stop();
                        notifyIcon1.Visible = false;
                        lbltiempo.ForeColor = System.Drawing.Color.MediumBlue;
                        tempo2.Enabled = false;
                        lbltiempo.Visible = true;

                        break;
                    }
            }

        }

        private void reiniciar(object sender, EventArgs e)
        {
            tempo.Stop();
            contUno = 0;
            lbltiempo.Text = contUno.ToString() + "0:00:00";
            
            tempo.Start();
            
            sonido1.Stop();
            notifyIcon1.Visible = false;
            lbltiempo.ForeColor = System.Drawing.Color.MediumBlue;
            tempo2.Enabled = false;
            lbltiempo.Visible = true;

        }

        private void temp(object sender, EventArgs e)
        {
            contUno++;
            min = (contUno / 3600);
            seg = (contUno % 3600) / 60;
            mil = (contUno % 3600) % 60;
            lbltiempo.Text = string.Format("{0:#,0#}:{1:#,0#}:{2:#,0#}", min, seg, mil);

          


            if(lbltiempo.Text=="00:25:00")
            {
                notifyIcon1.Text = "Tiempo de Hold";
                notifyIcon1.BalloonTipTitle = "DEBES VOLVER AL CLIENTE";
                notifyIcon1.BalloonTipText = "Tiempo de Hold 30 segs";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);
                sonido1.PlayLooping();

                lbltiempo.ForeColor = System.Drawing.Color.Yellow;
                
            }
            else if(lbltiempo.Text=="00:26:25")
            {
                sonido1.Stop();

            }

            else if(lbltiempo.Text=="00:40:00")
            {
                sonido1.PlayLooping();
                notifyIcon1.Text = "Tiempo de Hold";
                notifyIcon1.BalloonTipTitle = "DEBES VOLVER AL CLIENTE, ¡DE PRISA!";
                notifyIcon1.BalloonTipText = "Tiempo de Hold 45 segs";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;

                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);

                lbltiempo.ForeColor = System.Drawing.Color.Red;

                tempo2.Enabled = true;




            }

            else if(lbltiempo.Text=="00:41:25")
            {
                sonido1.Stop();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            toolTip1.SetToolTip(btniniciar,"Iniciar conteo");
        }

        private void tempo2_Tick(object sender, EventArgs e)
        {
            sd++;

            if (sd == 1)
            {
                lbltiempo.Visible = false;
            }
            else if (sd == 2)
            {
                lbltiempo.Visible = true;
            }
            else 
            {
                sd = 0;
            }
        }
    }
}
