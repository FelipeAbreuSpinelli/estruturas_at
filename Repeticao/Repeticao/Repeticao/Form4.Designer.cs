namespace Repeticao
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            BtnFor = new Button();
            BtnBack3 = new Button();
            label2 = new Label();
            BoxFor = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 0;
            label1.Text = "ESTRUTURA FOR";
            // 
            // BtnFor
            // 
            BtnFor.Font = new Font("Segoe UI", 12F);
            BtnFor.Location = new Point(286, 375);
            BtnFor.Name = "BtnFor";
            BtnFor.Size = new Size(197, 53);
            BtnFor.TabIndex = 1;
            BtnFor.Text = "Mostrar cálculo";
            BtnFor.UseVisualStyleBackColor = true;
            BtnFor.Click += BtnFor_Click;
            // 
            // BtnBack3
            // 
            BtnBack3.Font = new Font("Segoe UI", 12F);
            BtnBack3.Location = new Point(36, 375);
            BtnBack3.Name = "BtnBack3";
            BtnBack3.Size = new Size(197, 53);
            BtnBack3.TabIndex = 2;
            BtnBack3.Text = "Sair da estrutura atual";
            BtnBack3.UseVisualStyleBackColor = true;
            BtnBack3.Click += BtnBack3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 115);
            label2.Name = "label2";
            label2.Size = new Size(349, 105);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BoxFor
            // 
            BoxFor.FormattingEnabled = true;
            BoxFor.ItemHeight = 15;
            BoxFor.Location = new Point(502, 79);
            BoxFor.Name = "BoxFor";
            BoxFor.Size = new Size(275, 349);
            BoxFor.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BoxFor);
            Controls.Add(label2);
            Controls.Add(BtnBack3);
            Controls.Add(BtnFor);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Estrutura For";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnFor;
        private Button BtnBack3;
        private Label label2;
        private ListBox BoxFor;
    }
}