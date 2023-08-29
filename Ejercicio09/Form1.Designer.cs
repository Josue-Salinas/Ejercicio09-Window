namespace Ejercicio09
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
            label2 = new Label();
            text1 = new TextBox();
            text2 = new TextBox();
            text3 = new TextBox();
            button1 = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Cuál es el número mayor?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 122);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese 3 números";
            label2.Click += label2_Click;
            // 
            // text1
            // 
            text1.Location = new Point(274, 119);
            text1.Name = "text1";
            text1.Size = new Size(100, 23);
            text1.TabIndex = 2;
            // 
            // text2
            // 
            text2.Location = new Point(403, 119);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 3;
            // 
            // text3
            // 
            text3.Location = new Point(533, 119);
            text3.Name = "text3";
            text3.Size = new Size(100, 23);
            text3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(386, 236);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(185, 241);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 15);
            lblresultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresultado);
            Controls.Add(button1);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private Button button1;
        private Label lblresultado;
    }
}