int valor = 1;

for (; valor != 0;)
{

    Console.WriteLine("=========MENU=========");
    Console.WriteLine();
    Console.WriteLine("   0 - Para SAIR        ");
    Console.WriteLine("   1 - Exercício 1      ");
    Console.WriteLine("   2 - Exercício 2      ");
    Console.WriteLine("   3 - Exercício 3      ");
    Console.WriteLine("   4 - Exercício 4      ");
    Console.WriteLine("   5 - Exercício 5      ");
    Console.WriteLine("   6 - Exercício 6      ");
    Console.WriteLine("   7 - Exercício 7      ");
    Console.WriteLine();
    Console.WriteLine("======================");

    valor = int.Parse(Console.ReadLine());

    switch (valor)
    {

        case 0:
            Console.WriteLine("Obrigado por usar o SisteMarques!");
            break;

        case 1:

            Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int nm = 1; nm <= a; nm++)
            {
                Console.WriteLine(nm);
            }
            break;

        case 2:


            Console.WriteLine("Digite um número:    (Será mostrado os números pares até ele)");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int nm = 1; nm <= p; nm++)

            {
                if (nm % 2 == 0) Console.WriteLine(nm);
            }

            break;

        case 3:

            Console.WriteLine(" escreva um número menor que 1000: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (s >= 1000)
            {
                Console.WriteLine("era para ser menor que 1000 ");

            }
            else
            {
                for (int nm = 1000; nm >= s; nm--)

                {
                    if (nm % 2 == 0) Console.WriteLine(nm);
                }
            }
            break;

        case 4:


            a = 0;


            for (; a < 200;)
            {

                Console.WriteLine("Digite um número:    (Serão somados ate chegar ou passar de 200) ");
                int b = int.Parse(Console.ReadLine());
                if (b > 0)

                    a += b;

            }
            Console.WriteLine(a);
            break;

        case 5:

            Console.WriteLine("Digite um número para ver seus divisores:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divisores de {numero}:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    Console.WriteLine(i);
            }
            break;

        case 6:


            Console.WriteLine("Digite o 1º número: ");
            int num = int.Parse(Console.ReadLine());

            int maior = num;
            int menor = num;

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}º número: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                    maior = num;

                if (num < menor)
                    menor = num;
            }

            Console.WriteLine($"O maior número digitado foi: {maior}");
            Console.WriteLine($"O menor número digitado foi: {menor}");
            break;

        case 7:

            int c = 0;
            int pares = 0;
            int impares = 0;

            for (; ; )  
               
            {
                
                Console.WriteLine("Digite um número (0 para sair):");
                int pi = int.Parse(Console.ReadLine());
               
                
                
                if (pi == 0)
                {
                    break;
                }

                if (pi % 2 == 0)
                {
                    pares += pi;
                }
                else
                {
                    impares += pi;
                }
            }

            Console.WriteLine($"Soma dos pares: {pares}");
            Console.WriteLine($"Soma dos ímpares: {impares}");
            break ;

    }

