// "?" -> permite nulo na variável.
// é prática comum utilizar uma cadeia de caracteres do tipo anulável (designada string?) para a variável de entrada 

// Exemplo 1
// string? readResult;

// Console.WriteLine("Enter a string:");

// do
// {
//     readResult = Console.ReadLine();
// }while ( readResult == null );

// Exemplo 2
// string? readResult;
// bool validEntry = false;
// Console.WriteLine( $"Enter a string containing a least three characters:" );
// do{
//     readResult = Console.ReadLine();
//     if ( readResult != null )
//     {
//         if ( readResult.Length >= 3 )
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine( "Your input is invalid, please try again." );
//         }
//     }
// } while ( validEntry == false );


//  converter o valor da cadeia de caracteres para um tipo numérico.

string? readResult;

Console.WriteLine( "Digite o Numero: " );
readResult = Console.ReadLine();

int numericValue = 0;
bool validNumber = false;

// TryParse -> retorna uma valor booleano;
// Out -> Retorna valor 0 caso TryParse falhe.
validNumber = int.TryParse(readResult, out numericValue);

if (validNumber)
{
    Console.WriteLine(numericValue);
}
else
{
    Console.WriteLine("o dado inserido não é valido.");
}