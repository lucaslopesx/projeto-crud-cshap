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
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into ProdutosEstoque (nomeProduto, descricao, quantidade, preco, categoria) values ('{txtNome.Text}', '{txtDesc.Text}', '{txtQuantidade.Text}', '{float.Parse(txtPreco.Text)}', '{cbCategoria.SelectedItem}')";

            cd.ExecuteNonQuery();


            MessageBox.Show("Registro incluido com sucesso!!");
            txtNome.Clear();
            txtDesc.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cbCategoria.SelectedItem = 0;
        }
    }
}
