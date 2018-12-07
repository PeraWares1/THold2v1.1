namespace THold
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltiempo = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.tempo2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbltiempo.Location = new System.Drawing.Point(-9, -7);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(254, 50);
            this.lbltiempo.TabIndex = 0;
            this.lbltiempo.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.lbltiempo, "Conteo");
            // 
            // tempo
            // 
            this.tempo.Interval = 10;
            this.tempo.Tick += new System.EventHandler(this.temp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbltiempo);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 38);
            this.panel1.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.BackgroundImage = global::THold.Properties.Resources.Renew;
            this.btnreiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreiniciar.Enabled = false;
            this.btnreiniciar.Location = new System.Drawing.Point(139, 54);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(42, 39);
            this.btnreiniciar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnreiniciar, "Resetear conteo");
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.reiniciar);
            // 
            // btniniciar
            // 
            this.btniniciar.BackgroundImage = global::THold.Properties.Resources.Play;
            this.btniniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btniniciar.Location = new System.Drawing.Point(51, 54);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(42, 39);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.iniciar);
            // 
            // tempo2
            // 
            this.tempo2.Tick += new System.EventHandler(this.tempo2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(232, 97);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.btniniciar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(248, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(248, 136);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tempo de Hold";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer tempo2;
    }
}

