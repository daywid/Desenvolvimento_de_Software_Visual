namespace atividadePratica00
{

public class Cliente
{   
    //Classes nome e cpf
    private string _nome;
    private int _cpf;
        

    public int GetCpf()
    {
        return _cpf;
    }
    public int SetCpf(int cpf)
    {
        _cpf = cpf;
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
}