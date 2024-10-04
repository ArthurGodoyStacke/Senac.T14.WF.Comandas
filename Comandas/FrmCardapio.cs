namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        public int ID { get; set; }
        public string? TITULO { get; set; }
        public string? DESCRICAO { get;  set; }
        public decimal PRECO { get; set; }
        public bool POSSUIPREPARO { get; set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new AppDbContext())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var ehNovo = true;
            new FrmCardapioCad(ehNovo, this).ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // excibe uma mensgaem de confirmação para o usuario
            var result = MessageBox.Show(
          
                $"Confirma a exclusão do item {TITULO} ?",
                "Excluir Cardápio",

                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question); 
            // se o usuario clica ou não

            if (result == DialogResult.No)
            {
                // para o método
                return;
            }

            // chamar o método excluir
             if (ExcluirCardapio(ID)) 
            { // atualiza a tabela 
                ListarCardapios();
                // exibe a mensgaem de sucesso
                MessageBox.Show($"Cardápio '{TITULO}' excluído com sucesso!");
                btnExcluir.Enabled = false;
                // desabilita o botão excluir
            }
        }

        private bool ExcluirCardapio(int iD)
        {
          // conectar no banco 
          using (var  banco = new AppDbContext())
            {
                // buscar o cardapio atraves do id dele
                var card = banco.Cardapios.First(c=>c.Id ==iD);
                // avisar o banco da exclusao 
                banco.Cardapios.Remove(card);

                // confirmar para o banco a ação 
                banco.SaveChanges();
            }
             return true;
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO,PRECO, POSSUIPREPARO, this).ShowDialog();



        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtem o numero da linha clidada
            var numeroLinha = e.RowIndex;
            // verifica se alguma linha foi selecionada

            if (numeroLinha >= 0)
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString(); ;
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                // converter para os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUIPREPARO = bool.Parse(possuiPreparo); 



                //habilitar o botão Editar e botão excliuir
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
