namespace Formulario_carros
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
            this.txCadastra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txCadastra
            // 
            this.txCadastra.Location = new System.Drawing.Point(13, 144);
            this.txCadastra.Name = "txCadastra";
            this.txCadastra.Size = new System.Drawing.Size(775, 85);
            this.txCadastra.TabIndex = 0;
            this.txCadastra.Text = "Clique Aqui Para Cadastrar";
            this.txCadastra.UseVisualStyleBackColor = true;
            this.txCadastra.Click += new System.EventHandler(this.TxCadastra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txCadastra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txCadastra;
    }
}

