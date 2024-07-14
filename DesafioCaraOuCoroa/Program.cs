/*
    Este projeto faz referencia a jogar uma moeda para o alto e dependendo da forma que a moeda cai exibe Head ou Tails.
*/

Random join = new Random();
string coinFace = join.Next(0,2)>0 ? "Head" : " Tails";
Console.WriteLine(coinFace);
