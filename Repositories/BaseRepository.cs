/*
*Classe para estabelecer conexão com o MySql
*/
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using VendasApi.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VendasApi.Repositories
{
    public static class BaseRepository
    {
        public static void InsertVenda(Vendas_produtos venda)
        {
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=bd_teste_pratico_sysmap;user=root;password=root");
                string query = @"INSERT INTO vendas_produtos (id_vendas, id_produto, valor,desconto, valor_final,criado_por_usd_id, ind_ativo)
                                  values (@Id_Venda,@Id_produto,@Valor,@Desconto,@Valor_final, @Criado_por_usd_id,
                                   @Ind_ativo);";
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.Add("@Id_Venda", MySqlDbType.Int16).Value = venda.Id_Venda;
                    comando.Parameters.Add("@Id_produto", MySqlDbType.Int16).Value = venda.Id_produto;
                    comando.Parameters.Add("@Valor", MySqlDbType.Double).Value = venda.Valor;
                    comando.Parameters.Add("@Desconto", MySqlDbType.Double).Value = venda.Desconto;
                    comando.Parameters.Add("@Valor_final", MySqlDbType.Double).Value = venda.Valor_final;
                    comando.Parameters.Add("@Criado_por_usd_id", MySqlDbType.Int16).Value = venda.Criado_por_usd_id;
                    comando.Parameters.Add("@Ind_ativo", MySqlDbType.Bit);
                    comando.Parameters["@Ind_ativo"].Value = venda.Ind_ativo;
                    comando.ExecuteNonQuery();
                }
                finally
                {
                    conexao.Close();
                }


            }
        }
    }
}
