int temp = 0, size = 100;
int[] numbers = new int[size], sorted = new int[size];

Console.WriteLine("Crie um vetor para ser ordenado:");

for (int i = 0; i < size; i++)
{
    Console.Write($"Numero {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
    sorted[i] = numbers[i];
}

// Ordenação utilizando bubble sort
for (int i = 0; i < size - 1; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        if (sorted[i] > sorted[j])
        {
            temp = sorted[i];
            sorted[i] = sorted[j];
            sorted[j] = temp;
        }
    }
}

Console.Write("\n\nVetor original:");
for (int i = 0; i < size; i++)
{
    Console.Write(" " + numbers[i]);
}

Console.Write("\n\nVetor ordenado:");
for (int i = 0; i < size; i++)
{
    Console.Write(" " + sorted[i]);
}

Console.WriteLine();