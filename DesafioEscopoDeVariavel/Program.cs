//  Neste desafio, você usará o que aprendeu sobre blocos de código e escopo de variável para corrigir o exemplo de código mal escrito fornecido. Há muitas melhorias que você pode fazer. Boa sorte!

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");


// ***********************************************************

// Corrigido

int[] numbers = { 4, 8, 15, 16, 23, 42 };
// numbers = new int[] { 0, 2, 3 }; reatibuindo valores a uma matriz
int total = 0 ;
bool found = false;


foreach ( int number in numbers )
{
    total += number;
    
    if ( number == 42 )
    {
        found = true;
    }

}

if ( found )
    Console.WriteLine( "Set contains 42" );

Console.WriteLine( $"Total: {total}");  
