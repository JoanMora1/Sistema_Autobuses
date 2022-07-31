
namespace CapaPresentacion
{
    partial class CrearViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearViaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ComboChofer = new System.Windows.Forms.ComboBox();
            this.ComboAutobus = new System.Windows.Forms.ComboBox();
            this.ComboRuta = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(736, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Autobus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chofer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 296);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarViaje.BackColor = System.Drawing.Color.White;
            this.btnAgregarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarViaje.BorderRadius = 0;
            this.btnAgregarViaje.ButtonText = "Agregar";
            this.btnAgregarViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarViaje.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarViaje.Iconimage")));
            this.btnAgregarViaje.Iconimage_right = null;
            this.btnAgregarViaje.Iconimage_right_Selected = null;
            this.btnAgregarViaje.Iconimage_Selected = null;
            this.btnAgregarViaje.IconMarginLeft = 0;
            this.btnAgregarViaje.IconMarginRight = 0;
            this.btnAgregarViaje.IconRightVisible = true;
            this.btnAgregarViaje.IconRightZoom = 0D;
            this.btnAgregarViaje.IconVisible = true;
            this.btnAgregarViaje.IconZoom = 70D;
            this.btnAgregarViaje.IsTab = false;
            this.btnAgregarViaje.Location = new System.Drawing.Point(525, 382);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Normalcolor = System.Drawing.Color.White;
            this.btnAgregarViaje.OnHovercolor = System.Drawing.Color.Blue;
            this.btnAgregarViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarViaje.selected = false;
            this.btnAgregarViaje.Size = new System.Drawing.Size(253, 29);
            this.btnAgregarViaje.TabIndex = 18;
            this.btnAgregarViaje.Text = "Agregar";
            this.btnAgregarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarViaje.Textcolor = System.Drawing.Color.Black;
            this.btnAgregarViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // ComboChofer
            // 
            this.ComboChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboChofer.FormattingEnabled = true;
            this.ComboChofer.Location = new System.Drawing.Point(525, 138);
            this.ComboChofer.Name = "ComboChofer";
            this.ComboChofer.Size = new System.Drawing.Size(253, 28);
            this.ComboChofer.TabIndex = 19;
            // 
            // ComboAutobus
            // 
            this.ComboAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAutobus.FormattingEnabled = true;
            this.ComboAutobus.Location = new System.Drawing.Point(525, 202);
            this.ComboAutobus.Name = "ComboAutobus";
            this.ComboAutobus.Size = new System.Drawing.Size(253, 28);
            this.ComboAutobus.TabIndex = 20;
            // 
            // ComboRuta
            // 
            this.ComboRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboRuta.FormattingEnabled = true;
            this.ComboRuta.Location = new System.Drawing.Point(525, 269);
            this.ComboRuta.Name = "ComboRuta";
            this.ComboRuta.Size = new System.Drawing.Size(253, 28);
            this.ComboRuta.TabIndex = 21;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // CrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboRuta);
            this.Controls.Add(this.ComboAutobus);
            this.Controls.Add(this.ComboChofer);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearViaje";
            this.Text = "CrearViaje";
            this.Load += new System.EventHandler(this.CrearViaje_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarViaje;
        private System.Windows.Forms.ComboBox ComboChofer;
        private System.Windows.Forms.ComboBox ComboAutobus;
        private System.Windows.Forms.ComboBox ComboRuta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}