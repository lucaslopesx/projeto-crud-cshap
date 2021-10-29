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
        private ProdutosEstoque data = new ProdutosEstoque();
        public frmListar()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string combo = comboBox1.SelectedItem.ToString();
            data.ListBy(combo);




            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
