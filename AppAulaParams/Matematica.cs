using System;

namespace AppAulaParams
{
    internal class Matematica
    {
        public void Multiplicar (int a, int b, out int c)
        {
            c = a * b;

        }
        public void MultiplicarESomar(int a, int b, out int rm, out int rs)
        {
            rm = a * b;
            rs = a + b;
        }
        public double Elevar (double n, double pot=2)
        {
            return Math.Pow(n, pot);

        }
    }
}