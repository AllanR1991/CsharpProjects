
/*
//Declarando uma matriz de cadeia de caracteres
string[] fraudulentOrderIDs = new string[3];
//A palavra new cria uma instancia de uma matriz na memoria do computador que pode conter tres valores.
//O conchetes string[] indica ao compilador que a variavel de nome fraudulentOrderIDs é uma matriz.
//O conchetes string[3] indica a o numero de elementos que a matriz contera.


//Atribuindo valores aos elementos de uma matriz
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/

//Inicializando uma matriz de cadeia de caracteres, para inicializar uma matriz é necessario utilizar das chaves;
string[] fraudulentOrderIDs = {"A123","B456","C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//Assim como as demais variaveis é possivel reatribuir valor a cada elemento da matriz
fraudulentOrderIDs[0]= "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Usando a propriedade Length da matriz, para obter o tamanho da matriz.
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
//a propriedade length retorna um inteiro informando o numero de elementos da matriz.


//EXEMPLO DE EXECULTAR UM LOOP EM UMA MATRIZ COM FOREACH
//Abaixo da palavra-chave foreach, o bloco de código que contém Console.WriteLine(name); será executado uma vez para cada elemento da matriz names. Como o runtime do .NET executa um loop em cada elemento da matriz, o valor armazenado no elemento atual da matriz names será atribuído à variável temporária name para facilitar o acesso dentro do bloco de código.
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }