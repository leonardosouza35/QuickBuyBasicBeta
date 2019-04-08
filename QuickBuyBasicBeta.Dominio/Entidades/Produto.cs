namespace QuickBuyBasicBeta.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public decimal Valor { get; set; }
    }
}
