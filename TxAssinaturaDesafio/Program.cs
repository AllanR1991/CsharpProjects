Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//Crie uma instrução if-else que exibe uma mensagem sobre quando a assinatura expirará
//Crie uma instrução if separada que exiba uma oferta de desconto.

Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10) 
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else 
{
    Console.WriteLine("Your subscription has expired.");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
