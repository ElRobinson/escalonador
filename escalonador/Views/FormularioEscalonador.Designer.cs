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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTempoProcesso = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProcesso = new System.Windows.Forms.TextBox();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.btnCriaProcesso = new System.Windows.Forms.Button();
            this.GridProcessos = new System.Windows.Forms.DataGridView();
            this.grid1Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoExecutado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridProcessosEmEspera = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAdicionarProcessador = new System.Windows.Forms.Button();
            this.TxtNucleosProcessador = new System.Windows.Forms.TextBox();
            this.TxtTempoProcessador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GridProcessadores = new System.Windows.Forms.DataGridView();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nucleos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnExecutarProcessos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid2Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoExecutado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessosEmEspera)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnCriaProcesso);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criação de Processos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo de Vida :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição :\r\n";
            // 
            // TxtTempoProcesso
            // 
            this.TxtTempoProcesso.Location = new System.Drawing.Point(94, 42);
            this.TxtTempoProcesso.Name = "TxtTempoProcesso";
            this.TxtTempoProcesso.Size = new System.Drawing.Size(235, 20);
            this.TxtTempoProcesso.TabIndex = 4;
            // 
            // TxtDescricaoProcesso
            // 
            this.TxtDescricaoProcesso.Location = new System.Drawing.Point(94, 19);
            this.TxtDescricaoProcesso.Name = "TxtDescricaoProcesso";
            this.TxtDescricaoProcesso.Size = new System.Drawing.Size(235, 20);
            this.TxtDescricaoProcesso.TabIndex = 3;
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(94, 68);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(235, 21);
            this.ComboStatus.TabIndex = 2;
            // 
            // btnCriaProcesso
            // 
            this.btnCriaProcesso.Location = new System.Drawing.Point(6, 98);
            this.btnCriaProcesso.Name = "btnCriaProcesso";
            this.btnCriaProcesso.Size = new System.Drawing.Size(130, 23);
            this.btnCriaProcesso.TabIndex = 0;
            this.btnCriaProcesso.Text = "Criar Processo";
            this.btnCriaProcesso.UseVisualStyleBackColor = true;
            this.btnCriaProcesso.Click += new System.EventHandler(this.CriarProcesso);
            // 
            // GridProcessos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcessos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid1Ordem,
            this.grid1Nome,
            this.grid1Tempo,
            this.TempoExecutado,
            this.grid1Processador,
            this.grid1Status});
            this.GridProcessos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridProcessos.Location = new System.Drawing.Point(6, 19);
            this.GridProcessos.Name = "GridProcessos";
            this.GridProcessos.ReadOnly = true;
            this.GridProcessos.RowHeadersVisible = false;
            this.GridProcessos.Size = new System.Drawing.Size(586, 383);
            this.GridProcessos.TabIndex = 1;
            // 
            // grid1Ordem
            // 
            this.grid1Ordem.DataPropertyName = "Ordem";
            this.grid1Ordem.HeaderText = "Ordem";
            this.grid1Ordem.Name = "grid1Ordem";
            this.grid1Ordem.ReadOnly = true;
            // 
            // grid1Nome
            // 
            this.grid1Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid1Nome.DataPropertyName = "Descricao";
            this.grid1Nome.HeaderText = "Descricao";
            this.grid1Nome.Name = "grid1Nome";
            this.grid1Nome.ReadOnly = true;
            // 
            // grid1Tempo
            // 
            this.grid1Tempo.DataPropertyName = "Tempo";
            this.grid1Tempo.HeaderText = "Tempo";
            this.grid1Tempo.Name = "grid1Tempo";
            this.grid1Tempo.ReadOnly = true;
            // 
            // TempoExecutado
            // 
            this.TempoExecutado.DataPropertyName = "TempoExecutado";
            this.TempoExecutado.HeaderText = "TempoExecutado";
            this.TempoExecutado.Name = "TempoExecutado";
            this.TempoExecutado.ReadOnly = true;
            this.TempoExecutado.Visible = false;
            // 
            // grid1Processador
            // 
            this.grid1Processador.DataPropertyName = "Processador";
            this.grid1Processador.HeaderText = "Processador";
            this.grid1Processador.Name = "grid1Processador";
            this.grid1Processador.ReadOnly = true;
            // 
            // grid1Status
            // 
            this.grid1Status.DataPropertyName = "Estado";
            this.grid1Status.HeaderText = "Status";
            this.grid1Status.Name = "grid1Status";
            this.grid1Status.ReadOnly = true;
            // 
            // GridProcessosEmEspera
            // 
            this.GridProcessosEmEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessosEmEspera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid2Ordem,
            this.grid2Nome,
            this.grid2Tempo,
            this.TempoExecutado1,
            this.Processador,
            this.grid2Status});
            this.GridProcessosEmEspera.Location = new System.Drawing.Point(9, 19);
            this.GridProcessosEmEspera.Name = "GridProcessosEmEspera";
            this.GridProcessosEmEspera.RowHeadersVisible = false;
            this.GridProcessosEmEspera.Size = new System.Drawing.Size(320, 386);
            this.GridProcessosEmEspera.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAdicionarProcessador);
            this.groupBox2.Controls.Add(this.TxtNucleosProcessador);
            this.groupBox2.Controls.Add(this.TxtTempoProcessador);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(373, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações Processadores";
            // 
            // BtnAdicionarProcessador
            // 
            this.BtnAdicionarProcessador.Location = new System.Drawing.Point(9, 98);
            this.BtnAdicionarProcessador.Name = "BtnAdicionarProcessador";
            this.BtnAdicionarProcessador.Size = new System.Drawing.Size(106, 23);
            this.BtnAdicionarProcessador.TabIndex = 4;
            this.BtnAdicionarProcessador.Text = "Adicionar";
            this.BtnAdicionarProcessador.UseVisualStyleBackColor = true;
            this.BtnAdicionarProcessador.Click += new System.EventHandler(this.AdicionarConfiguracao);
            // 
            // TxtNucleosProcessador
            // 
            this.TxtNucleosProcessador.Location = new System.Drawing.Point(109, 52);
            this.TxtNucleosProcessador.Name = "TxtNucleosProcessador";
            this.TxtNucleosProcessador.Size = new System.Drawing.Size(168, 20);
            this.TxtNucleosProcessador.TabIndex = 3;
            // 
            // TxtTempoProcessador
            // 
            this.TxtTempoProcessador.Location = new System.Drawing.Point(109, 23);
            this.TxtTempoProcessador.Name = "TxtTempoProcessador";
            this.TxtTempoProcessador.Size = new System.Drawing.Size(168, 20);
            this.TxtTempoProcessador.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Máx. de Processos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = " Tempo Quantun :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.GridProcessos);
            this.groupBox4.Location = new System.Drawing.Point(373, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 495);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " EscalonadorDeProcessos Round Robin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GridProcessosEmEspera);
            this.groupBox5.Controls.Add(this.BtnExecutarProcessos);
            this.groupBox5.Location = new System.Drawing.Point(12, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 495);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processos em Espera";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.GridProcessadores);
            this.groupBox6.Location = new System.Drawing.Point(661, 23);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(320, 127);
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
            this.GridProcessadores.Location = new System.Drawing.Point(9, 19);
            this.GridProcessadores.Margin = new System.Windows.Forms.Padding(2);
            this.GridProcessadores.Name = "GridProcessadores";
            this.GridProcessadores.RowHeadersVisible = false;
            this.GridProcessadores.RowTemplate.Height = 24;
            this.GridProcessadores.Size = new System.Drawing.Size(307, 104);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnExecutarProcessos
            // 
            this.BtnExecutarProcessos.Location = new System.Drawing.Point(6, 411);
            this.BtnExecutarProcessos.Name = "BtnExecutarProcessos";
            this.BtnExecutarProcessos.Size = new System.Drawing.Size(108, 23);
            this.BtnExecutarProcessos.TabIndex = 0;
            this.BtnExecutarProcessos.Text = "Executar";
            this.BtnExecutarProcessos.UseVisualStyleBackColor = true;
            this.BtnExecutarProcessos.Click += new System.EventHandler(this.ExecutarProcessos);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pausar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid2Ordem
            // 
            this.grid2Ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grid2Ordem.DataPropertyName = "Ordem";
            this.grid2Ordem.HeaderText = "Ordem";
            this.grid2Ordem.Name = "grid2Ordem";
            this.grid2Ordem.ReadOnly = true;
            // 
            // grid2Nome
            // 
            this.grid2Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grid2Nome.DataPropertyName = "Descricao";
            this.grid2Nome.HeaderText = "Nome";
            this.grid2Nome.Name = "grid2Nome";
            this.grid2Nome.ReadOnly = true;
            // 
            // grid2Tempo
            // 
            this.grid2Tempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grid2Tempo.DataPropertyName = "Tempo";
            this.grid2Tempo.HeaderText = "Tempo";
            this.grid2Tempo.Name = "grid2Tempo";
            this.grid2Tempo.ReadOnly = true;
            // 
            // TempoExecutado1
            // 
            this.TempoExecutado1.DataPropertyName = "TempoExecutado";
            this.TempoExecutado1.HeaderText = "TempoExecutado";
            this.TempoExecutado1.Name = "TempoExecutado1";
            this.TempoExecutado1.Visible = false;
            // 
            // Processador
            // 
            this.Processador.DataPropertyName = "Processador";
            this.Processador.HeaderText = "Processador";
            this.Processador.Name = "Processador";
            this.Processador.Visible = false;
            // 
            // grid2Status
            // 
            this.grid2Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grid2Status.DataPropertyName = "Estado";
            this.grid2Status.HeaderText = "Status";
            this.grid2Status.Name = "grid2Status";
            this.grid2Status.ReadOnly = true;
            this.grid2Status.Visible = false;
            // 
            // FormularioEscalonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 602);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTempoProcesso;
        private System.Windows.Forms.TextBox TxtDescricaoProcesso;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Button btnCriaProcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAdicionarProcessador;
        private System.Windows.Forms.TextBox TxtNucleosProcessador;
        private System.Windows.Forms.TextBox TxtTempoProcessador;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView GridProcessadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nucleos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoExecutado;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Processador;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Status;
        private System.Windows.Forms.Button BtnExecutarProcessos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoExecutado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processador;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Status;
    }
}

