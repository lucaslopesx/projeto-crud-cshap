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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            cn.Open();

            string sql = $"Select * from ProdutosEstoque where {comboBox1.SelectedItem} LIKE '{txtBusca.Text}%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
