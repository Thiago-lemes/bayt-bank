
using baytbank;



ContaCorrente conta1 = new();

conta1.titular = "Thiago Lemes";
conta1.conta = "10203-x";
conta1.number_agencia = 23;
conta1.name_agencia = "Agencia FRG";
conta1.saldo = 10000;

ContaCorrente conta2 = new();
conta2.titular = "Vitoria Lemes";
conta2.conta = "10302-x";
conta2.number_agencia = 23;
conta2.name_agencia = "Agencia FRG";
conta2.saldo = 1000;


Console.WriteLine("Seja Bem vindo ao BytBank");
Console.WriteLine("Qual conta você deseja informaçao");
string contaz = Console.ReadLine();
if (contaz == "Thiago Lemes")
{
    Console.WriteLine("titular :" + conta1.titular);
    Console.WriteLine("conta: " + conta1.conta);
    Console.WriteLine("numero da agencia: " + conta1.number_agencia);
    Console.WriteLine("nome da agencia: " + conta1.name_agencia);
    Console.WriteLine("saldo: " + conta1.saldo);
}
if (contaz == "Vitoria Lemes")
{

    Console.WriteLine($"titular :{conta2.titular}");
    Console.WriteLine($"conta: {conta2.conta} ");
    Console.WriteLine($"numero da agencia: {conta2.number_agencia}");
    Console.WriteLine($"nome da agencia: {conta2.name_agencia} ");
    Console.WriteLine($"saldo: {conta2.saldo}");

}
else
{
    Console.WriteLine("Usuario não encontrado");
}
    



//Console.WriteLine($"Saldo de thiago pre-transferencia{conta1.saldo}");

//Console.WriteLine($"Saldo da conta de vitoria pre transferencia {conta2.saldo}");

//conta1.Trasnferir(50, conta2);

//Console.WriteLine("---------------------------------------------------------------");

//Console.WriteLine($"Saldo da conta de Thiago pós transferencia {conta1.saldo}");
//Console.WriteLine($"Saldo da conta de vitoria pós transferencia {conta2.saldo}");


Console.ReadKey();
