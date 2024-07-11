using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        // método (visibilidade=private, retorno=void
        private void CriarBancoDeDados()
        {
            // criar uma variaval do tipo AppDbContext
            // usar a variavel e acessar o contexto
            // executar a migração // F5
            using (var banco = new AppDbContext())
            {
                // executa a migração (CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }
        }

        // evento de clique
        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //criar o formulário e exibe
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
