/*
    O termo "espaço em branco" refere-se a espaços individuais produzidos pelo space bar, guias produzidas pela tecla tab e novas linhas produzidas pela tecla enter.

    O compilador C# ignora o espaço em branco. Para entender que os espaços em branco são ignorados e como podem melhorar a clareza do código, faça o exercício a seguir.

    OBS:
    - Cada comando completo (uma instrução) pertence a uma linha separada.
    - Se uma única linha de código se tornar longa, você poderá dividi-la. No entanto, você deve evitar dividir uma única instrução arbitrariamente em várias linhas até ter um bom motivo para fazer isso.
    - Use um espaço à esquerda e à direita do operador de atribuição.
*/

//Exemplo 1:

Console
.
WriteLine
(
    "Hello Exemple 1!"
)
;

//Exemplo 2:
string firsWord="Hello";string lastWord="Example 2";Console.WriteLine(firsWord+" "+lastWord+"!");


/*
-----------------------------------------------------------------
*/

//  Codigo sem espaço

/*
Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)){
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

*/

//  Codigo com espaço vertical

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)){
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

//  Codigo com espaço vertical
/*
Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)){
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
*/

//  Codigo com espaço horizontal.

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}