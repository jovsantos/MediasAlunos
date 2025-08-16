using System;
using System.Security.Cryptography.X509Certificates;
using Prog.Orientada;

 public class Program
{
    static void Main()
    {
        Aluno[] sala = new Aluno[3];

              sala[0] = new Aluno();

        Console.Write("Digite o nome do aluno: ");
             sala[0].nome = Console.ReadLine();
        Console.Write("Digite a nota 1: ");
             sala[0].nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
             sala[0].nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        sala[1] = new Aluno();

        Console.Write("Digite o nome do aluno: ");
             sala[1].nome = Console.ReadLine();
        Console.Write("Digite a nota 1: ");
             sala[1].nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
             sala[1].nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        sala[2] = new Aluno();

        Console.Write("Digite o nome do aluno: ");
              sala[2].nome = Console.ReadLine();
        Console.Write("Digite a nota 1: ");
              sala[2].nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
              sala[2].nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Lista de Alunos: ");

        for (int i = 0; i < sala.Length; i++)
        {
            sala[i].ExibirInformações();
            double media = sala[i].CalcularMedia();
            Console.WriteLine($"Média: {media}");  
         
            if (media >= 6)
            {
                Console.WriteLine("Parabéns, você está APROVADO!"); 
            }
            else if (media >= 4)
            {
                Console.WriteLine("RECUPERAÇÃO, não desanime!");
            }
            else
            {
                Console.WriteLine("Infelizmente, você foi REPROVADO!");
            }
        }
    }  
}
