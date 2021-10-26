using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projeto_crud_cshap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=1234;";
            cn.Open();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro fc = new frmCadastro();
            fc.ShowDialog();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            frmListar fl = new frmListar();
            fl.ShowDialog();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar fa = new frmAlterar();
            fa.ShowDialog();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            frmExcluir fe = new frmExcluir();
            fe.ShowDialog();
        }
    }
}
