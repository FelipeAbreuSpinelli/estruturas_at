namespace Repeticao
{
    partial class Form1
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
            label3 = new Label();
            label4 = new Label();
            btnWhile = new Button();
            BtnDoWhile = new Button();
            BtnFor = new Button();
            BtnForEach = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(307, 123);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "While";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(596, 123);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "DoWhile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(596, 244);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "ForEach";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(307, 244);
            label4.Name = "label4";
            label4.Size = new Size(41, 28);
            label4.TabIndex = 3;
            label4.Text = "For";
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(169, 116);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(119, 50);
            btnWhile.TabIndex = 4;
            btnWhile.Text = "Cálculo Porcentagem";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // BtnDoWhile
            // 
            BtnDoWhile.Location = new Point(451, 116);
            BtnDoWhile.Name = "BtnDoWhile";
            BtnDoWhile.Size = new Size(119, 50);
            BtnDoWhile.TabIndex = 5;
            BtnDoWhile.Text = "Cálculo Fatoriais";
            BtnDoWhile.UseVisualStyleBackColor = true;
            BtnDoWhile.Click += BtnDoWhile_Click;
            // 
            // BtnFor
            // 
            BtnFor.Location = new Point(169, 237);
            BtnFor.Name = "BtnFor";
            BtnFor.Size = new Size(119, 50);
            BtnFor.TabIndex = 6;
            BtnFor.Text = "Calcular números ao quadrado";
            BtnFor.UseVisualStyleBackColor = true;
            BtnFor.Click += BtnFor_Click;
            // 
            // BtnForEach
            // 
            BtnForEach.Location = new Point(451, 237);
            BtnForEach.Name = "BtnForEach";
            BtnForEach.Size = new Size(119, 50);
            BtnForEach.TabIndex = 7;
            BtnForEach.Text = "Gerar mensagens";
            BtnForEach.UseVisualStyleBackColor = true;
            BtnForEach.Click += BtnForEach_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(250, 37);
            label5.Name = "label5";
            label5.Size = new Size(354, 37);
            label5.TabIndex = 8;
            label5.Text = "ESTRUTURAS DE REPETIÇÃO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(BtnForEach);
            Controls.Add(BtnFor);
            Controls.Add(BtnDoWhile);
            Controls.Add(btnWhile);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Estruturas de repetição";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnWhile;
        private Button BtnDoWhile;
        private Button BtnFor;
        private Button BtnForEach;
        private Label label5;
    }
}