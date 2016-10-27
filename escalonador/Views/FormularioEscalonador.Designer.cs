namespace EscalonadorDeProcessos.Views
{
    partial class FormularioEscalonador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTempoProcesso = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProcesso = new System.Windows.Forms.TextBox();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCriaProcesso = new System.Windows.Forms.Button();
            this.GridProcessos = new System.Windows.Forms.DataGridView();
            this.grid1Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridProcessosEmEspera = new System.Windows.Forms.DataGridView();
            this.grid2Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLimparProcessador = new System.Windows.Forms.Button();
            this.BtnAdicionarProcessador = new System.Windows.Forms.Button();
            this.TxtNucleosProcessador = new System.Windows.Forms.TextBox();
            this.TxtTempoProcessador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboTipoProcessador = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnExecutarProcessos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GridProcessadores = new System.Windows.Forms.DataGridView();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nucleos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessosEmEspera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessadores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtTempoProcesso);
            this.groupBox1.Controls.Add(this.TxtDescricaoProcesso);
            this.groupBox1.Controls.Add(this.ComboStatus);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnCriaProcesso);
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criação de Processos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo de Vida :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição :\r\n";
            // 
            // TxtTempoProcesso
            // 
            this.TxtTempoProcesso.Location = new System.Drawing.Point(125, 52);
            this.TxtTempoProcesso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTempoProcesso.Name = "TxtTempoProcesso";
            this.TxtTempoProcesso.Size = new System.Drawing.Size(232, 22);
            this.TxtTempoProcesso.TabIndex = 4;
            // 
            // TxtDescricaoProcesso
            // 
            this.TxtDescricaoProcesso.Location = new System.Drawing.Point(125, 23);
            this.TxtDescricaoProcesso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescricaoProcesso.Name = "TxtDescricaoProcesso";
            this.TxtDescricaoProcesso.Size = new System.Drawing.Size(232, 22);
            this.TxtDescricaoProcesso.TabIndex = 3;
            this.TxtDescricaoProcesso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(125, 84);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(232, 24);
            this.ComboStatus.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(189, 121);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(169, 28);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.CriarProcessoAleatorio);
            // 
            // btnCriaProcesso
            // 
            this.btnCriaProcesso.Location = new System.Drawing.Point(8, 121);
            this.btnCriaProcesso.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriaProcesso.Name = "btnCriaProcesso";
            this.btnCriaProcesso.Size = new System.Drawing.Size(173, 28);
            this.btnCriaProcesso.TabIndex = 0;
            this.btnCriaProcesso.Text = "Criar Processo";
            this.btnCriaProcesso.UseVisualStyleBackColor = true;
            this.btnCriaProcesso.Click += new System.EventHandler(this.CriarProcesso);
            // 
            // GridProcessos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcessos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid1Ordem,
            this.grid1Nome,
            this.grid1Status,
            this.grid1Tempo,
            this.grid1Processador});
            this.GridProcessos.Location = new System.Drawing.Point(8, 23);
            this.GridProcessos.Margin = new System.Windows.Forms.Padding(4);
            this.GridProcessos.Name = "GridProcessos";
            this.GridProcessos.Size = new System.Drawing.Size(644, 578);
            this.GridProcessos.TabIndex = 1;
            // 
            // grid1Ordem
            // 
            this.grid1Ordem.HeaderText = "Ordem";
            this.grid1Ordem.Name = "grid1Ordem";
            // 
            // grid1Nome
            // 
            this.grid1Nome.HeaderText = "Descricao";
            this.grid1Nome.Name = "grid1Nome";
            // 
            // grid1Status
            // 
            this.grid1Status.HeaderText = "Status";
            this.grid1Status.Name = "grid1Status";
            // 
            // grid1Tempo
            // 
            this.grid1Tempo.HeaderText = "Tempo";
            this.grid1Tempo.Name = "grid1Tempo";
            // 
            // grid1Processador
            // 
            this.grid1Processador.HeaderText = "Processador";
            this.grid1Processador.Name = "grid1Processador";
            // 
            // GridProcessosEmEspera
            // 
            this.GridProcessosEmEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessosEmEspera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid2Ordem,
            this.grid2Nome,
            this.grid2Status,
            this.grid2Tempo});
            this.GridProcessosEmEspera.Location = new System.Drawing.Point(8, 23);
            this.GridProcessosEmEspera.Margin = new System.Windows.Forms.Padding(4);
            this.GridProcessosEmEspera.Name = "GridProcessosEmEspera";
            this.GridProcessosEmEspera.Size = new System.Drawing.Size(608, 578);
            this.GridProcessosEmEspera.TabIndex = 2;
            // 
            // grid2Ordem
            // 
            this.grid2Ordem.HeaderText = "Ordem";
            this.grid2Ordem.Name = "grid2Ordem";
            this.grid2Ordem.ReadOnly = true;
            // 
            // grid2Nome
            // 
            this.grid2Nome.HeaderText = "Nome";
            this.grid2Nome.Name = "grid2Nome";
            this.grid2Nome.ReadOnly = true;
            // 
            // grid2Status
            // 
            this.grid2Status.HeaderText = "Status";
            this.grid2Status.Name = "grid2Status";
            this.grid2Status.ReadOnly = true;
            // 
            // grid2Tempo
            // 
            this.grid2Tempo.HeaderText = "Tempo";
            this.grid2Tempo.Name = "grid2Tempo";
            this.grid2Tempo.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLimparProcessador);
            this.groupBox2.Controls.Add(this.BtnAdicionarProcessador);
            this.groupBox2.Controls.Add(this.TxtNucleosProcessador);
            this.groupBox2.Controls.Add(this.TxtTempoProcessador);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(400, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(315, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações Processadores";
            // 
            // BtnLimparProcessador
            // 
            this.BtnLimparProcessador.Location = new System.Drawing.Point(161, 121);
            this.BtnLimparProcessador.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimparProcessador.Name = "BtnLimparProcessador";
            this.BtnLimparProcessador.Size = new System.Drawing.Size(145, 28);
            this.BtnLimparProcessador.TabIndex = 5;
            this.BtnLimparProcessador.Text = "Limpar";
            this.BtnLimparProcessador.UseVisualStyleBackColor = true;
            this.BtnLimparProcessador.Click += new System.EventHandler(this.BtnLimparProcessador_Click);
            // 
            // BtnAdicionarProcessador
            // 
            this.BtnAdicionarProcessador.Location = new System.Drawing.Point(12, 121);
            this.BtnAdicionarProcessador.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdicionarProcessador.Name = "BtnAdicionarProcessador";
            this.BtnAdicionarProcessador.Size = new System.Drawing.Size(141, 28);
            this.BtnAdicionarProcessador.TabIndex = 4;
            this.BtnAdicionarProcessador.Text = "Adicionar";
            this.BtnAdicionarProcessador.UseVisualStyleBackColor = true;
            this.BtnAdicionarProcessador.Click += new System.EventHandler(this.AdicionarConfiguracao);
            // 
            // TxtNucleosProcessador
            // 
            this.TxtNucleosProcessador.Location = new System.Drawing.Point(145, 64);
            this.TxtNucleosProcessador.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNucleosProcessador.Name = "TxtNucleosProcessador";
            this.TxtNucleosProcessador.Size = new System.Drawing.Size(160, 22);
            this.TxtNucleosProcessador.TabIndex = 3;
            // 
            // TxtTempoProcessador
            // 
            this.TxtTempoProcessador.Location = new System.Drawing.Point(145, 28);
            this.TxtTempoProcessador.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTempoProcessador.Name = "TxtTempoProcessador";
            this.TxtTempoProcessador.Size = new System.Drawing.Size(160, 22);
            this.TxtTempoProcessador.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Máx. de Processos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = " Tempo Quantun :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboTipoProcessador);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.BtnExecutarProcessos);
            this.groupBox3.Location = new System.Drawing.Point(1088, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(220, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações com Processos";
            // 
            // ComboTipoProcessador
            // 
            this.ComboTipoProcessador.FormattingEnabled = true;
            this.ComboTipoProcessador.Location = new System.Drawing.Point(45, 37);
            this.ComboTipoProcessador.Name = "ComboTipoProcessador";
            this.ComboTipoProcessador.Size = new System.Drawing.Size(144, 24);
            this.ComboTipoProcessador.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 110);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Finalizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.FinalizarProcessos);
            // 
            // BtnExecutarProcessos
            // 
            this.BtnExecutarProcessos.Location = new System.Drawing.Point(45, 74);
            this.BtnExecutarProcessos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExecutarProcessos.Name = "BtnExecutarProcessos";
            this.BtnExecutarProcessos.Size = new System.Drawing.Size(144, 28);
            this.BtnExecutarProcessos.TabIndex = 0;
            this.BtnExecutarProcessos.Text = "Executar/Pausar";
            this.BtnExecutarProcessos.UseVisualStyleBackColor = true;
            this.BtnExecutarProcessos.Click += new System.EventHandler(this.ExecutarProcessos);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridProcessos);
            this.groupBox4.Location = new System.Drawing.Point(648, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(660, 609);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " EscalonadorDeProcessos Round Robin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GridProcessosEmEspera);
            this.groupBox5.Location = new System.Drawing.Point(16, 192);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(624, 609);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processos em Espera";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.GridProcessadores);
            this.groupBox6.Location = new System.Drawing.Point(722, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(359, 156);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Processadores";
            // 
            // GridProcessadores
            // 
            this.GridProcessadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tempo,
            this.Nucleos});
            this.GridProcessadores.Location = new System.Drawing.Point(6, 21);
            this.GridProcessadores.Name = "GridProcessadores";
            this.GridProcessadores.RowTemplate.Height = 24;
            this.GridProcessadores.Size = new System.Drawing.Size(347, 128);
            this.GridProcessadores.TabIndex = 0;
            // 
            // Tempo
            // 
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Nucleos
            // 
            this.Nucleos.HeaderText = "Nucleos";
            this.Nucleos.Name = "Nucleos";
            this.Nucleos.ReadOnly = true;
            // 
            // FormularioEscalonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 814);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormularioEscalonador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscalonadorDeProcessos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessosEmEspera)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridProcessos;
        private System.Windows.Forms.DataGridView GridProcessosEmEspera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTempoProcesso;
        private System.Windows.Forms.TextBox TxtDescricaoProcesso;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCriaProcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLimparProcessador;
        private System.Windows.Forms.Button BtnAdicionarProcessador;
        private System.Windows.Forms.TextBox TxtNucleosProcessador;
        private System.Windows.Forms.TextBox TxtTempoProcessador;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnExecutarProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Processador;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView GridProcessadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nucleos;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Tempo;
        private System.Windows.Forms.ComboBox ComboTipoProcessador;
    }
}

