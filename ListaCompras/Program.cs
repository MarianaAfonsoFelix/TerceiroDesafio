Console.WriteLine("Bem vinda(o), a sua Lista de comprar");
Console.WriteLine("Por gentileza, digite seu nome:");
var nome = Console.ReadLine();


Console.WriteLine("Seja bem vindo a sua Lista de compras");
Console.WriteLine(nome);

Console.WriteLine("Vamos começar a adicionar itens a sua lista:");

List<string> listaCompra = new List<string>();

var continuidadeProcesso = 0;
Console.WriteLine("Digite o item a ser adicionado, ao finalizar digite N para encerrar:");

while(continuidadeProcesso == 0)
{
    
    var produto = "N";
    produto = Console.ReadLine();

    if(produto == "N")
        continuidadeProcesso = 1;
    else
        listaCompra.Add(produto);

}

Console.WriteLine(nome);
Console.WriteLine("Não esqueça de passar no mercado e comprar:");
foreach(var compra in listaCompra)
{
    Console.WriteLine(compra);
}

