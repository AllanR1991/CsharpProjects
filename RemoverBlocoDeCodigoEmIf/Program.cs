// Exemplo 1
// bool flag = true;
// if ( flag )
// {
//     Console.WriteLine( flag );
// }

// Exemplo 2
// Se o bloco de código precisar de apenas uma linha, é provável que você não precise definir um bloco formal usando chaves.
// bool flag = true;
// if ( flag )
//     Console.WriteLine( flag );


// Exemplo 3 (Examinar a legibilidade de instruções if com apenas uma linha)

bool flag = true;
if ( flag ) Console.WriteLine( flag ); // Nunca usar essa forma quando tiver uma unica instrução.

// Falta de legibilidade

// string name = "steve";
// if ( name == "bob" ) Console.WriteLine( "Found Bob" );
// else if ( name == "steve" ) Console.WriteLine( "Found Steve" );
// else Console.WriteLine( "Found Chuck" );

// Legibilidade do codigo acima.

string name = "steve";

if ( name == "bob" ) 
    Console.WriteLine( "Found Bob" );
else if ( name == "steve" ) 
    Console.WriteLine( "Found Steve" );
else 
    Console.WriteLine( "Found Chuck" );

