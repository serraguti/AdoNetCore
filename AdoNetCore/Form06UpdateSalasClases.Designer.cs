namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            btnModificarSalas = new Button();
            txtNuevaSala = new TextBox();
            label2 = new Label();
            lstSalas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.BackColor = Color.FromArgb(255, 255, 192);
            btnModificarSalas.Location = new Point(358, 104);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(232, 72);
            btnModificarSalas.TabIndex = 9;
            btnModificarSalas.Text = "Modificar salas";
            btnModificarSalas.UseVisualStyleBackColor = false;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(354, 54);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(236, 35);
            txtNuevaSala.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 23);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 7;
            label2.Text = "Nueva sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(39, 50);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(280, 244);
            lstSalas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(656, 325);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSalas;
        private TextBox txtNuevaSala;
        private Label label2;
        private ListBox lstSalas;
        private Label label1;
    }
}