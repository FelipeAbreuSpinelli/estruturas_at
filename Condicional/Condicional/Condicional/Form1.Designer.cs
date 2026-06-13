namespace Condicional
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
            Paquetatxt = new TextBox();
            Senhatxt = new TextBox();
            label3 = new Label();
            BtnEntrar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 235);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 0;
            label1.Text = "Jogador camisa 20 da Seleção Brasileira:";
            label1.Click += label1_Click;
            // 
            // Paquetatxt
            // 
            Paquetatxt.Location = new Point(292, 232);
            Paquetatxt.Name = "Paquetatxt";
            Paquetatxt.Size = new Size(177, 23);
            Paquetatxt.TabIndex = 2;
            // 
            // Senhatxt
            // 
            Senhatxt.Location = new Point(292, 266);
            Senhatxt.Name = "Senhatxt";
            Senhatxt.Size = new Size(177, 23);
            Senhatxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(225, 44);
            label3.Name = "label3";
            label3.Size = new Size(365, 37);
            label3.TabIndex = 4;
            label3.Text = "ESTRUTURAS CONDICIONAIS";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Font = new Font("Segoe UI", 30F);
            BtnEntrar.Location = new Point(213, 405);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(369, 121);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 274);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite a senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(BtnEntrar);
            Controls.Add(label3);
            Controls.Add(Senhatxt);
            Controls.Add(Paquetatxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Estruturas condicionais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Paquetatxt;
        private TextBox Senhatxt;
        private Label label3;
        private Button BtnEntrar;
        private Label label2;
    }
}
