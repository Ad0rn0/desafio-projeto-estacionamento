using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto_fundamentos.Models
{
    public class Estacionamento
    {
        private double precoInicial;
        private double precoPorHora;
        private List<string> veiculos = [];

        public Estacionamento(double precoInicial, double precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public bool AdicionarVeiculo(string placa)
        {
            if (veiculos.Contains(placa))
            {
                return false;
            }
            else
            {
                veiculos.Add(placa);
                return true;
            }
        }

        public bool RemoverVeiculo(string placa)
        {
            if (!veiculos.Contains(placa))
            {
                return false;
            }
            else
            {
                veiculos.Remove(placa);
                return true;
            }
        }
        public void ListarVeiculos()
        {
            /* foreach(string placas in veiculos)
            {
                Console.WriteLine($"\n{placas}");
            } */

            for (int i = 0; i < veiculos.Count(); i++) // Resolvi usar for para listar os carros, fica melhor para o usuário
            {
                Console.WriteLine($"{i+1} - {veiculos[i]}");
            }
        }
    }
}