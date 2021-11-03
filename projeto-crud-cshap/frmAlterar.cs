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
    public partial class frmAlterar : Form
    {
        private ProdutosEstoque data = new ProdutosEstoque();
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            data.IdProduto = int.Parse(comboBox1.SelectedValue.ToString());
            data.Preco = float.Parse(txtPreco.Text);
            data.Quantidade = int.Parse(txtQuantidade.Text);
            data.Categoria = txtCategoria.Text;
            data.Descricao = txtDesc.Text;
            data.Update();

            
            MessageBox.Show("Registro alterado com sucesso!!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.IdProduto = int.Parse(comboBox1.SelectedValue.ToString());
            data.Consult();

            txtCategoria.Text = data.Categoria;
            txtDesc.Text = data.Descricao;
            txtPreco.Text = data.Preco.ToString();
            txtQuantidade.Text = data.Quantidade.ToString();
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nomeProduto";
            comboBox1.ValueMember = "idProduto";
            comboBox1.DataSource = data.List().Tables[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
