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
            this.Naosei = new System.Windows.Forms.TabPage();
            this.btnCadastroRapido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbTamanhoAsaMais = new System.Windows.Forms.CheckBox();
            this.ckbTamanhoAsaMenos = new System.Windows.Forms.CheckBox();
            this.cbCorDaAsa = new System.Windows.Forms.ComboBox();
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.btnCadastroRapido1 = new System.Windows.Forms.Button();
            this.btnCadastroRapido2 = new System.Windows.Forms.Button();
            this.ckbMulher = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.Naosei.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Naosei);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // Naosei
            // 
            this.Naosei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Naosei.Controls.Add(this.ckbMulher);
            this.Naosei.Controls.Add(this.btnCadastroRapido);
            this.Naosei.Controls.Add(this.btnCancelar);
            this.Naosei.Controls.Add(this.ckbTamanhoAsaMais);
            this.Naosei.Controls.Add(this.ckbTamanhoAsaMenos);
            this.Naosei.Controls.Add(this.rbNao);
            this.Naosei.Controls.Add(this.rbSim);
            this.Naosei.Controls.Add(this.cbCorDaAsa);
            this.Naosei.Controls.Add(this.cbElemento);
            this.Naosei.Controls.Add(this.cbFamilia);
            this.Naosei.Controls.Add(this.cbCor);
            this.Naosei.Controls.Add(this.label8);
            this.Naosei.Controls.Add(this.label7);
            this.Naosei.Controls.Add(this.label6);
            this.Naosei.Controls.Add(this.label5);
            this.Naosei.Controls.Add(this.label3);
            this.Naosei.Controls.Add(this.label2);
            this.Naosei.Controls.Add(this.label1);
            this.Naosei.Controls.Add(this.txtNome);
            this.Naosei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naosei.Location = new System.Drawing.Point(4, 22);
            this.Naosei.Name = "Naosei";
            this.Naosei.Padding = new System.Windows.Forms.Padding(3);
            this.Naosei.Size = new System.Drawing.Size(506, 326);
            this.Naosei.TabIndex = 1;
            this.Naosei.Text = "Cadastro";
            // 
            // btnCadastroRapido
            // 
            this.btnCadastroRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRapido.Location = new System.Drawing.Point(347, 212);
            this.btnCadastroRapido.Name = "btnCadastroRapido";
            this.btnCadastroRapido.Size = new System.Drawing.Size(117, 51);
            this.btnCadastroRapido.TabIndex = 22;
            this.btnCadastroRapido.Text = "Salvar";
            this.btnCadastroRapido.UseVisualStyleBackColor = false;
            this.btnCadastroRapido.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(199, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 51);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // cbCorDaAsa
            // 
            this.cbCorDaAsa.FormattingEnabled = true;
            this.cbCorDaAsa.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta",
            "Amarelo-avermelhado",
            "Amarelo-canário",
            "Amarelo-cinzento",
            "Amarelo-enxofre",
            "Amarelo-esverdeado",
            "Amarelo-fosco",
            "Amarelo-gualdo",
            "Amarelo-limão",
            "Amarelo-ocre",
            "Amarelo-ouro",
            "Amarelo-palha",
            "Amarelo-torrado",
            "Azul-ardósia",
            "Azul-celeste",
            "Azul-cobalto",
            "Azul-ferrete",
            "Azul-marinho",
            "Azul-pavão",
            "Azul-petróleo",
            "Azul-piscina",
            "Azul-turquesa",
            "Azul-violeta",
            "Branco-sujo",
            "Castanho-avermelhado",
            "Cinza-ardósia",
            "Cinzento-azulado",
            "Cinzento-pérola",
            "Rosa-bebê",
            "Rosa-choque",
            "Verde-abacate",
            "Verde-água",
            "Verde-alface",
            "Verde-amarelo",
            "Verde-azul",
            "Verde-bandeira",
            "Verde-bronze",
            "Verde-cinza",
            "Verde-esmeralda",
            "Verde-garrafa",
            "Verde-mar",
            "Verde-militar",
            "Verde-musgo",
            "Verde-oliva",
            "Vermelho-alaranjado",
            "Vermelho-cereja",
            "Vermelho-púrpura",
            "Vermelho-tostado",
            "Amarelo-claro",
            "Amarelo-escuro",
            "Azul-claro",
            "Azul-escuro",
            "Castanho-claro",
            "Castanho-escuro",
            "Cinza-claro",
            "Cinza-escuro",
            "Laranja-claro",
            "Laranja-escuro",
            "Marrom-claro",
            "Marrom-escuro",
            "Rosa-claro",
            "Rosa-escuro",
            "Verde-claro",
            "Verde-escuro"});
            this.cbCorDaAsa.Location = new System.Drawing.Point(349, 102);
            this.cbCorDaAsa.Name = "cbCorDaAsa";
            this.cbCorDaAsa.Size = new System.Drawing.Size(146, 24);
            this.cbCorDaAsa.TabIndex = 14;
            // 
            // cbElemento
            // 
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Items.AddRange(new object[] {
            "- Terra",
            "- Ar",
            "- Fogo",
            "- Água"});
            this.cbElemento.Location = new System.Drawing.Point(89, 60);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(121, 24);
            this.cbElemento.TabIndex = 13;
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Items.AddRange(new object[] {
            "- Dua mie",
            "- Embrishd",
            "- Chonsju",
            "- folkyes",
            "- kengov",
            "- Yensad",
            "- Aka soli"});
            this.cbFamilia.Location = new System.Drawing.Point(89, 100);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(121, 24);
            this.cbFamilia.TabIndex = 12;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta",
            "Amarelo-avermelhado",
            "Amarelo-canário",
            "Amarelo-cinzento",
            "Amarelo-enxofre",
            "Amarelo-esverdeado",
            "Amarelo-fosco",
            "Amarelo-gualdo",
            "Amarelo-limão",
            "Amarelo-ocre",
            "Amarelo-ouro",
            "Amarelo-palha",
            "Amarelo-torrado",
            "Azul-ardósia",
            "Azul-celeste",
            "Azul-cobalto",
            "Azul-ferrete",
            "Azul-marinho",
            "Azul-pavão",
            "Azul-petróleo",
            "Azul-piscina",
            "Azul-turquesa",
            "Azul-violeta",
            "Branco-sujo",
            "Castanho-avermelhado",
            "Cinza-ardósia",
            "Cinzento-azulado",
            "Cinzento-pérola",
            "Rosa-bebê",
            "Rosa-choque",
            "Verde-abacate",
            "Verde-água",
            "Verde-alface",
            "Verde-amarelo",
            "Verde-azul",
            "Verde-bandeira",
            "Verde-bronze",
            "Verde-cinza",
            "Verde-esmeralda",
            "Verde-garrafa",
            "Verde-mar",
            "Verde-militar",
            "Verde-musgo",
            "Verde-oliva",
            "Vermelho-alaranjado",
            "Vermelho-cereja",
            "Vermelho-púrpura",
            "Vermelho-tostado",
            "Amarelo-claro",
            "Amarelo-escuro",
            "Azul-claro",
            "Azul-escuro",
            "Castanho-claro",
            "Castanho-escuro",
            "Cinza-claro",
            "Cinza-escuro",
            "Laranja-claro",
            "Laranja-escuro",
            "Marrom-claro",
            "Marrom-escuro",
            "Rosa-claro",
            "Rosa-escuro",
            "Verde-claro",
            "Verde-escuro"});
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
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNao.Location = new System.Drawing.Point(429, 68);
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
            // btnCadastroRapido1
            // 
            this.btnCadastroRapido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastroRapido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRapido1.Location = new System.Drawing.Point(47, 250);
            this.btnCadastroRapido1.Name = "btnCadastroRapido1";
            this.btnCadastroRapido1.Size = new System.Drawing.Size(117, 51);
            this.btnCadastroRapido1.TabIndex = 24;
            this.btnCadastroRapido1.Text = "Cadastro rápido 01";
            this.btnCadastroRapido1.UseVisualStyleBackColor = false;
            this.btnCadastroRapido1.Click += new System.EventHandler(this.btnCadastroRapido1_Click);
            // 
            // btnCadastroRapido2
            // 
            this.btnCadastroRapido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastroRapido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRapido2.Location = new System.Drawing.Point(179, 259);
            this.btnCadastroRapido2.Name = "btnCadastroRapido2";
            this.btnCadastroRapido2.Size = new System.Drawing.Size(117, 51);
            this.btnCadastroRapido2.TabIndex = 25;
            this.btnCadastroRapido2.Text = "Cadastro rápido 02";
            this.btnCadastroRapido2.UseVisualStyleBackColor = false;
            // 
            // ckbMulher
            // 
            this.ckbMulher.AutoSize = true;
            this.ckbMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMulher.Location = new System.Drawing.Point(358, 149);
            this.ckbMulher.Name = "ckbMulher";
            this.ckbMulher.Size = new System.Drawing.Size(71, 19);
            this.ckbMulher.TabIndex = 26;
            this.ckbMulher.Text = "Mulher";
            this.ckbMulher.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCadastroRapido1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 326);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCadastroRapido2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(506, 326);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.Naosei.ResumeLayout(false);
            this.Naosei.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Naosei;
        private System.Windows.Forms.ComboBox cbCorDaAsa;
        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckbTamanhoAsaMais;
        private System.Windows.Forms.CheckBox ckbTamanhoAsaMenos;
        private System.Windows.Forms.Button btnCadastroRapido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Button btnCadastroRapido1;
        private System.Windows.Forms.Button btnCadastroRapido2;
        private System.Windows.Forms.CheckBox ckbMulher;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

