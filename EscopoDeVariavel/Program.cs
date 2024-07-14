//Exemplo 1


// bool flag = true;

// if ( flag )
// {
//     int value = 10;
//     Console.WriteLine( $"Inside the code block: {value}" );
// }

// Console.WriteLine( $"Outside the code block: {value}" );

/*
    Esse erro é gerado porque uma variável que é declarada em um bloco de código só é acessível (pode ser vista apenas) dentro desse bloco de código. Como uma variável não pode ser acessada fora do bloco de código no qual é declarada, value não pode ser acessado da linha 7 do código.
*/

// Exemplo 2


// bool flag = true;
// int value;

// if ( flag )
// {
//     Console.WriteLine( $"Inside the code block: {value}" );
// }
// value = 10;
// Console.WriteLine( $"Outside the code block: {value}" );

/*
    Erro devido a variavel value nao ter sido inicializada antes do if
*/


// Exemplo 3


bool flag = true;
int value = 0;

if ( flag )
{
    Console.WriteLine( $"Inside the code block: {value}" );
}
value = 10;
Console.WriteLine( $"Outside the code block: {value}" );