namespace AdoNetCore
{
    partial class Form07DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(25, 48);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(227, 214);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 15);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(297, 47);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(258, 364);
            lstEmpleados.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(579, 100);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 50);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 446);
            Controls.Add(btnEliminar);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnEliminar;
    }
}