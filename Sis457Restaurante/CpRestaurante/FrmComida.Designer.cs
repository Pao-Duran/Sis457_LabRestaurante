namespace CpRestaurante
{
    partial class FrmComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComida));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imglComidas = new System.Windows.Forms.ImageList(this.components);
            this.btnCambio = new System.Windows.Forms.Button();
            this.lblComida = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comidas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comidas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(389, 99);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pique a lo macho",
            "Silpancho",
            "Lomo Salteado",
            "Fricase",
            "Sopa de Pollo",
            "Chorizo Chuquisaqueño",
            "Sopa de Mani",
            "Picana"});
            this.comboBox1.Location = new System.Drawing.Point(388, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // imglComidas
            // 
            this.imglComidas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglComidas.ImageStream")));
            this.imglComidas.TransparentColor = System.Drawing.Color.Transparent;
            this.imglComidas.Images.SetKeyName(0, "CaldoDePollo.jpg");
            this.imglComidas.Images.SetKeyName(1, "chorizos-chuquisaquenos-de-bolivia.jpg");
            this.imglComidas.Images.SetKeyName(2, "comida-tipica-bolivia.jpg");
            this.imglComidas.Images.SetKeyName(3, "comida-tradicional-bolivia-receta.jpg");
            this.imglComidas.Images.SetKeyName(4, "fricase-boliviano.jpg");
            this.imglComidas.Images.SetKeyName(5, "lomo-montado-a-la-chorrillana.jpg");
            this.imglComidas.Images.SetKeyName(6, "picana-navidena-2974.jpg");
            this.imglComidas.Images.SetKeyName(7, "sopa-mani-bolivia.jpg");
            this.imglComidas.Images.SetKeyName(8, "Sopas-tipicas-de-bolivia-480x270.jpg");
            // 
            // btnCambio
            // 
            this.btnCambio.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCambio.Location = new System.Drawing.Point(139, 267);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 23);
            this.btnCambio.TabIndex = 11;
            this.btnCambio.Text = "Siguiente";
            this.btnCambio.UseVisualStyleBackColor = false;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // lblComida
            // 
            this.lblComida.ImageIndex = 0;
            this.lblComida.ImageList = this.imglComidas;
            this.lblComida.Location = new System.Drawing.Point(83, 55);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(200, 200);
            this.lblComida.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Image = global::CpRestaurante.Properties.Resources.cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(434, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CpRestaurante.Properties.Resources._new;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(303, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::CpRestaurante.Properties.Resources.icons8_restaurante_32__1_1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(435, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 38);
            this.button3.TabIndex = 83;
            this.button3.Text = "Inicio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 337);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmComida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComida";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imglComidas;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Button button3;
    }
}