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
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            cn.Open();

            SqlCommand cd = new SqlCommand();

            cd.Connection = cn;
            cd.CommandText = $"update ProdutosEstoque set descricao = '{txtDesc.Text}', quantidade = '{txtQuantidade.Text}', preco = '{txtPreco.Text}', categoria = '{txtCategoria.Text}' where idProduto = {idProduto}";


            cd.ExecuteNonQuery();
            MessageBox.Show("Registro alterado com sucesso!!");
            cn.Close();
            frmAlterar_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProduto = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Select * from ProdutosEstoque where idProduto = {idProduto}";
            cd.Connection = cn;
            cn.Open();

            SqlDataReader dr = cd.ExecuteReader();

            if (dr.Read())
            {
                txtDesc.Text = dr["descricao"].ToString();
                txtPreco.Text = dr["preco"].ToString();
                txtQuantidade.Text = dr["quantidade"].ToString();
                txtCategoria.Text = dr["categoria"].ToString();
            }
            cn.Close();
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from ProdutosEstoque", cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            comboBox1.DisplayMember = "nomeProduto";
            comboBox1.ValueMember = "idProduto";
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
