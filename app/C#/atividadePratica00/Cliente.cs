public class Cliente
{   
    //Classes nome e cpf
    private string _nome;
    private string _cpf;
    public static List<Cliente> clientes = new();
 
    public Cliente()
    {
        _cpf = "";
        _nome= "";

    }

    public Cliente(string cpf)
    {
        Cliente cli = Cliente.clientes.Find(x => x.Cpf == Cpf);
        if(cli == null)
        {
            _cpf = string.Empty;
            _nome = string.Empty;
        }
        else
        {
            _cpf = cli.Cpf;
            _nome = cli.nome;
        }
    }

    public Cliente(string cpf, string nome)
    {
        _cpf = cpf;
        _nome = nome;
    }


    public string Cpf
    {
         get {return _cpf;}
         set {_cpf = value;}
    }

    public string nome 
    {
        get => _nome;
        set => _nome = value;
    }



    // COLOCAR OS METODOS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



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
