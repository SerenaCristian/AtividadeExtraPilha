using System;

namespace AtividadePilha
{
    class Program
    {
        static string[] pilha = new string[10];
        static int topo = -1;

        static void Main(string[] args)
        {
            Push("Naruto Uzumaki");
            Push("Monkey D. Luffy");
            Push("Goku");
            Push("Ichigo Kurosaki");
            Push("Gon Freecss");
            Push("Deku (Izuku Midoriya)");
            Push("Yusuke Urameshi");
            Push("Tanjiro Kamado");
            Push("Jotaro Kujo");
            Push("Light Yagami");

            Push("Outro Personagem");

            Pop();

            ImprimePilha();
        }

        public static bool IsFull()
        {
            return topo == pilha.Length - 1;
        }

        public static void Push(string valor)
        {
            if (IsFull())
            {
                Console.WriteLine("A pilha está cheia.");
            }
            else
            {
                pilha[++topo] = valor;
                Console.WriteLine($"Valor '{valor}' adicionado à pilha.");
            }
        }

        public static string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("A pilha está vazia.");
                return null;
            }
            else
            {
                string valorRemovido = pilha[topo];
                pilha[topo--] = null;
                Console.WriteLine($"Valor '{valorRemovido}' removido da pilha.");
                return valorRemovido;
            }
        }

        public static bool IsEmpty()
        {
            return topo == -1;
        }

        public static void ImprimePilha()
        {
            if (IsEmpty())
            {
                Console.WriteLine("A pilha está vazia.");
            }
            else
            {
                Console.WriteLine("Conteúdo da pilha:");
                for (int i = topo; i >= 0; i--)
                {
                    Console.WriteLine(pilha[i]);
                }
            }
        }
    }
}

