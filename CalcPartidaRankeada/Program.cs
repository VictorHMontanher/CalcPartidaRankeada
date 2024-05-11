using System;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {
            saldoRank();

        }

        public static void saldoRank() {
            string rank;
            int saldo;

            Console.WriteLine("Insira o número de Vitórias: ");
            int vitoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de Derrotas: ");
            int derrota = int.Parse(Console.ReadLine());

            saldo = vitoria - derrota;

            if (saldo < 10) {
                rank = "Ferro";
            } else if (saldo > 11 && saldo < 20) {
                rank = "Bronze";
            } else if (saldo > 21 && saldo < 50) {
                rank = "Prata";
            } else if (saldo > 51 && saldo < 80) {
                rank = "Ouro";
            } else if (saldo > 81 && saldo < 90) {
                rank = "Diamante";
            } else if (saldo > 91 && saldo < 100) {
                rank = "Lendário";
            } else {
                rank = "Imortal";
            }

            Console.WriteLine("O Herói tem saldo de " + saldo + " está no nível de " + rank);
        }


    }
}