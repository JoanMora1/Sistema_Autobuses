
namespace CapaPresentacion
{
    partial class FinViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinViaje));
            this.btnEliminarViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarViaje
            // 
            this.btnEliminarViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarViaje.BackColor = System.Drawing.Color.White;
            this.btnEliminarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarViaje.BorderRadius = 0;
            this.btnEliminarViaje.ButtonText = "Finalizar";
            this.btnEliminarViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarViaje.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarViaje.Iconimage")));
            this.btnEliminarViaje.Iconimage_right = null;
            this.btnEliminarViaje.Iconimage_right_Selected = null;
            this.btnEliminarViaje.Iconimage_Selected = null;
            this.btnEliminarViaje.IconMarginLeft = 0;
            this.btnEliminarViaje.IconMarginRight = 0;
            this.btnEliminarViaje.IconRightVisible = true;
            this.btnEliminarViaje.IconRightZoom = 0D;
            this.btnEliminarViaje.IconVisible = true;
            this.btnEliminarViaje.IconZoom = 70D;
            this.btnEliminarViaje.IsTab = false;
            this.btnEliminarViaje.Location = new System.Drawing.Point(33, 152);
            this.btnEliminarViaje.Name = "btnEliminarViaje";
            this.btnEliminarViaje.Normalcolor = System.Drawing.Color.White;
            this.btnEliminarViaje.OnHovercolor = System.Drawing.Color.Blue;
            this.btnEliminarViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarViaje.selected = false;
            this.btnEliminarViaje.Size = new System.Drawing.Size(188, 50);
            this.btnEliminarViaje.TabIndex = 26;
            this.btnEliminarViaje.Text = "Finalizar";
            this.btnEliminarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarViaje.Textcolor = System.Drawing.Color.Black;
            this.btnEliminarViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarViaje.Click += new System.EventHandler(this.btnEliminarViaje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 296);
            this.dataGridView1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(736, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEliminarViaje);
            this.panel2.Location = new System.Drawing.Point(535, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 258);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Finalizar Viaje";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FinViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinViaje";
            this.Text = "FinViaje";
            this.Load += new System.EventHandler(this.FinViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarViaje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}