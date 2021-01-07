using System;
using System.Collections.Generic;
using System.Diagnostics;
using MVC_Cadastro_Clientes.Models;
namespace MVC_Cadastro_Clientes.Views
{
    public class ClienteView
    {
        public void Listar(List<Cliente> clientes) {

            foreach (var item in clientes)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Data Nascimento: {item.DataNascimento}");
                Console.WriteLine($"Sexo: {item.Sexo}");
                Console.WriteLine($"Telefone: {item.Telefone}");
                Console.WriteLine($"RG: {item.RG}");
                Console.WriteLine($"CPF: {item.CPF}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine();
            }
        }
        
        public Cliente CadastrarProduto() {
            Cliente cliente = new Cliente();

            Console.WriteLine($"Digite um nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine($"Digite sua data de nascimento: ");
            cliente.DataNascimento = Console.ReadLine();

            Console.WriteLine($"Digite o seu sexo: ");
            cliente.Sexo = Console.ReadLine();

            Console.WriteLine($"Digite seu telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine($"Digite seu RG: ");
            cliente.RG = Console.ReadLine();

            Console.WriteLine($"Digite seu CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine($"Digite seu email: ");
            cliente.Email = Console.ReadLine();
           
            return cliente;
        }

}

}