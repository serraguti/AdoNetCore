namespace AdoNetCore
{
    partial class Form2
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
            lstEmpleados = new ListBox();
            label5 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            txtMediaSalarial = new TextBox();
            label3 = new Label();
            txtSumaSalarial = new TextBox();
            label2 = new Label();
            cmbDepartamentos = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Items.AddRange(new object[] { "Curro F. - Enfermero - 250000", "Macias H. - Interino - 312000", "Llorente E. - Cardiología - 360000", "Tormo C. - Psicología - 410000" });
            lstEmpleados.Location = new Point(321, 61);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(411, 364);
            lstEmpleados.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 24);
            label5.Name = "label5";
            label5.Size = new Size(196, 30);
            label5.TabIndex = 20;
            label5.Text = "Empleados Hospital";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(48, 390);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(196, 35);
            txtPersonas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 361);
            label4.Name = "label4";
            label4.Size = new Size(95, 30);
            label4.TabIndex = 18;
            label4.Text = "Personas";
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(44, 310);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(200, 35);
            txtMediaSalarial.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 275);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 16;
            label3.Text = "Media salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(42, 221);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(202, 35);
            txtSumaSalarial.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 186);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 14;
            label2.Text = "Suma salarial";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Items.AddRange(new object[] { "La Paz", "General", "Ruber" });
            cmbDepartamentos.Location = new Point(39, 60);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(228, 38);
            cmbDepartamentos.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 485);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label3);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label5;
        private TextBox txtPersonas;
        private Label label4;
        private TextBox txtMediaSalarial;
        private Label label3;
        private TextBox txtSumaSalarial;
        private Label label2;
        private ComboBox cmbDepartamentos;
        private Label label1;
    }
}