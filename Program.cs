using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeDocumento
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF();
        }

        private static void CPF()
        {
            Console.WriteLine("Olá, digite o CPF que deseja validar: ");
            var getCPF = Console.ReadLine();
            Console.ReadKey();


            //Boolean
            if (new CPFValidator().IsValid(getCPF))
                Console.WriteLine($"CPF válido: {getCPF}");
            else
                Console.WriteLine($"CPF inválido: {getCPF}");


            //Int
            //try
            //{
            //new CPFValidator().AssertValid(getCPF);
            //    Console.WriteLine("CPF válido: " + getCPF);
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine($"CPF inválido: {getCPF}. {exc.Message}");
            //}
            Console.ReadKey();
        }
        private static void CNPJ()
        {
            Console.WriteLine("Olá, digite o CNPJ que deseja validar: ");
            var getCNPJ = Console.ReadLine();
            Console.ReadKey();


            //Boolean
            if (new CNPJValidator().IsValid(getCNPJ))
                Console.WriteLine($"CNPJ válido: {getCNPJ}");
            else
                Console.WriteLine($"CNPJ inválido: {getCNPJ}");


            //Int
            //try
            //{
            //new CNPJValidator().AssertValid(getCNPJ);
            //    Console.WriteLine("CPF válido: " + getCNPJ);
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine($"CPF inválido: {getCNPJ}. {exc.Message}");
            //}
            Console.ReadKey();
        }
<<<<<<<<< Temporary merge branch 1
    }
    private static void TituloEleitoral()
=========
        private static void TituloEleitoral()
>>>>>>>>> Temporary merge branch 2
        {
            Console.WriteLine("Olá, digite o número do Título Eleitoral que deseja validar: ");
            var getTE = Console.ReadLine();
            Console.ReadKey();

<<<<<<<<< Temporary merge branch 1
             
=========

>>>>>>>>> Temporary merge branch 2
            //Boolean
            if (new TituloEleitoralValidator().IsValid(getTE))
                Console.WriteLine($"Número do Título Eleitoral é válido: {getTE}");
            else
                Console.WriteLine($"Número do Título Eleitoral é" +
                    $" inválido: {getTE}");


<<<<<<<<< Temporary merge branch 1
        //Int
        //try
        //{
        //new TituloEleitoralValidator().AssertValid(getTE);
        //    Console.WriteLine($"Número do Título Eleitoral é válido: {getTE}");
        //}
        //catch (Exception exc)
        //{
        //    Console.WriteLine($"Número do Título Eleitoral é inválido: {getTE}. {exc.Message}");
        //}
        Console.ReadKey();
=========
            //Int
            //try
            //{
            //new TituloEleitoralValidator().AssertValid(getTE);
            //    Console.WriteLine($"Número do Título Eleitoral é válido: {getTE}");
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine($"Número do Título Eleitoral é inválido: {getTE}. {exc.Message}");
            //}
            Console.ReadKey();
>>>>>>>>> Temporary merge branch 2
        }
    }
}
