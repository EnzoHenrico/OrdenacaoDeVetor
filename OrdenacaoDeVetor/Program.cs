int[] numbers = new int[5], sorted = new int[5];
int indexOfMinimum = 0, temp = 0;

Console.WriteLine("Crie um vetor para ser ordenado: \n");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Numero {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

sorted = numbers;

// Ordenação utilizando selection sort
for (int i = 0; i < 5; i++)
{
    // Procurar o menor relativo ao primeiro item não ordenado   
    indexOfMinimum = i;

    // Iterar sob todos elementos procurando o index do número de menor valor
    for (int j = i; j < 5; j++)
    {
        if (sorted[j] < sorted[indexOfMinimum])
        {
            indexOfMinimum = j;
        }
    }
    // Trocar o item do index atual com o de menor valor
    temp = sorted[i];
    sorted[i] = sorted[indexOfMinimum];
    sorted[indexOfMinimum] = temp;
    
}

Console.Write("\n\nVetor ordenado:");
for (int i = 0; i < 5; i++)
{
    Console.Write(" " + sorted[i]);
}