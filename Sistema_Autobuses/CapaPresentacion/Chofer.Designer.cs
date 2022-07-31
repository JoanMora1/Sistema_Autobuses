
namespace CapaPresentacion
{
    partial class Chofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chofer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEditarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(56, 65);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(268, 29);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(525, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(525, 189);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 26);
            this.txtApellido.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(525, 324);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(253, 26);
            this.txtCedula.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnEditarChofer
            // 
            this.btnEditarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditarChofer.BackColor = System.Drawing.Color.White;
            this.btnEditarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarChofer.BorderRadius = 0;
            this.btnEditarChofer.ButtonText = "Editar";
            this.btnEditarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditarChofer.Iconimage")));
            this.btnEditarChofer.Iconimage_right = null;
            this.btnEditarChofer.Iconimage_right_Selected = null;
            this.btnEditarChofer.Iconimage_Selected = null;
            this.btnEditarChofer.IconMarginLeft = 0;
            this.btnEditarChofer.IconMarginRight = 0;
            this.btnEditarChofer.IconRightVisible = true;
            this.btnEditarChofer.IconRightZoom = 0D;
            this.btnEditarChofer.IconVisible = true;
            this.btnEditarChofer.IconZoom = 70D;
            this.btnEditarChofer.IsTab = false;
            this.btnEditarChofer.Location = new System.Drawing.Point(330, 65);
            this.btnEditarChofer.Name = "btnEditarChofer";
            this.btnEditarChofer.Normalcolor = System.Drawing.Color.White;
            this.btnEditarChofer.OnHovercolor = System.Drawing.Color.Blue;
            this.btnEditarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarChofer.selected = false;
            this.btnEditarChofer.Size = new System.Drawing.Size(82, 31);
            this.btnEditarChofer.TabIndex = 12;
            this.btnEditarChofer.Text = "Editar";
            this.btnEditarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarChofer.Textcolor = System.Drawing.Color.Black;
            this.btnEditarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarChofer.Click += new System.EventHandler(this.btnEditarChofer_Click);
            // 
            // btnEliminarChofer
            // 
            this.btnEliminarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarChofer.BackColor = System.Drawing.Color.White;
            this.btnEliminarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarChofer.BorderRadius = 0;
            this.btnEliminarChofer.ButtonText = "Eliminar";
            this.btnEliminarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarChofer.Iconimage")));
            this.btnEliminarChofer.Iconimage_right = null;
            this.btnEliminarChofer.Iconimage_right_Selected = null;
            this.btnEliminarChofer.Iconimage_Selected = null;
            this.btnEliminarChofer.IconMarginLeft = 0;
            this.btnEliminarChofer.IconMarginRight = 0;
            this.btnEliminarChofer.IconRightVisible = true;
            this.btnEliminarChofer.IconRightZoom = 0D;
            this.btnEliminarChofer.IconVisible = true;
            this.btnEliminarChofer.IconZoom = 70D;
            this.btnEliminarChofer.IsTab = false;
            this.btnEliminarChofer.Location = new System.Drawing.Point(421, 67);
            this.btnEliminarChofer.Name = "btnEliminarChofer";
            this.btnEliminarChofer.Normalcolor = System.Drawing.Color.White;
            this.btnEliminarChofer.OnHovercolor = System.Drawing.Color.Blue;
            this.btnEliminarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarChofer.selected = false;
            this.btnEliminarChofer.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarChofer.TabIndex = 13;
            this.btnEliminarChofer.Text = "Eliminar";
            this.btnEliminarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarChofer.Textcolor = System.Drawing.Color.Black;
            this.btnEliminarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarChofer.Click += new System.EventHandler(this.btnEliminarChofer_Click);
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarChofer.BackColor = System.Drawing.Color.White;
            this.btnAgregarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarChofer.BorderRadius = 0;
            this.btnAgregarChofer.ButtonText = "Agregar";
            this.btnAgregarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarChofer.Iconimage")));
            this.btnAgregarChofer.Iconimage_right = null;
            this.btnAgregarChofer.Iconimage_right_Selected = null;
            this.btnAgregarChofer.Iconimage_Selected = null;
            this.btnAgregarChofer.IconMarginLeft = 0;
            this.btnAgregarChofer.IconMarginRight = 0;
            this.btnAgregarChofer.IconRightVisible = true;
            this.btnAgregarChofer.IconRightZoom = 0D;
            this.btnAgregarChofer.IconVisible = true;
            this.btnAgregarChofer.IconZoom = 70D;
            this.btnAgregarChofer.IsTab = false;
            this.btnAgregarChofer.Location = new System.Drawing.Point(525, 369);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Normalcolor = System.Drawing.Color.White;
            this.btnAgregarChofer.OnHovercolor = System.Drawing.Color.Blue;
            this.btnAgregarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarChofer.selected = false;
            this.btnAgregarChofer.Size = new System.Drawing.Size(253, 29);
            this.btnAgregarChofer.TabIndex = 14;
            this.btnAgregarChofer.Text = "Agregar";
            this.btnAgregarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarChofer.Textcolor = System.Drawing.Color.Black;
            this.btnAgregarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(745, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 0;
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
            // Chofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarChofer);
            this.Controls.Add(this.btnEliminarChofer);
            this.Controls.Add(this.btnEditarChofer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chofer";
            this.Text = "Chofer";
            this.Load += new System.EventHandler(this.Chofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarChofer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}