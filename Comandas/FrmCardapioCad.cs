using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {
        bool ehNovo = false;
        public FrmCardapioCad(bool acao)
        {
            ehNovo = acao;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cyberTextBox4_Load(object sender, EventArgs e)
        {

        }

        private void cyberTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void cyberTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se o form está em modo de inclusão 
            if (ehNovo)
            {
                // Executa o método que realiza o INSERT na tabela
                AdicionarCardapio();
            }
            else
            { // Executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            }// Fecha a teal atual (FrmCardapioCad)
            Close();
        }

        private void AtualizarCardapio()
        {
            throw new NotImplementedException();
        }

        private void AdicionarCardapio()
        {
            using (var banco = new AppDbContext())
            {

                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.TextButton,
                    Descricao = txtDescricao.TextButton,
                    Preco = decimal.Parse (txtPreco.TextButton),
                    PossuiPreparo = chkPreparo.Checked,

                };
                banco.Cardapios.Add(novoCardapio);
                banco.SaveChanges();

            }
        }
    }
}
