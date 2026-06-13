namespace Repeticao
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            BtnWhile = new Button();
            BtnBack2 = new Button();
            label2 = new Label();
            BoxWhile = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 0;
            label1.Text = "ESTRUTURA WHILE";
            // 
            // BtnWhile
            // 
            BtnWhile.Font = new Font("Segoe UI", 12F);
            BtnWhile.Location = new Point(298, 367);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(183, 62);
            BtnWhile.TabIndex = 1;
            BtnWhile.Text = "Mostrar cálculo";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // BtnBack2
            // 
            BtnBack2.Font = new Font("Segoe UI", 12F);
            BtnBack2.Location = new Point(12, 367);
            BtnBack2.Name = "BtnBack2";
            BtnBack2.Size = new Size(200, 62);
            BtnBack2.TabIndex = 2;
            BtnBack2.Text = "Sair da estrutura atual";
            BtnBack2.UseVisualStyleBackColor = true;
            BtnBack2.Click += BtnBack2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 136);
            label2.Name = "label2";
            label2.Size = new Size(364, 105);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BoxWhile
            // 
            BoxWhile.FormattingEnabled = true;
            BoxWhile.ItemHeight = 15;
            BoxWhile.Location = new Point(503, 80);
            BoxWhile.Name = "BoxWhile";
            BoxWhile.Size = new Size(275, 349);
            BoxWhile.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BoxWhile);
            Controls.Add(label2);
            Controls.Add(BtnBack2);
            Controls.Add(BtnWhile);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Estrutura While";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnWhile;
        private Button BtnBack2;
        private Label label2;
        private ListBox BoxWhile;
    }
}