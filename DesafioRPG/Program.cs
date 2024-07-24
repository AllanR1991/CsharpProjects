Random dice = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;
string turn ="Hero";

do
{
    if (turn == "Hero")
    {
        damage = dice.Next(1, 11);
        monsterHealth -= damage;
        Console.WriteLine( $"Monster was damaged and lost {damage} health and now has {monsterHealth} health." );
        turn = "Monster";
    }
    else
    {
        damage = dice.Next(1, 11);
        heroHealth -= damage;
        Console.WriteLine( $"Hero was damaged and lost {damage} health and now has {heroHealth} health." ) ;
        turn = "Hero";
    }

}while( monsterHealth > 0 && heroHealth > 0 );


Console.WriteLine( monsterHealth <= 0 ? "Hero Wins!" : "Monster Wins!" );

// if (monsterHealth <= 0)
// {
//     Console.WriteLine( "Hero Wins!" );
// }
// else
// {
//     Console.WriteLine( "Monster Wins!" );
// }