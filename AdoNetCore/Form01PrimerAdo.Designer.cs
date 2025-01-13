namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            label2 = new Label();
            lstColumnas = new ListBox();
            label3 = new Label();
            lstTiposDato = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(24, 25);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(159, 48);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(28, 85);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(155, 51);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(29, 151);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(154, 49);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 14);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(215, 49);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(203, 274);
            lstApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(448, 49);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(199, 274);
            lstColumnas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(668, 15);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 7;
            label3.Text = "Tipos Dato";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(668, 49);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(191, 274);
            lstTiposDato.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(32, 344);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 401);
            Controls.Add(lblMensaje);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label label1;
        private ListBox lstApellidos;
        private Label label2;
        private ListBox lstColumnas;
        private Label label3;
        private ListBox lstTiposDato;
        private Label lblMensaje;
    }
}