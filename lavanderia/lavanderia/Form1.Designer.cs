namespace lavanderia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNome = new TextBox();
            textBoxID = new TextBox();
            textBoxPeso = new TextBox();
            textBoxValor = new TextBox();
            textBoxCPF = new TextBox();
            comboBoxServico = new ComboBox();
            dataGridView = new DataGridView();
            lblNome = new Label();
            lblCPF = new Label();
            lblID = new Label();
            lblRegistros = new Label();
            label5 = new Label();
            lblValor = new Label();
            lblPeso = new Label();
            buttonSalvar = new Button();
            buttonExcluir = new Button();
            buttonPesquisar = new Button();
            buttonEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(51, 61);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(193, 27);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(281, 61);
            textBoxID.Margin = new Padding(3, 4, 3, 4);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(73, 27);
            textBoxID.TabIndex = 1;
            // 
            // textBoxPeso
            // 
            textBoxPeso.Location = new Point(51, 249);
            textBoxPeso.Margin = new Padding(3, 4, 3, 4);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(114, 27);
            textBoxPeso.TabIndex = 2;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(216, 249);
            textBoxValor.Margin = new Padding(3, 4, 3, 4);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(114, 27);
            textBoxValor.TabIndex = 3;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(51, 172);
            textBoxCPF.Margin = new Padding(3, 4, 3, 4);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(114, 27);
            textBoxCPF.TabIndex = 4;
            // 
            // comboBoxServico
            // 
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Items.AddRange(new object[] { "Lavar", "Entregar" });
            comboBoxServico.Location = new Point(216, 172);
            comboBoxServico.Margin = new Padding(3, 4, 3, 4);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(262, 28);
            comboBoxServico.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(51, 384);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(831, 200);
            dataGridView.TabIndex = 6;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(51, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(51, 148);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(33, 20);
            lblCPF.TabIndex = 8;
            lblCPF.Text = "CPF";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(281, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 9;
            lblID.Text = "ID";
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(51, 360);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(70, 20);
            lblRegistros.TabIndex = 10;
            lblRegistros.Text = "Registros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 148);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 11;
            label5.Text = "Tipo de serviço";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(216, 225);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(80, 20);
            lblValor.TabIndex = 12;
            lblValor.Text = "Valor Total";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(51, 225);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(103, 20);
            lblPeso.TabIndex = 13;
            lblPeso.Text = "Peso da roupa";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(630, 61);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(86, 31);
            buttonSalvar.TabIndex = 14;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(630, 215);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(86, 31);
            buttonExcluir.TabIndex = 15;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(630, 293);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(86, 31);
            buttonPesquisar.TabIndex = 16;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(630, 137);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 17;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonEditar);
            Controls.Add(buttonPesquisar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonSalvar);
            Controls.Add(lblPeso);
            Controls.Add(lblValor);
            Controls.Add(label5);
            Controls.Add(lblRegistros);
            Controls.Add(lblID);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Controls.Add(dataGridView);
            Controls.Add(comboBoxServico);
            Controls.Add(textBoxCPF);
            Controls.Add(textBoxValor);
            Controls.Add(textBoxPeso);
            Controls.Add(textBoxID);
            Controls.Add(textBoxNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxID;
        private TextBox textBoxPeso;
        private TextBox textBoxValor;
        private TextBox textBoxCPF;
        private ComboBox comboBoxServico;
        private DataGridView dataGridView;
        private Label lblNome;
        private Label lblCPF;
        private Label lblID;
        private Label lblRegistros;
        private Label label5;
        private Label lblValor;
        private Label lblPeso;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private Button buttonPesquisar;
        private Button buttonEditar;
    }
}
