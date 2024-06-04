using System;
public class Questao5
{

    public void Preencher(int[] vetor)
    {
        Random n = new Random();
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = n.Next(11);
        }
    }

    public void Imprimir(int[] vetor)
    {
        for (int i = 0; i < 10; i++)
            Console.WriteLine("Vet[" + i + "]=" + vetor[i]);
    }

    public double CalculaMedia(int[] vetor)
    {
        double media = 0;
        double soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        media = soma / 10;
        return media;
    }
    public void Questao()
    {
        int[] vetor = new int[10];
        Preencher(vetor);
        Imprimir(vetor);

    }
}
