
for ( int i = 1; i <= 100; i ++){
    bool divisivelPorCinco = i % 5 == 0;
    bool divisivelPorTres = i % 3 == 0;

    if ( divisivelPorTres && divisivelPorCinco ) Console.WriteLine($"{i} - FizzBuzz");
    else if ( divisivelPorTres ) Console.WriteLine($"{i} - Fizz");
    else if ( divisivelPorCinco ) Console.WriteLine($"{i} - Buzz");
    else Console.WriteLine($"{i}");
}