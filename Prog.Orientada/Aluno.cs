using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Orientada
{
    public class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;

        public void ExibirInformações()
        {
            Console.WriteLine($"Nome do Aluno: {nome} | Notas: {nota1} e {nota2}");
        }
        public double CalcularMedia()
        {
            return (nota1 + nota2) / 2;
            
        }
        
    }
}