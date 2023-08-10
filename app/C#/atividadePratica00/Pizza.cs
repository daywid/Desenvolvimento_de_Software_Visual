public class Pizza
{
    private List<Complemento> _complementos;

     public Pizza()
    {
        _complementos = new List<Complemento>(); // Inicializa a lista no construtor
    }
    
    public enum CategoriaPizza
    {
        Calabresa,
        Margherita,
        QuatroQueijos,
        FrangoComCatupiry,
        Vegetariana,
        Portuguesa,
        Especial
    }
    public enum SaborPizza
    {
        Calabresa,
        Mussarela,
        Pepperoni,
        FrangoComCatupiry,
        Margherita,
        Portuguesa,
        Vegetariana,
        QuatroQueijos,
        Bacon,
        Camarao
    }
    public enum TamanhoPizza
    {
        Pequeno,
        Médio,
        Grande,
        Família
    }

}