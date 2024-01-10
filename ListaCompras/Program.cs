Console.WriteLine("Bem vinda(o), a sua Lista de comprar");
Console.WriteLine("Por gentileza, digite seu nome:");
var nome = Console.ReadLine();


Console.WriteLine("Seja bem vindo a sua Lista de compras");
Console.WriteLine(nome);

Console.WriteLine("Vamos começar a adicionar itens a sua lista:");

List<string> listaCompra = new List<string>();

while(true)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1. Adicionar item a lista");
    Console.WriteLine("2. Exibir lista de compras");
    Console.WriteLine("3. Sair");

     string solicitacao = Console.ReadLine();

      switch (solicitacao)
      {
        case "1":
            Console.Write("Digite o item a ser adicionado: ");
            string novoItem = Console.ReadLine();
            listaCompra.Add(novoItem);
            Console.WriteLine("Item adicionado à lista!");
            break;
        case "2":
            Console.WriteLine(nome);
            Console.WriteLine("\n Sua Lista de Compras:");
            foreach (string item in listaCompra)
            {
                Console.WriteLine("- " + item);
            }
            break;
        case "3":
            Console.WriteLine("Saindo da sua lista de compras. Até logo!");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
      }
}