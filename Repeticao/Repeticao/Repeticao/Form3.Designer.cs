namespace Repeticao
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            BtnDoWhile = new Button();
            BtnBack = new Button();
            BoxDoWhile = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 0;
            label1.Text = "ESTRUTURA DOWHILE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 165);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(355, 105);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BtnDoWhile
            // 
            BtnDoWhile.Font = new Font("Segoe UI", 12F);
            BtnDoWhile.Location = new Point(248, 337);
            BtnDoWhile.Name = "BtnDoWhile";
            BtnDoWhile.Size = new Size(198, 81);
            BtnDoWhile.TabIndex = 6;
            BtnDoWhile.Text = "Mostrar cálculo";
            BtnDoWhile.UseVisualStyleBackColor = true;
            BtnDoWhile.Click += BtnDoWhile_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 12F);
            BtnBack.Location = new Point(12, 337);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(198, 81);
            BtnBack.TabIndex = 7;
            BtnBack.Text = "Sair da estrutura atual";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BoxDoWhile
            // 
            BoxDoWhile.FormattingEnabled = true;
            BoxDoWhile.ItemHeight = 15;
            BoxDoWhile.Location = new Point(499, 69);
            BoxDoWhile.Name = "BoxDoWhile";
            BoxDoWhile.Size = new Size(275, 349);
            BoxDoWhile.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BoxDoWhile);
            Controls.Add(BtnBack);
            Controls.Add(BtnDoWhile);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Estrutura DoWhile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnDoWhile;
        private Button BtnBack;
        private ListBox BoxDoWhile;
    }
}