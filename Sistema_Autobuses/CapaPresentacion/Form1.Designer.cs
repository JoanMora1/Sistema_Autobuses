
namespace CapaPresentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChofer
            // 
            this.btnChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChofer.BackColor = System.Drawing.Color.White;
            this.btnChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChofer.BorderRadius = 0;
            this.btnChofer.ButtonText = "Chofer";
            this.btnChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChofer.Iconimage")));
            this.btnChofer.Iconimage_right = null;
            this.btnChofer.Iconimage_right_Selected = null;
            this.btnChofer.Iconimage_Selected = null;
            this.btnChofer.IconMarginLeft = 0;
            this.btnChofer.IconMarginRight = 0;
            this.btnChofer.IconRightVisible = true;
            this.btnChofer.IconRightZoom = 0D;
            this.btnChofer.IconVisible = true;
            this.btnChofer.IconZoom = 90D;
            this.btnChofer.IsTab = false;
            this.btnChofer.Location = new System.Drawing.Point(16, 133);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Normalcolor = System.Drawing.Color.White;
            this.btnChofer.OnHovercolor = System.Drawing.Color.Blue;
            this.btnChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChofer.selected = false;
            this.btnChofer.Size = new System.Drawing.Size(169, 44);
            this.btnChofer.TabIndex = 0;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChofer.Textcolor = System.Drawing.Color.Black;
            this.btnChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema De Autobuses";
            // 
            // btnAutobus
            // 
            this.btnAutobus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAutobus.BackColor = System.Drawing.Color.White;
            this.btnAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobus.BorderRadius = 0;
            this.btnAutobus.ButtonText = "Autobus";
            this.btnAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobus.DisabledColor = System.Drawing.Color.Gray;
            this.btnAutobus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAutobus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAutobus.Iconimage")));
            this.btnAutobus.Iconimage_right = null;
            this.btnAutobus.Iconimage_right_Selected = null;
            this.btnAutobus.Iconimage_Selected = null;
            this.btnAutobus.IconMarginLeft = 0;
            this.btnAutobus.IconMarginRight = 0;
            this.btnAutobus.IconRightVisible = true;
            this.btnAutobus.IconRightZoom = 0D;
            this.btnAutobus.IconVisible = true;
            this.btnAutobus.IconZoom = 90D;
            this.btnAutobus.IsTab = false;
            this.btnAutobus.Location = new System.Drawing.Point(16, 183);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Normalcolor = System.Drawing.Color.White;
            this.btnAutobus.OnHovercolor = System.Drawing.Color.Blue;
            this.btnAutobus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAutobus.selected = false;
            this.btnAutobus.Size = new System.Drawing.Size(169, 44);
            this.btnAutobus.TabIndex = 2;
            this.btnAutobus.Text = "Autobus";
            this.btnAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobus.Textcolor = System.Drawing.Color.Black;
            this.btnAutobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRuta.BackColor = System.Drawing.Color.White;
            this.btnRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuta.BorderRadius = 0;
            this.btnRuta.ButtonText = "Ruta";
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btnRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRuta.Iconimage")));
            this.btnRuta.Iconimage_right = null;
            this.btnRuta.Iconimage_right_Selected = null;
            this.btnRuta.Iconimage_Selected = null;
            this.btnRuta.IconMarginLeft = 0;
            this.btnRuta.IconMarginRight = 0;
            this.btnRuta.IconRightVisible = true;
            this.btnRuta.IconRightZoom = 0D;
            this.btnRuta.IconVisible = true;
            this.btnRuta.IconZoom = 90D;
            this.btnRuta.IsTab = false;
            this.btnRuta.Location = new System.Drawing.Point(16, 233);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Normalcolor = System.Drawing.Color.White;
            this.btnRuta.OnHovercolor = System.Drawing.Color.Blue;
            this.btnRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRuta.selected = false;
            this.btnRuta.Size = new System.Drawing.Size(169, 44);
            this.btnRuta.TabIndex = 3;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuta.Textcolor = System.Drawing.Color.Black;
            this.btnRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insertar...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Viajes";
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIniciarViaje.BackColor = System.Drawing.Color.White;
            this.btnIniciarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarViaje.BorderRadius = 0;
            this.btnIniciarViaje.ButtonText = "Iniciar";
            this.btnIniciarViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarViaje.DisabledColor = System.Drawing.Color.Gray;
            this.btnIniciarViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIniciarViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIniciarViaje.Iconimage")));
            this.btnIniciarViaje.Iconimage_right = null;
            this.btnIniciarViaje.Iconimage_right_Selected = null;
            this.btnIniciarViaje.Iconimage_Selected = null;
            this.btnIniciarViaje.IconMarginLeft = 0;
            this.btnIniciarViaje.IconMarginRight = 0;
            this.btnIniciarViaje.IconRightVisible = true;
            this.btnIniciarViaje.IconRightZoom = 0D;
            this.btnIniciarViaje.IconVisible = true;
            this.btnIniciarViaje.IconZoom = 90D;
            this.btnIniciarViaje.IsTab = false;
            this.btnIniciarViaje.Location = new System.Drawing.Point(261, 133);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Normalcolor = System.Drawing.Color.White;
            this.btnIniciarViaje.OnHovercolor = System.Drawing.Color.Blue;
            this.btnIniciarViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIniciarViaje.selected = false;
            this.btnIniciarViaje.Size = new System.Drawing.Size(169, 44);
            this.btnIniciarViaje.TabIndex = 6;
            this.btnIniciarViaje.Text = "Iniciar";
            this.btnIniciarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarViaje.Textcolor = System.Drawing.Color.Black;
            this.btnIniciarViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.BorderRadius = 0;
            this.btnFinalizar.ButtonText = "Finalizar";
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinalizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinalizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Iconimage")));
            this.btnFinalizar.Iconimage_right = null;
            this.btnFinalizar.Iconimage_right_Selected = null;
            this.btnFinalizar.Iconimage_Selected = null;
            this.btnFinalizar.IconMarginLeft = 0;
            this.btnFinalizar.IconMarginRight = 0;
            this.btnFinalizar.IconRightVisible = true;
            this.btnFinalizar.IconRightZoom = 0D;
            this.btnFinalizar.IconVisible = true;
            this.btnFinalizar.IconZoom = 90D;
            this.btnFinalizar.IsTab = false;
            this.btnFinalizar.Location = new System.Drawing.Point(261, 183);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Normalcolor = System.Drawing.Color.White;
            this.btnFinalizar.OnHovercolor = System.Drawing.Color.Blue;
            this.btnFinalizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFinalizar.selected = false;
            this.btnFinalizar.Size = new System.Drawing.Size(169, 44);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Textcolor = System.Drawing.Color.Black;
            this.btnFinalizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(436, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 331);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciarViaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnAutobus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChofer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnChofer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAutobus;
        private Bunifu.Framework.UI.BunifuFlatButton btnRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnIniciarViaje;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

