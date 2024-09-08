
using pooStudying;

try
{

    var account = new mySavings("Thalys F", 100);

    Console.WriteLine($"O saldo de {account.accOwner} é {account.accBalance}!");

    account.moneyInput(2000);

    Console.WriteLine($"O saldo de {account.accOwner} é {account.accBalance}!");

    account.moneyOutput(200);

    Console.WriteLine($"O saldo de {account.accOwner} é {account.accBalance}!");

    account.moneyOutput(3000);

    Console.WriteLine($"O saldo de {account.accOwner} é {account.accBalance}!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}