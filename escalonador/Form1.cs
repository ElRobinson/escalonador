using System;
using System.Windows.Forms;

namespace escalonador
{
    public partial class Escalonador : Form
    {
        public Escalonador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oi");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public void validaDados() {
            if (txtDescricao.Text.Length > 1)
            {
                if (!comboStatus.SelectedItem.Equals(""))
                {
                    if (txtTempo.Text.Length > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("### erro, tempo inválido ###");
                    }
                }
                else
                {
                    MessageBox.Show("### erro, prioridade inválida ###");
                }
            }
            else {
                MessageBox.Show("### erro, descrição inválida");
            }
        }

        public void LimpaTela() {
            txtDescricao.Text = "";
            comboStatus.SelectedIndex = 0;
            txtTempo.Text = "";
        }

        public void criaProcesso() {

        }
    }

    
}


