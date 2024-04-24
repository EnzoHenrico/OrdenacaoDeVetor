int aux = 0, tamanho = 10, tamanhoAtual = tamanho;
int[] original = new int[tamanho], ordenado = new int[tamanho], invertido = new int[tamanho];

Console.WriteLine("Crie um vetor para ser ordenado:");
for (int i = 0; i < tamanho; i++)
{
    original[i] = new Random().Next(0,tamanho);
    ordenado[i] = original[i];
}
 
// Ordena e retira números repetidos
for (int i = 0; i < tamanhoAtual - 1; i++)
{
    for (int j = i + 1; j < tamanhoAtual;  j++)
    {
        // Trata numeros repetidos
        if (ordenado[i] == ordenado[j])
        {
            while (ordenado[i] == ordenado[j])
            {
                // Troca a replica pelo último item do vetor
                ordenado[j] = ordenado[tamanhoAtual - 1];
                ordenado[tamanhoAtual - 1] = 0;
                
                // Salva o novo tamanho do vetor
                tamanhoAtual--;
            }
        }
        else if (ordenado[i] > ordenado[j])
        {
            aux = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = aux;
        }
    }
}

// Declara os valores inversos
for (int i = 0; i < tamanhoAtual; i++)
{
    invertido[(tamanhoAtual - 1) - i] = ordenado[i];
}

// Outputs
Console.Write("\n\nVetor original:");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(" " + original[i]);
}

Console.Write("\n\nVetor ordenado:");
for (int i = 0; i < tamanhoAtual; i++)
{
    Console.Write(" " + ordenado[i]);
}

Console.Write("\n\nVetor invertido:");
for (int i = 0; i < tamanhoAtual; i++)
{  
    Console.Write(" " + invertido[i]);   
}

Console.WriteLine();