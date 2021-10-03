using System;
using System.Collections.Generic;

namespace Desafio_04
{
    class Program
    {
        public class Aluno//criar classe Aluno
        {
            public string nome { get; set; }//com método get e set
            public int id { get; set; }
            public int dataNasc { get; set; }

        }
        static void Main(string[] args)
        {
            int qntd, count=0;
            Console.WriteLine("Array Padrao!Digite quantos quer cadastrar");//com Array Padrão
            qntd = int.Parse(Console.ReadLine());
            string[] alunoNome = new string[qntd];//criando array padrão
            while(count < qntd)//estrutura de repetição para usar Array Padrão
            {
                Console.WriteLine("insira o nome");
                alunoNome[count] = Console.ReadLine();
                count++;
            }
            Console.WriteLine("exibindo alunos salvos em array padrão");
            count = 0;
            while (count < qntd)//estrutura de repetição para exibir Array Padrão
            {
                Console.WriteLine(alunoNome[count]);
                count++;
            }

            Console.WriteLine("Cadastro aluno com lista, digite nome,id e dataNasc");//Usando object List
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno() { nome = "rodrigo", id = 1, dataNasc = 02101990 });//para salvar na lista

            alunos.Add(new Aluno() { nome = Console.ReadLine(), id = int.Parse(Console.ReadLine()), dataNasc = int.Parse(Console.ReadLine())});

            Console.WriteLine(alunos[0].nome+alunos[0].id.ToString()+alunos[0].dataNasc.ToString());//exibir lista salva
            Console.WriteLine(alunos[1].nome+alunos[1].id.ToString()+alunos[1].dataNasc.ToString());//exibir lista salva

            Aluno escola1 = new Aluno();

            alunos.Add(escola1);//adiciona um objeto na lista
        }
    }
}
