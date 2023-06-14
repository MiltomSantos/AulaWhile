static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Stella");
            nomes.Add("William");
            nomes.Add("Luis");
            nomes.Add("Miltom");
            nomes.Add("Leonardo");
            nomes.Add("Victor");

            int contador = 0;

            while (contador < nomes.Count)
            {
                Console.WriteLine("O nome é: "+nomes[contador]);
                contador++;
            }

            Console.ReadKey();
        }
        void While()
        {
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Olá");
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
