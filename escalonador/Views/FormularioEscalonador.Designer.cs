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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTempoProcesso = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProcesso = new System.Windows.Forms.TextBox();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCriaProcesso = new System.Windows.Forms.Button();
            this.GridNaoProcessados = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grid2Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grid1Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNaoProcessados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(548, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criação de Processos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo de Vida :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição :\r\n";
            // 
            // TxtTempoProcesso
            // 
            this.TxtTempoProcesso.Location = new System.Drawing.Point(117, 52);
            this.TxtTempoProcesso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTempoProcesso.Name = "TxtTempoProcesso";
            this.TxtTempoProcesso.Size = new System.Drawing.Size(240, 22);
            this.TxtTempoProcesso.TabIndex = 4;
            // 
            // TxtDescricaoProcesso
            // 
            this.TxtDescricaoProcesso.Location = new System.Drawing.Point(117, 23);
            this.TxtDescricaoProcesso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescricaoProcesso.Name = "TxtDescricaoProcesso";
            this.TxtDescricaoProcesso.Size = new System.Drawing.Size(240, 22);
            this.TxtDescricaoProcesso.TabIndex = 3;
            this.TxtDescricaoProcesso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(117, 84);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(240, 24);
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
            // GridNaoProcessados
            // 
            this.GridNaoProcessados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNaoProcessados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid1Ordem,
            this.grid1Nome,
            this.grid1Status,
            this.grid1Tempo,
            this.grid1Processador});
            this.GridNaoProcessados.Location = new System.Drawing.Point(8, 39);
            this.GridNaoProcessados.Margin = new System.Windows.Forms.Padding(4);
            this.GridNaoProcessados.Name = "GridNaoProcessados";
            this.GridNaoProcessados.Size = new System.Drawing.Size(571, 561);
            this.GridNaoProcessados.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid2Ordem,
            this.grid2Nome,
            this.grid2Status,
            this.grid2Tempo});
            this.dataGridView2.Location = new System.Drawing.Point(12, 39);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 561);
            this.dataGridView2.TabIndex = 2;
            // 
            // grid2Ordem
            // 
            this.grid2Ordem.HeaderText = "Ordem";
            this.grid2Ordem.Name = "grid2Ordem";
            // 
            // grid2Nome
            // 
            this.grid2Nome.HeaderText = "Nome";
            this.grid2Nome.Name = "grid2Nome";
            // 
            // grid2Status
            // 
            this.grid2Status.HeaderText = "Status";
            this.grid2Status.Name = "grid2Status";
            // 
            // grid2Tempo
            // 
            this.grid2Tempo.HeaderText = "Tempo";
            this.grid2Tempo.Name = "grid2Tempo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(599, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(315, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações Processadores";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 121);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Parar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AdicionarConfiguracao);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 64);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 2;
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
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(936, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(220, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações com Processos";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 81);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Finalizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.FinalizarProcessos);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 49);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "Pausar/Pronto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PausarProcessos);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridNaoProcessados);
            this.groupBox4.Location = new System.Drawing.Point(16, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(587, 608);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " EscalonadorDeProcessos Round Robin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(599, 191);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(557, 608);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processos em Espera";
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
            // FormularioEscalonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.groupBox5);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridNaoProcessados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridNaoProcessados;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Processador;
    }
}

