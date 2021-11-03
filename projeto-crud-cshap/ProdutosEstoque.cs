using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace projeto_crud_cshap
{
    class ProdutosEstoque
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public float Preco { get; set; }
        public string Busca { get; set; }
        public string Combo { get; set; }


        private Connection connection = new Connection();

        public void Insert()
        {
            string sql = $"Insert into ProdutosEstoque (nomeProduto, descricao, quantidade, categoria, preco) values ('{NomeProduto}', '{Descricao}', '{Quantidade}', '{Categoria}', '{Preco}')";
            connection.Execute(sql);
        }
        public void Update()
        {
            string sql = $"update ProdutosEstoque set descricao = '{Descricao}', quantidade = '{Quantidade}', preco = '{Preco}', categoria = '{Categoria}' where idProduto = {IdProduto}";
            connection.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"delete from ProdutosEstoque where idProduto = {IdProduto}";
            connection.Execute(sql);
        }
        public void Consult()
        {
            string sql = $"Select * from ProdutosEstoque where idProduto = {IdProduto}";
            
            connection.Consult(sql);
            if (connection.dr.Read())
            {
                Categoria = connection.dr["categoria"].ToString();
                Descricao = connection.dr["descricao"].ToString();
                Preco = float.Parse(connection.dr["preco"].ToString());
                Quantidade = int.Parse(connection.dr["quantidade"].ToString());
            }
            connection.Disconnect();
        }
        public DataSet List()
        {
            string sql = "Select * from ProdutosEstoque";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListBy()
        {
            string sql = $"Select * from ProdutosEstoque where {Combo} LIKE '{Busca}%'";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;

        }
    }
}
