namespace ListaFadinha
{
    partial class Lista
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.NomeColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamiliaColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementoColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbTamanhoAsaMais = new System.Windows.Forms.CheckBox();
            this.ckbTamanhoAsaMenos = new System.Windows.Forms.CheckBox();
            this.ckbMulher = new System.Windows.Forms.CheckBox();
            this.ckbHomem = new System.Windows.Forms.CheckBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.cbCorDaAsa = new System.Windows.Forms.ComboBox();
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnApagar);
            this.tabPage1.Controls.Add(this.dgvLista);
            this.tabPage1.Controls.Add(this.btnAdicionar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(194, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 51);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(348, 15);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(117, 51);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColunn,
            this.FamiliaColunn,
            this.ElementoColunn,
            this.SexoColunn});
            this.dgvLista.Location = new System.Drawing.Point(9, 81);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(494, 239);
            this.dgvLista.TabIndex = 3;
            // 
            // NomeColunn
            // 
            this.NomeColunn.HeaderText = "Nome";
            this.NomeColunn.Name = "NomeColunn";
            this.NomeColunn.ReadOnly = true;
            // 
            // FamiliaColunn
            // 
            this.FamiliaColunn.HeaderText = "Família";
            this.FamiliaColunn.Name = "FamiliaColunn";
            this.FamiliaColunn.ReadOnly = true;
            // 
            // ElementoColunn
            // 
            this.ElementoColunn.HeaderText = "Elemento";
            this.ElementoColunn.Name = "ElementoColunn";
            this.ElementoColunn.ReadOnly = true;
            // 
            // SexoColunn
            // 
            this.SexoColunn.HeaderText = "Sexo";
            this.SexoColunn.Name = "SexoColunn";
            this.SexoColunn.ReadOnly = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(34, 15);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(117, 51);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.ckbTamanhoAsaMais);
            this.tabPage2.Controls.Add(this.ckbTamanhoAsaMenos);
            this.tabPage2.Controls.Add(this.ckbMulher);
            this.tabPage2.Controls.Add(this.ckbHomem);
            this.tabPage2.Controls.Add(this.rbNao);
            this.tabPage2.Controls.Add(this.rbSim);
            this.tabPage2.Controls.Add(this.cbCorDaAsa);
            this.tabPage2.Controls.Add(this.cbElemento);
            this.tabPage2.Controls.Add(this.cbFamilia);
            this.tabPage2.Controls.Add(this.cbCor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(299, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 51);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(89, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 51);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ckbTamanhoAsaMais
            // 
            this.ckbTamanhoAsaMais.AutoSize = true;
            this.ckbTamanhoAsaMais.Checked = true;
            this.ckbTamanhoAsaMais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTamanhoAsaMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTamanhoAsaMais.Location = new System.Drawing.Point(347, 19);
            this.ckbTamanhoAsaMais.Name = "ckbTamanhoAsaMais";
            this.ckbTamanhoAsaMais.Size = new System.Drawing.Size(69, 19);
            this.ckbTamanhoAsaMais.TabIndex = 20;
            this.ckbTamanhoAsaMais.Text = "15cm+";
            this.ckbTamanhoAsaMais.UseVisualStyleBackColor = true;
            // 
            // ckbTamanhoAsaMenos
            // 
            this.ckbTamanhoAsaMenos.AutoSize = true;
            this.ckbTamanhoAsaMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTamanhoAsaMenos.Location = new System.Drawing.Point(429, 20);
            this.ckbTamanhoAsaMenos.Name = "ckbTamanhoAsaMenos";
            this.ckbTamanhoAsaMenos.Size = new System.Drawing.Size(66, 19);
            this.ckbTamanhoAsaMenos.TabIndex = 19;
            this.ckbTamanhoAsaMenos.Text = "15cm-";
            this.ckbTamanhoAsaMenos.UseVisualStyleBackColor = true;
            // 
            // ckbMulher
            // 
            this.ckbMulher.AutoSize = true;
            this.ckbMulher.Checked = true;
            this.ckbMulher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMulher.Location = new System.Drawing.Point(424, 149);
            this.ckbMulher.Name = "ckbMulher";
            this.ckbMulher.Size = new System.Drawing.Size(71, 19);
            this.ckbMulher.TabIndex = 17;
            this.ckbMulher.Text = "Mulher";
            this.ckbMulher.UseVisualStyleBackColor = true;
            // 
            // ckbHomem
            // 
            this.ckbHomem.AutoSize = true;
            this.ckbHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHomem.Location = new System.Drawing.Point(347, 149);
            this.ckbHomem.Name = "ckbHomem";
            this.ckbHomem.Size = new System.Drawing.Size(76, 19);
            this.ckbHomem.TabIndex = 1;
            this.ckbHomem.Text = "Homem";
            this.ckbHomem.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNao.Location = new System.Drawing.Point(411, 68);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(51, 19);
            this.rbNao.TabIndex = 16;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Checked = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(349, 68);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(48, 19);
            this.rbSim.TabIndex = 15;
            this.rbSim.Text = "sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // cbCorDaAsa
            // 
            this.cbCorDaAsa.FormattingEnabled = true;
            this.cbCorDaAsa.Location = new System.Drawing.Point(349, 102);
            this.cbCorDaAsa.Name = "cbCorDaAsa";
            this.cbCorDaAsa.Size = new System.Drawing.Size(121, 24);
            this.cbCorDaAsa.TabIndex = 14;
            // 
            // cbElemento
            // 
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Location = new System.Drawing.Point(89, 60);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(121, 24);
            this.cbElemento.TabIndex = 13;
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(89, 100);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(121, 24);
            this.cbFamilia.TabIndex = 12;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(89, 144);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(121, 24);
            this.cbCor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tamanho da asa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Faz barulho ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cor da asa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Elemento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Família:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 22);
            this.txtNome.TabIndex = 4;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(521, 386);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lista";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamiliaColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementoColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoColunn;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.ComboBox cbCorDaAsa;
        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckbTamanhoAsaMais;
        private System.Windows.Forms.CheckBox ckbTamanhoAsaMenos;
        private System.Windows.Forms.CheckBox ckbMulher;
        private System.Windows.Forms.CheckBox ckbHomem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

