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
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void limparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;

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
            habilitarCampos();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            //conectar no banco
            using (var banco = new AppDbContext())
            {
                //realizar consulta na tebela usuarios
                var ususarios = banco.Usuarios.ToList();
                //Popular os dados do grid(dataGridView)
                dgvUsuarios.DataSource = ususarios;

            }


        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // verifica se o indice da linha é maior igual a 0
            // saber se existe uma linha selecionada 

            if (e.RowIndex >= 0)
            {

                //obter dados da linha
                MessageBox.Show("Linha selecionada " + (e.RowIndex + 1));
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var idUsuario = Convert.ToInt32(txtId.TextButton);
            ExcluirUsuario(idUsuario);
            listarUsuarios();
            limparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            MessageBox.Show("Usuário excluído com sucesso");
        }

        private void ExcluirUsuario(int idUsuario)

        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                .Usuarios
                    .First(u => u.Id
                    .Equals(idUsuario)); // SELECT * FROM usuarios WHERE id = ?

                banco.Usuarios.Remove(usuario);
                //gera slq DELETE FROM usuarios WHERE id = ?
                // confirmar a exclusão

                banco.SaveChanges();
            }
            // conectar no banco de dados 
            //consultar o usuario
            //avisar o banco que estou excluindo 
            // confirmar a exclusão
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
