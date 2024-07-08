int[] iventory = {200, 450, 700, 175,250};
/// <summary>
/// Variavel pra fazer a soma
/// </summary>
int sum = 0;
/// <summary>
/// para armazenar o número do compartimento que tem um estoque sendo processado no momento
/// </summary>
int bin = 0; 


/// <summary>
/// A intrução foreach atribui temporariamente o valor do elemento da matriz atual a uma variavel int chamada items.
/// </summary>
foreach (int items in iventory)
{
    sum += items;
    /// <summary>
    /// esse é um atalho para bin = bin + 1;
    /// </summary>
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");