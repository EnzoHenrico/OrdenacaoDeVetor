int[] numbers = new int[5], sorted = new int[5];
int temp = 0, size = 5;

Console.WriteLine("Crie um vetor para ser ordenado: \n");

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

Console.Write("\n\nVetor ordenado:");
for (int i = 0; i < size; i++)
{
    Console.Write(" " + sorted[i]);
}