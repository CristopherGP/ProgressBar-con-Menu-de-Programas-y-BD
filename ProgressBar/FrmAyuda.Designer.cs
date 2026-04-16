namespace ProgressBar
{
    partial class FrmAyuda
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
            label2 = new Label();
            btnRegresar = new Button();
            rtbManual = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 21);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(289, 138);
            label2.TabIndex = 1;
            label2.Text = "EQUIPO:\r\n- Guerrero Puente Cristopher Husser\r\n- Lopez Valenzuela Ana Paulina\r\n- Grimaldo Barbosa Omar\r\n- Felix Garza Diego Francisco\r\n- Torres Garcia Johana Elizabeth";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(279, 433);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Volver";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // rtbManual
            // 
            rtbManual.BackColor = Color.White;
            rtbManual.BorderStyle = BorderStyle.None;
            rtbManual.Dock = DockStyle.Bottom;
            rtbManual.Location = new Point(0, 209);
            rtbManual.Name = "rtbManual";
            rtbManual.ReadOnly = true;
            rtbManual.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbManual.Size = new Size(796, 253);
            rtbManual.TabIndex = 5;
            rtbManual.Text = "";
            rtbManual.TextChanged += rtbManual_TextChanged;
            // 
            // FrmAyuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 462);
            Controls.Add(btnRegresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbManual);
            Name = "FrmAyuda";
            Text = "FrmAyuda";
            Load += FrmAyuda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRegresar;
        private RichTextBox rtbManual;
    }
}