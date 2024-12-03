namespace ejerciciotelegrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTelegrama = new TextBox();
            chkUrgente = new CheckBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 87);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "texto";
            label1.Click += label1_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(53, 105);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(280, 23);
            txtTelegrama.TabIndex = 1;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(59, 198);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(72, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 226);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "coste";
            label2.Click += label2_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(130, 229);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(333, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcularPrecio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(chkUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelegrama;
        private CheckBox chkUrgente;
        private Label label2;
        private TextBox txtPrecio;
        private Button button1;
    }
}
