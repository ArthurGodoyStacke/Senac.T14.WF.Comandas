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
    public partial class FrmUsuario : Form
    {
        private bool ehNovo;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ehNovo)
                CriarUsuario();
            else
                atualizarUsuario();
        }

        private void atualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
               .Usuarios
               .Where(e => e.Id == 1)

               .FirstOrDefault();

                usuario.Nome = "Natasha";
                usuario.Email = "nat@gmail.com";
                banco.SaveChanges();
            }


        }

        private void CriarUsuario()
        {
            // acessar o banco
            using (var banco = new AppDbContext())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuimos as propriedades do usuário
                novoUsuario.Nome = "Arthur";
                novoUsuario.Email = "arthurgodoy@gmail.com";
                novoUsuario.Senha = "123";
                // salvar as alterações (INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();


                MessageBox.Show("Usuário cadastrado com sucesso.");

            }




        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
        }
    }
}
