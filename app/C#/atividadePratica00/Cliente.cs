public class Cliente
{   
    //Classes nome e cpf
    private string _nome;
    private int _cpf;
    
    public int Cpf
    {
         get => _cpf;
         set => _cpf = value;
    }

    public String nome 
    {
        get => _nome;
        set => _nome = value;
    }



    // // Campos (variáveis) da classe
    // private int meuCampoInteiro;
    // public string meuCampoString;

    // // Construtor da classe
    // public MinhaClasse()
    // {
    //     // Inicialização de campos no construtor, se necessário
    //     meuCampoInteiro = 0;
    //     meuCampoString = "Valor inicial";
    // }

    // // Métodos da classe
    // public void MeuMetodo()
    // {
    //     Console.WriteLine("Este é um método da MinhaClasse.");
    // }
}
