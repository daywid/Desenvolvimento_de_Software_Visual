public class Acompanhamento{ 

    private String _descricao;
    private int _tamanho;

    // Enumerador para os tipos de acompanhamento
    public enum TipoAcompanhamento
    {
        Normal,
        Expresso,
        Prioritario
    }

    public String descricao
    {
        get { return _descricao;}
        set { _descricao = value;}
    }

    public int tamanho 
    {
        get { return _tamanho;} 
        set { _tamanho = value;}
    }
}