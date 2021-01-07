using System.IO;
using System.Collections.Generic;

namespace MVC_Cadastro_Clientes.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public string Sexo { get; set; }
        
        public string Telefone { get; set; }
        
        public string RG { get; set; }
        
        public string CPF { get; set; }
        
        public string Email { get; set; }

        private const string PATH = "Database/Cliente.csv";

        public Cliente() {

            string pasta = PATH.Split("/")[0];

             if(!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH)) {
                File.Create(PATH);
            }
        }

        public List<Cliente> Ler() {

            List<Cliente> clientes = new List<Cliente>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas) {

                string[] atributos = item.Split(";");

                Cliente cli = new Cliente();
                cli.Nome = atributos[0];
                cli.DataNascimento = atributos[1];
                cli.Sexo = atributos[2];
                cli.Telefone = atributos[3];
                cli.RG = atributos[4];
                cli.CPF = atributos[5];
                cli.Email = atributos[6];

                clientes.Add(cli);
            }

            return clientes;
        }
        
        public void Inserir(Cliente cliente) {

            string[] linhas = {PrepararLinhasCSV(cliente)};

            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Cliente cli) {
            return $"{cli.Nome}, {cli.DataNascimento}, {cli.Sexo}, {cli.Telefone}, {cli.RG}, {cli.CPF}, {cli.Email}";
        }
        
        
    }
}