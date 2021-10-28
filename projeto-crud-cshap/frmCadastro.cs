using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_crud_cshap
{
    public partial class frmCadastro : Form
    {
        private ProdutosEstoque data = new ProdutosEstoque();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            data.NomeProduto = txtNome.Text;
            data.Descricao= txtDesc.Text;
            data.Categoria = cbCategoria.Text;
            data.Preco = float.Parse(txtPreco.Text);
            data.Quantidade = int.Parse(txtQuantidade.Text);
            data.Insert();


            MessageBox.Show("Registro incluido com sucesso!!");
            txtNome.Clear();
            txtDesc.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cbCategoria.SelectedItem = 0;
            //cd.CommandText = $"Insert into ProdutosEstoque (nomeProduto, descricao, quantidade, preco, categoria) values ('{txtNome.Text}', '{txtDesc.Text}', '{txtQuantidade.Text}', '{float.Parse(txtPreco.Text)}', '{cbCategoria.SelectedItem}')";
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
