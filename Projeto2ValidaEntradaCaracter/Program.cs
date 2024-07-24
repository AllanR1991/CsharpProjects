string[] roles = { "Administrator", "Manager", "User"};

Console.WriteLine( "Enter your role name ( Administrator, Manager, or User ) : " );

string? resultRead;
bool verificResult;

do{
    resultRead = Console.ReadLine().Trim().ToLower();
    foreach (role in roles)
    {
        if ( resultRead == role
    }    
    
} while ( resultRead != "Administrator" );

