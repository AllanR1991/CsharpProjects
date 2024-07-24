Console.WriteLine( "Enter an interger value between 5 and 10: " );

string? readResult;
int numericValue;
bool validNumber;
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse( readResult, out numericValue);
    if ( validNumber )
    {
        if ( numericValue >= 5 && numericValue <= 10 )
        {
            Console.WriteLine( $"Your input value ({numericValue}) has been accepted." );
        }
        else 
        {
            Console.WriteLine( $"You entered {numericValue}, Please enter a number between 5 and 10: " );
        }        
    }
    else
    {
        Console.WriteLine( $"Sorry, you entered an invalid number, please try again: " );
    }

} while ( numericValue < 5  || numericValue > 10 );