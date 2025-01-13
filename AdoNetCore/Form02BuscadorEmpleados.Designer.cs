namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarEmpleados = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(27, 50);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(232, 35);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(29, 94);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(230, 60);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 169);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(29, 206);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(353, 244);
            lstEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 16);
            label3.Name = "label3";
            label3.Size = new Size(173, 30);
            label3.TabIndex = 5;
            label3.Text = "Introduzca Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(308, 47);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(225, 35);
            txtOficio.TabIndex = 6;
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(308, 94);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(225, 60);
            btnBuscarOficio.TabIndex = 7;
            btnBuscarOficio.Text = "Buscar por Oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += btnBuscarOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 467);
            Controls.Add(btnBuscarOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleados;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarOficio;
    }
}