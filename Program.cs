using System;
using MVC_Cadastro_Clientes.Controllers;

namespace MVC_Cadastro_Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController cli = new ClienteController();
            cli.ListarProdutos();
            cli.Cadastrar();

        }
    }
}
