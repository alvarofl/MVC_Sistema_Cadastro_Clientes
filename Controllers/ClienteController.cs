using MVC_Cadastro_Clientes.Models;
using MVC_Cadastro_Clientes.Views;

namespace MVC_Cadastro_Clientes.Controllers
{
    public class ClienteController
    {
        Cliente cliente = new Cliente();

        ClienteView clienteView = new ClienteView();

        public void ListarProdutos() {
            clienteView.Listar(cliente.Ler());
        }

        public void Cadastrar() {
            cliente.Inserir(clienteView.CadastrarProduto());
        }
    }
}