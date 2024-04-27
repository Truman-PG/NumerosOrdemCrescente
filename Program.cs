//mensagem de saudação
Console.WriteLine("Olá, aproveite este programa!!!");

//Pergunta qual número a pessoa quer
Console.WriteLine("Qual número você deseja? (Apenas números positivos)");
int numero = int.Parse(Console.ReadLine());

//Limpa a tela depois que a pessoa escolher o número
Console.Clear();

//Cria o laço de 0 até o número escolhido
for (int numero2 = 0; numero2 <= numero; numero2++)
{
    //Mostra o número de 0 ate o número escolhido
    Console.Write($"{numero2} ");
}