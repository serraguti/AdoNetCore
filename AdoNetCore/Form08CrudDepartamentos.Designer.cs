﻿namespace AdoNetCore
{
    partial class Form08CrudDepartamentos
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
            txtIdDepartamento = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Items.AddRange(new object[] { "10 - CONTABILIDAD - ELCHE", "20 - INVESTIGACION - MADRID" });
            lstDepartamentos.Location = new Point(26, 50);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(503, 394);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 24);
            label2.Name = "label2";
            label2.Size = new Size(31, 30);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(569, 57);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(88, 35);
            txtIdDepartamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 107);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(573, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 186);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(579, 222);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(235, 35);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(578, 273);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(236, 45);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(579, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(235, 47);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(580, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(234, 45);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 451);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtIdDepartamento;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}