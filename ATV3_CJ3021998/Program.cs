
using System.ComponentModel.Design;

float nt;

Console.WriteLine("Dê um valor para a nota de certo aluno");
nt = float.Parse(Console.ReadLine());
if (nt >= 6) {
    Console.WriteLine("O aluno está aprovado");
}
else
{
    Console.WriteLine("O aluno está reprovado");
}