namespace Repeticao
{
    partial class LsbMostraForEach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LsbMostraForEach));
            label1 = new Label();
            BtnForEach = new Button();
            BtnBack4 = new Button();
            label2 = new Label();
            BoxForEach = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 0;
            label1.Text = "ESTRUTURA FOREACH";
            // 
            // BtnForEach
            // 
            BtnForEach.Font = new Font("Segoe UI", 12F);
            BtnForEach.Location = new Point(331, 378);
            BtnForEach.Name = "BtnForEach";
            BtnForEach.Size = new Size(161, 60);
            BtnForEach.TabIndex = 1;
            BtnForEach.Text = "Mostrar mensagens";
            BtnForEach.UseVisualStyleBackColor = true;
            BtnForEach.Click += BtnForEach_Click;
            // 
            // BtnBack4
            // 
            BtnBack4.Font = new Font("Segoe UI", 12F);
            BtnBack4.Location = new Point(65, 378);
            BtnBack4.Name = "BtnBack4";
            BtnBack4.Size = new Size(172, 60);
            BtnBack4.TabIndex = 2;
            BtnBack4.Text = "Sair da estrutura atual";
            BtnBack4.UseVisualStyleBackColor = true;
            BtnBack4.Click += BtnBack4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 153);
            label2.Name = "label2";
            label2.Size = new Size(370, 90);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BoxForEach
            // 
            BoxForEach.FormattingEnabled = true;
            BoxForEach.ItemHeight = 15;
            BoxForEach.Location = new Point(513, 59);
            BoxForEach.Name = "BoxForEach";
            BoxForEach.Size = new Size(275, 379);
            BoxForEach.TabIndex = 6;
            // 
            // LsbMostraForEach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BoxForEach);
            Controls.Add(label2);
            Controls.Add(BtnBack4);
            Controls.Add(BtnForEach);
            Controls.Add(label1);
            Name = "LsbMostraForEach";
            Text = "Estrutura ForEach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnForEach;
        private Button BtnBack4;
        private Label label2;
        private ListBox BoxForEach;
    }
}