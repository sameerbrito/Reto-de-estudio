
namespace Mi_Primer_Reto_de_Estudio
{
    partial class VenEliminar
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Mercancía = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NoEliminable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Comentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(212, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Buscar mercancia para eliminar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mi_Primer_Reto_de_Estudio.Properties.Resources.almacen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 10;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(251, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 33);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar Mercancía";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(621, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // Id_Mercancía
            // 
            this.Id_Mercancía.Location = new System.Drawing.Point(648, 12);
            this.Id_Mercancía.Name = "Id_Mercancía";
            this.Id_Mercancía.Size = new System.Drawing.Size(19, 20);
            this.Id_Mercancía.TabIndex = 47;
            this.Id_Mercancía.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.NoEliminable);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Comentario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Existencia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Descripcion);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Location = new System.Drawing.Point(13, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 157);
            this.panel2.TabIndex = 50;
            // 
            // NoEliminable
            // 
            this.NoEliminable.AutoSize = true;
            this.NoEliminable.Enabled = false;
            this.NoEliminable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoEliminable.ForeColor = System.Drawing.Color.White;
            this.NoEliminable.Location = new System.Drawing.Point(290, 105);
            this.NoEliminable.Name = "NoEliminable";
            this.NoEliminable.Size = new System.Drawing.Size(107, 20);
            this.NoEliminable.TabIndex = 44;
            this.NoEliminable.Text = "No Eliminable";
            this.NoEliminable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Comentario";
            // 
            // Comentario
            // 
            this.Comentario.Enabled = false;
            this.Comentario.Location = new System.Drawing.Point(415, 26);
            this.Comentario.Multiline = true;
            this.Comentario.Name = "Comentario";
            this.Comentario.Size = new System.Drawing.Size(239, 117);
            this.Comentario.TabIndex = 40;
            this.Comentario.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Descripcion";
            // 
            // Existencia
            // 
            this.Existencia.Enabled = false;
            this.Existencia.Location = new System.Drawing.Point(101, 104);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(62, 20);
            this.Existencia.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Status";
            // 
            // Descripcion
            // 
            this.Descripcion.Enabled = false;
            this.Descripcion.Location = new System.Drawing.Point(101, 48);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(296, 20);
            this.Descripcion.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Existencia";
            // 
            // Status
            // 
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(224, 104);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(60, 20);
            this.Status.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 217);
            this.panel1.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VenEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(686, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Id_Mercancía);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenEliminar";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.VenEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_Mercancía;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox NoEliminable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Comentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}