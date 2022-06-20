
using baytbank;


Cliente cliente1 = new();

ContaCorrente conta1 = new();


cliente1.titular = "Thiago ";
cliente1.cpf = "0068313033";

conta1.conta = "10203-x";
conta1.number_agencia = 23;
conta1.name_agencia = "Agencia FRG";
conta1.saldo = 10000;

ContaCorrente conta2 = new();
conta2.conta = "10302-x";
conta2.number_agencia = 23;
conta2.name_agencia = "Agencia FRG";
conta2.saldo = 1000;



Console.WriteLine("Seja Bem vindo ao BytBank");
Console.WriteLine("Qual conta você deseja informaçao");

Console.WriteLine("Digite o nome e sobre nome do titular da conta:");
string contaz = Console.ReadLine();

Console.WriteLine("---------------------------------------------------------------");

if (contaz == "Thiago Lemes" || contaz == "thiago lemes" || contaz == "Thiago lemes" || contaz == "thiago Lemes")
{
    
        Console.WriteLine("titular :" + cliente1.titular);
        Console.WriteLine("conta: " + conta1.conta);
        Console.WriteLine("numero da agencia: " + conta1.number_agencia);
        Console.WriteLine("nome da agencia: " + conta1.name_agencia);
        Console.WriteLine("saldo: " + conta1.saldo);
    
  
}
if (contaz == "Vitoria Lemes" || contaz == "vitoria lemes" || contaz == "Vitoria lemes" || contaz == "vitoria Lemes")
{

    Console.WriteLine($"conta: {conta2.conta} ");
    Console.WriteLine($"numero da agencia: {conta2.number_agencia}");
    Console.WriteLine($"nome da agencia: {conta2.name_agencia} ");
    Console.WriteLine($"saldo: {conta2.saldo}");

}









Console.ReadKey();
