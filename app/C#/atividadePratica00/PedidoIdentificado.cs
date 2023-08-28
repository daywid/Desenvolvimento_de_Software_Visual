public class PedidoIdentificado : Pedido //Extends
{
    private Cliente _cliente;

    public Cliente cliente
    {
        get { return _cliente; } 
        set { _cliente = value; }
    }
}
