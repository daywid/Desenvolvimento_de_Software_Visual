using System.Globalization;
    
static void TesteCliente()
{
    PedidoIdentificado p =new();
    p.Id = 1;
}




  Cliente c = new();

for (int i=0;i<3;i++)
{
    c = new();
    Console.Write("CPF:");
    c.Cpf = Console.ReadLine();
    Console.Write("nome:");
    c.nome = Console.ReadLine();
    Cliente.clientes.Add(c);


}
Console.WriteLine("Os itens inseridos foram:");
Console.WriteLine("Listando com foreach:");
foreach(Cliente cli in Cliente.clientes)  
{
        Console.WriteLine("CPF: " + cli.Cpf);
        Console.WriteLine("Nome: " + cli.nome);
}
    
Console.WriteLine("Os itens inseridos foram:");
Console.WriteLine("Listando com for:");
for(int i=0;i<Cliente.clientes.Count;i++)  
{
        Console.WriteLine("CPF: " + Cliente.clientes[i].Cpf);
        Console.WriteLine("Nome: " + Cliente.clientes[i].nome);
}
    


