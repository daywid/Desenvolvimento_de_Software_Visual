using System.Collections.Generic; // Importante para usar List<T>
public class Pedido
{

    private int _id;
    private List<ItemPedido> _itens;
    // private ItemPedido ArrayList;

    public Pedido()
    {
        _itens = new List<ItemPedido>(); // Inicializa a lista no construtor
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }




}