namespace AdoNetCore
{
    partial class Form03EliminarEnfermos
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
            txtInscripcion = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(26, 55);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(193, 35);
            txtInscripcion.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(191, 52);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar enfermo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 13);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(279, 44);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(436, 364);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 443);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInscripcion;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstEnfermos;
    }
}