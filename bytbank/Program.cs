
using baytbank;

Console.WriteLine("Seja Bem vindo ao BytBank");

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


//Console.WriteLine("Titular :" + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero da Agencia: " + conta1.number_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.name_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//Console.WriteLine("---------------------------------------------------------------");


//Console.WriteLine($"Titular :{conta2.titular}");
//Console.WriteLine($"Conta: {conta2.conta} ");
//Console.WriteLine($"Numero da agencia: {conta2.number_agencia}");
//Console.WriteLine($"Nome da agencia: {conta2.name_agencia} ");
//Console.WriteLine($"Saldo: {conta2.saldo}");

Console.WriteLine($"saldo da vitoria{conta2.saldo}");

 conta2.sacar(50);
Console.WriteLine($"Saldo atualizado da Vitoria é de:{conta2.saldo}");


Console.ReadKey();
