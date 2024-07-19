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
            // metodo que lista usuarios
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            using (var banco = new AppDbContext())
            {
                // 2. SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // 3. Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }
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


            desabilitarCampos();


            listarUsuarios();

            limparCampos();

        }

        private void limparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;

        }

        private void atualizarUsuario()
        {
            using (var banco = new AppDbContext())
            { // consulta um usuario na tabela usando o id da tela
                var usuario = banco
               .Usuarios
               .Where(e => e.Id == int.Parse(txtId.TextButton))
               .FirstOrDefault();

                usuario.Nome = txtNome.TextButton; ;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

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
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

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
            habilitarCampos();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // in
            ehNovo = false;
        }
    }
}
