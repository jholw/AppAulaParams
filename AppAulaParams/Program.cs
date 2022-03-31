using System;

namespace AppAulaParams
{
    class Program
    {
        static void Main()
        {
            //passando refencia com classe externa sobre parametros

            Matematica mat = new Matematica();

            int result = 1;
            mat.Multiplicar(10, 2, out result);
            Console.WriteLine("Paremetros por valor e referencia" +
                " Multiplicar informando a saida c OUT \n" + result + "\n");

            // resultados com multiplicaçao e soma na referencia com saida out
            int a = 10;
            int b = 2;
            int resutado;
            mat.Multiplicar(a, b, out resutado);
            int r1;
            int r2;
            mat.MultiplicarESomar(3, 6, out r1, out r2);
            Console.WriteLine("Resultado Parametro Multiplicar e Somar \n");
            Console.WriteLine("A multiplicação de A e B: "+r1 );
            Console.WriteLine("A soma de A e B: " + r2 + "\n");

            // Parametros Opcionais 

            // double pot = mat.Elevar(2, 3);
            //parametros opcionais podem ser passados ou não aqui e
            //quando não passado assume o valor definido como abaixo
            double pot = mat.Elevar(2);
            Console.WriteLine("Numero elevado é:" + pot+ "\n");


            // classe interna para passar parametros de copia e refernecia
            MyClass m = new MyClass();

            int i = 5;
            m.Trocar(ref i);
            Console.WriteLine("Paremetros por valor e referencia em MyClass");
            Console.WriteLine(i +"\n");


            // segunda classe em parametros

            Numero num = new Numero();
            num.n = 5;
            m.Mudar( num);
            Console.WriteLine("Paremetros por valor e referencia Classe Numero");
            Console.WriteLine(num.n); 
        }
    }

    class MyClass
    {
        //passagem por referencia
        public void Trocar(ref int x)
        {
            x = 10;
        }
        // passagem por copia
        public void Mudar( Numero x)
        {
            //x.n = 10;
            x = new Numero();
            x.n = 20;
        }
            }
    class Numero
    {
        public int n;

    }
}