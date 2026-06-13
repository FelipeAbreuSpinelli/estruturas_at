namespace Condicional
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
            fotopaqueta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fotopaqueta).BeginInit();
            SuspendLayout();
            // 
            // fotopaqueta
            // 
            fotopaqueta.Image = (Image)resources.GetObject("fotopaqueta.Image");
            fotopaqueta.Location = new Point(505, 26);
            fotopaqueta.Name = "fotopaqueta";
            fotopaqueta.Size = new Size(394, 589);
            fotopaqueta.TabIndex = 0;
            fotopaqueta.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 627);
            Controls.Add(fotopaqueta);
            Name = "Form2";
            Text = "Imagens dos jogadores";
            ((System.ComponentModel.ISupportInitialize)fotopaqueta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fotopaqueta;
    }
}