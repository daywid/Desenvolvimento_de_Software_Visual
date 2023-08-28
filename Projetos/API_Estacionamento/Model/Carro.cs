public class Carro
{
    private string _placa;
    private string _descricao;
    public Carro()
    {
        _placa = string.Empty;
        _descricao = string.Empty;
    }

    public Carro(string placa, string descricao)
    {
        _placa = placa;
        _descricao = descricao;
    }
}