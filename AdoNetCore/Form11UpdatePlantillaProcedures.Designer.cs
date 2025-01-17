namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            label1 = new Label();
            cmbHospitales = new ComboBox();
            btnModificarSalarios = new Button();
            label2 = new Label();
            txtIncremento = new TextBox();
            label3 = new Label();
            lstPlantilla = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(30, 52);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(227, 38);
            cmbHospitales.TabIndex = 1;
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(185, 109);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(219, 45);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "Modificar salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 20);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(299, 55);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(264, 35);
            txtIncremento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 176);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(34, 209);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(560, 244);
            lstPlantilla.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(455, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 465);
            Controls.Add(button1);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(btnModificarSalarios);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Button btnModificarSalarios;
        private Label label2;
        private TextBox txtIncremento;
        private Label label3;
        private ListBox lstPlantilla;
        private Button button1;
    }
}