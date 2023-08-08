public class Cliente
{
    // Campos (variáveis) da classe
    private int meuCampoInteiro;
    public string meuCampoString;

    // Construtor da classe
    public MinhaClasse()
    {
        // Inicialização de campos no construtor, se necessário
        meuCampoInteiro = 0;
        meuCampoString = "Valor inicial";
    }

    // Métodos da classe
    public void MeuMetodo()
    {
        Console.WriteLine("Este é um método da MinhaClasse.");
    }
}
