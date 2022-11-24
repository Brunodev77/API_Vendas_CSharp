using Dapper.Contrib.Extensions;

namespace VendasApi.Models
{
    [Table("vendas_produtos")]
    public class Vendas_produtos
    {
        public int Id_Venda { get; set; }
        public int Id_produto { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double Valor_final { get; set; }
        public int Criado_por_usd_id { get; set; }
        public Boolean Ind_ativo { get; set; }
    }
}
