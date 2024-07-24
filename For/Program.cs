// Contagem progressivamente
for ( int i = 0 ; i < 10 ; i++)
{
    Console.WriteLine( i );
}

// Contagem Regressivamente
for ( int i = 10 ; i > 0 ; i--)
{
    Console.WriteLine( i );
}

// Ignaorando determinados valores no iterador
for ( int i = 0 ; i < 10 ; i += 3)
{
    Console.WriteLine( i );
}

// interropendo a execução com break
for ( int i = 0 ; i < 10 ; i++)
{
    Console.WriteLine( i );
    if ( i == 7 ) break;
}

// Iterando sobre uma matriz

string[] names = { "Alex", "Eddie", "David", "Michael" };
for ( int i = names.Length - 1 ; i >= 0 ; i-- )
{
    Console.WriteLine(names[i]);
}

// foreach ( var name in names)
// {
//     // Can't do this:
//     if ( name == "David" ) name = "Sammy";
// }

for ( int i = 0; i < names.Length; i++ )
    if(names[i] == "David") names[i] = "Sammy";

foreach ( var name in names) Console.WriteLine(name);