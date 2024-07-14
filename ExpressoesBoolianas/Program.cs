/*
    Este app é para aprendizagem sobre expressoes boolianas.

    Antes de marcar dois valores de cadeia de caracteres para igualdade, especialmente quando um ou ambos os valores foram inseridos por um usuário, você deve:

    -   Verificar se ambas as cadeias de caracteres são todas maiúsculas ou minúsculas usando o método auxiliar ToUpper() ou ToLower() em qualquer valor de cadeia de caracteres.
    -   Remover qualquer espaço em branco à esquerda ou à direita usando o método auxiliar Trim() em qualquer valor de cadeia de caracteres.
*/

Console.Clear();

//  ------------------ Igualdade ------------------

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//  ------------------ Desigualdade ------------------

// Console.WriteLine( "a" != "a" );
// Console.WriteLine( "a" != "A" );
// Console.WriteLine( 1 != 2 );

// string myValue = "a";
// Console.WriteLine( myValue != "a");

// Ao trabalhar com tipos de dados numéricos, convém determinar se um valor é maior ou menor que outro valor. Use os operadores a seguir para executar esses tipos de comparações:
// Maior que >
// Menor que <
// Maior que ou igual a >=
// Menor ou igual a <=
// Naturalmente, os operadores == e != usados para comparar valores de cadeia de caracteres acima também funcionarão ao comparar tipos de dados numéricos.

//  ------------------ Operadores de comparação ------------------

// Console.WriteLine( 1 > 2 );
// Console.WriteLine( 1 < 2 );
// Console.WriteLine( 1 >= 1);
// Console.WriteLine( 1 <= 1);

//  ------------------ Método que retorna um booliano ------------------

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

//  ------------------ Negação lógica ------------------

Console.WriteLine( pangram.Contains("fox") == false ) ;
Console.WriteLine( !pangram.Contains("fox"));