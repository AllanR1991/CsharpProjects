/*
projeto original para refatorar com espaçamentos adequados.

string str = "The quick brown fox jumps over the lazy dog.";
// Convert the message into a char array
char[] charMessage = str.ToCharArray();
//  Reverse the chars
Array.Reverse(charMessage);
int x = 0;
//  count the o's
foreach (char i in charMessage){ if (i == 'o') { x++;}}
// convert it back to a string
string new_message = new string(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

//  Response

// Convert the message into a char array
//  Reverse the chars
//  count the o's
// convert it back to a string
// print it out

/*
    Este programa é para converter a mensagem em char e inverter a menssagem , informando a quantidade de vezes que um caracter é exibido na menssagem.
*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage)
{ 
    if (letter == 'o') 
    { 
        letterCount++;
    }
}

string new_message = new String(charMessage);
Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {letterCount} times.");