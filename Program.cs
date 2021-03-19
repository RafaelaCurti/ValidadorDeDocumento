using Caelum.Stella.CSharp.Format;
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

            var CPF = new CPFFormatter().Format(getCPF);

            //Boolean
            if (new CPFValidator().IsValid(CPF))
                Console.WriteLine($"CPF válido: {CPF}");
            else
                Console.WriteLine($"CPF inválido: {CPF}");


            //Int e usando o CPF sem ser formatado
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

            var CNPJ = new CPFFormatter().Format(getCNPJ);
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

        private static void TituloEleitoral()
        {
            Console.WriteLine("Olá, digite o número do Título Eleitoral que deseja validar: ");
            var getTE = Console.ReadLine();
            Console.ReadKey();
            var TE = new TituloEleitoralFormatter().Format(getTE);

            //Boolean
            if (new TituloEleitoralValidator().IsValid(TE))
                Console.WriteLine($"Número do Título Eleitoral é válido: {TE}");
            else
                Console.WriteLine($"Número do Título Eleitoral é {TE}");
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
        }
    }
}
