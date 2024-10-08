﻿using System;
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
        private FrmCardapio _frmCardapio;

        public int ID { get; }
        public string? TITULO { get; }
        public string? DESCRICAO { get; }
        public decimal PRECO { get; }
        public bool POSSUIPREPARO { get; }

        public FrmCardapioCad(bool acao, FrmCardapio frmCardapio)
        {
            ehNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }

        public FrmCardapioCad(bool acao, int iD, string? tITULO, string? dESCRICAO, decimal pRECO, bool pOSSUIPREPARO, FrmCardapio frmCardapio) : this(acao, frmCardapio)
        {
            ehNovo = acao;
            InitializeComponent();
            ID = iD;
            TITULO = tITULO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
            POSSUIPREPARO = pOSSUIPREPARO;

            PopularCampos();
        }

        private void PopularCampos()
        {
            txtId.TextButton = ID.ToString();
            txtTitulo.TextButton = TITULO;
            txtDescricao.TextButton = DESCRICAO;
            txtPreco.TextButton = PRECO.ToString();
            chkPreparo.Checked = POSSUIPREPARO;
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
            }
            _frmCardapio.ListarCardapios();
            // Fecha a teal atual (FrmCardapioCad)
            Close();
        }

        private void AtualizarCardapio()
        {
            using(var banco = new AppDbContext())
            {
                var cardapio = banco.Cardapios.FirstOrDefault(c => c.Id == int.Parse(txtId.TextButton)); 
                
                cardapio.Titulo = txtTitulo.TextButton;
                cardapio.Descricao = txtDescricao.TextButton;
                cardapio.Preco = decimal.Parse(txtPreco.TextButton);
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
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
