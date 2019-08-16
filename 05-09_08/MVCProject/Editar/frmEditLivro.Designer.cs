namespace MVCProject.Editar
{
    partial class frmEditLivro
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
            this.components = new System.ComponentModel.Container();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sistemaBibliotecaHBSISDataSet = new MVCProject.SistemaBibliotecaHBSISDataSet();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaHBSISDataSetTableAdapters.GenerosTableAdapter();
            this.generosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editoraTableAdapter = new MVCProject.SistemaBibliotecaHBSISDataSetTableAdapters.EditoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaHBSISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 401);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(526, 22);
            this.textBox5.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Observações:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Editora:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.editoraBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(526, 24);
            this.comboBox2.TabIndex = 56;
            this.comboBox2.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Genero:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.generosBindingSource1;
            this.comboBox1.DisplayMember = "Titulo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(526, 24);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.ValueMember = "Id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(526, 22);
            this.textBox4.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "ISBN:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(526, 22);
            this.textBox3.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Título:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 71);
            this.button1.TabIndex = 49;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(526, 171);
            this.textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 22);
            this.textBox1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sinopse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registro:";
            // 
            // sistemaBibliotecaHBSISDataSet
            // 
            this.sistemaBibliotecaHBSISDataSet.DataSetName = "SistemaBibliotecaHBSISDataSet";
            this.sistemaBibliotecaHBSISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaHBSISDataSet;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // generosBindingSource1
            // 
            this.generosBindingSource1.DataMember = "Generos";
            this.generosBindingSource1.DataSource = this.sistemaBibliotecaHBSISDataSet;
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.sistemaBibliotecaHBSISDataSet;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 545);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditLivro";
            this.Text = "frmEditLivro";
            this.Load += new System.EventHandler(this.FrmEditLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaHBSISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SistemaBibliotecaHBSISDataSet sistemaBibliotecaHBSISDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaHBSISDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.BindingSource generosBindingSource1;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private SistemaBibliotecaHBSISDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
    }
}