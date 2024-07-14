//  Exemplo 1


// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount : {discount}" );


// Exemplo 2

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount : {(saleAmount > 1000 ? 100 : 50)}" );
//  Observe que é necessário encapsular toda a instrução do operador condicional entre parênteses. Os parênteses garantem que o runtime entenda sua intenção, que é exibir o resultado condicional em vez do resultado da avaliação da condição (saleAmount > 1000).

//  Observação

//  Embora este exemplo específico seja compacto e mostre essa possibilidade, ele é um pouco mais difícil de ler. Nem sempre é uma boa ideia combinar linhas de código, especialmente quando afeta negativamente a legibilidade geral do código. Geralmente, essa é uma decisão subjetiva.
