// See https://aka.ms/new-console-template for more information
class program
{
    static int num, a, b, c;
    static double bruto, neto, numero, x, y , z;
    static int op;

    static void Main(string []args)
    {
        menu();
    }

    static void menu()
    {
        do
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("[1] Secuencia Fibonacci");
            Console.WriteLine("[2] Par o Impar");
            Console.WriteLine("[3] Números Primos");
            Console.WriteLine("[4] Sueldo Bruto y Sueldo Neto");
            Console.WriteLine("[5] Simulador de cajero");
            Console.WriteLine("[6] salir");

            op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1: Secuencia_Fibonacci();
                break;

                case 2: Par_o_Impar();
                break;

                case 3: numeros_Primos();
                break;

                case 4: Sueldo_Bruto_y_Sueldo_Neto();
                break;

                case 5: Simulador_de_cajero();
                break;

                case 6: salir();
                break;

                default: Default();
                break;
            }

        }while(op != 6);
   
    }

    static void Secuencia_Fibonacci()
    {
        Console.Clear();

        a = 0;
        b = 1;

        Console.WriteLine("Ingrese la cantidad de veces a ejecutar la secuencia fibonacci");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < num; i++)
        {
            c = a;
            a = b;
            b = c + a;
            Console.WriteLine(a);
        }


        Console.ReadKey();
    }

    static void Par_o_Impar()
    {
        Console.Clear();

        Console.WriteLine("Ingrese un numero a determinar");
        num = Convert.ToInt32(Console.ReadLine());

        if(num %2 == 0)
        {
            Console.WriteLine($"El {num} es par");
        }

        else
        {
            Console.WriteLine($"El {num} es impar");
        }

        Console.ReadKey();
    }

    static void numeros_Primos()
    {
        Console.Clear();
        
        Console.WriteLine("Ingrese un numero a determinar");
        num = Convert.ToInt32(Console.ReadLine());

        if(num %2 == 1)
        {
            Console.WriteLine($"El {num} es primo");
        }

        else
        {
            Console.WriteLine($"El {num} no es primo");
        }

        Console.ReadKey();
    }

    static void Sueldo_Bruto_y_Sueldo_Neto()
    {
        Console.Clear();
        Console.WriteLine("Ingrese el monto a determinar el sueldo bruto y sueldo neto");
        numero = Convert.ToDouble(Console.ReadLine());

        bruto = numero;
        Console.WriteLine();
        Console.WriteLine("El suedo bruto del monto ingresado es:");
        Console.WriteLine(bruto);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Los descuentos aplicados al sueldo son:");

        Console.WriteLine();
        Console.WriteLine("Seguro Familiar de Salud (SFS) = 3.04%");
        x = numero * 0.0304;
        Console.WriteLine(x);

        Console.WriteLine();
        Console.WriteLine("Administradora de Fondo de Pensiones (AFP) = 2.87%");
        y = numero * 0.0287;
        Console.WriteLine(y);

        Console.WriteLine();
        Console.WriteLine("Impuesto Sobre la Renta (ISR) = 0.00%");
        z = numero * 0.00;
        Console.WriteLine(z);
          
        Console.WriteLine();
        Console.WriteLine("El suedo neto del monto ingresado con todos los descuentos es: ");
        neto = numero - x - y - z;
        Console.WriteLine(neto);

        Console.ReadKey();
    }

    static void Simulador_de_cajero()
    {
        Console.Clear();
        Console.ReadKey();
    }

    static void salir()
    {
        Console.Clear();
        Console.WriteLine("Saliste del programa");
        Console.ReadKey();
    }

    static void Default()
    {
        Console.Clear();
        Console.WriteLine("La opcion ingresada es incorrecta");
        Console.ReadKey();
    }
    
}