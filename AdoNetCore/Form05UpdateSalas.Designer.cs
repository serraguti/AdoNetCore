namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNuevaSala = new TextBox();
            btnModificarSalas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(34, 50);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(280, 244);
            lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 64);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 2;
            label2.Text = "Nueva sala";
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(385, 95);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(236, 35);
            txtNuevaSala.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(389, 145);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(232, 72);
            btnModificarSalas.TabIndex = 4;
            btnModificarSalas.Text = "Modificar salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 340);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNuevaSala;
        private Button btnModificarSalas;
    }
}