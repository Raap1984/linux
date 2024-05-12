using System;

    
public class progra2proyectofinal { 
    
    public static void Main(string[] args)
    {
        int bandera=0;
        Console.WriteLine("Favor seleccione el programa a ejecutar:");
        Console.WriteLine("Para el Ejercicio 1,digite 1");
        Console.WriteLine("Para el Ejercicio 2,digite 2");
        Console.WriteLine("Para el Ejercicio 3,digite 3");
        Console.WriteLine("Para el Ejercicio 4,digite 4");
        Console.WriteLine("Para el Ejercicio 5,digite 5");
        Console.WriteLine("Para el Ejercicio 6,digite 6");
        Console.WriteLine("Para el Ejercicio 7,digite 7");
        Console.WriteLine("Para el Ejercicio 8,digite 8");
        Console.WriteLine("Para el Ejercicio 9,digite 9");
        Console.WriteLine("Para el Ejercicio 10,digite 10");
        Console.WriteLine("Digite 0, si desea salir");
        Console.Write("Digite la Opcion:");
        bandera=int.Parse(Console.ReadLine());
        switch (bandera)
        {
            case 1:
                Console.WriteLine("Programa 1");
                programa1();
            break;
            case 2:
                Console.WriteLine("Programa 2");
                programa2();
            break;
            case 3:
                Console.WriteLine("Programa 3");
                programa3();
            break;
            case 4:
                Console.WriteLine("Programa 4");
                programa4();
            break;
            case 5:
                Console.WriteLine("Programa 5");
                programa5();
            break;
            case 6:
                Console.WriteLine("Programa 6");
                programa6();
            break;
            case 7:
                Console.WriteLine("Programa 7");
                programa7();
            break;
            case 8:
                Console.WriteLine("Programa 8");
                programa8();
            break;
            case 9:
                Console.WriteLine("Programa 9");
                programa9();
            break;
            case 10:
                Console.WriteLine("Programa 10");
                programa10();
            break;
            case 0:
                Console.WriteLine("Saliendo");
            break;
        }
    
    }
    
    static void programa1()
    {
        Console.WriteLine("Digite su Nombre:");
        string nombre=Console.ReadLine();
        if(nombre =="David"){
            Console.WriteLine("Hola");
        }
        else
        {
            Console.WriteLine("No te conozco");
        }
    }
    static void programa2()
    {
        int numero, contenedor = 0;
        do
        {
            Console.WriteLine("Ingrese un numero por favor: 0 para salir o numero negativo");
            numero = int.Parse(Console.ReadLine());
            contenedor = numero + contenedor;
        } while (numero != 0 & numero > 0);
        contenedor = contenedor - numero;
        Console.WriteLine("El resultado de la suma es:" + contenedor);
    }
     static void programa3()
    {
        double[] salario= new double[5];
        double salariom=0;
        string[] nombre=new string[5];
        string nombrem;
        for(int i=0; i<5;i++)
        {
            Console.WriteLine("Favor Ingrese el Nombre del Empleado:");
            nombre[i]=Console.ReadLine();
            Console.WriteLine("Favor Ingrese el salario del Empleado:");
            salario[i]=double.Parse(Console.ReadLine());
        }
         for(int i=0; i<5;i++)
        {
            Console.WriteLine("Nombre:"+nombre[i]+" salario:"+salario[i]);
        }
        salariom=salario[0];
        nombrem=nombre[0];
        for(int i=1; i<5;i++)
        {
            if(salariom>salario[i])
            {
                
            }
            else
            {
                salariom=salario[i];
                nombrem=nombre[i];
            }
        }
        Console.WriteLine("El salario mayor es de:"+nombrem+" Con el sueldo:"+salariom);

    }
    static void programa4()
    {   
        for(int i=1;i<101;i++)
        {
            if((i%2)==0)
            {
               Console.WriteLine("El numero:"+i+"Es par");  
            }
            else
            {
                Console.WriteLine("El numero:"+i+" Es Impar");
            }
        }
    }
    static void programa5()
    {
         int num;

            do
            {
                Console.Write("¡HOLA!, Ingrese un numero entre 0 y 10: ");
                num = Int32.Parse(Console.ReadLine());

            } while (num < 1 || num > 9);

            for (int i = 1; i < 10; i++)
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

            Console.Read();
    }
    static void programa6()
    {
        //Variables
            double numP, promedio = 0;

            //Ciclo para solicitar 5 numeros
            for (int i = 1; i <= 5; i++)
            {
                //Solicitar los números al usuario
                Console.WriteLine("Ingrese un número: Cont:{0}", i);
                numP = double.Parse(Console.ReadLine());

                if (numP < 0)
                {
                    //Indicarle al usuario que está ingresando números negativos
                    Console.WriteLine("Ingrese un número valido.");
                    i -= 1;
                }
                else
                {
                    //Sumar los números ingresados
                    promedio += numP;
                }
            }
            //Calcular promedio
            promedio = promedio / 5;
            //Imprimir el promedio de los 5 números
            Console.WriteLine("El promedio es: {0}", promedio);
    }
    static void programa7()
    {
        //Variables
            double num, result;

            do
            {
                //Solicitar números al usuario
                Console.WriteLine("Ingrese un número: ");
                num = double.Parse(Console.ReadLine());

                //Validar que el número no sea negativo
                if (num > 0)
                {
                    //Realizar la elevación
                    result = Math.Pow(num, 2);
                    Console.WriteLine("{0} elevado al cuadrado es igual a {1}", num, result);

                }
                else
                {
                    //Indicarle al usuario que está ingresando un número invalido
                    Console.Clear();
                    Console.WriteLine("ERROR. Reingresar número");
                    Console.WriteLine("");
                }

                //Condicional para solicitar un nuevo número hasta que el numero sea positivo o diferente de 0
            } while (num <= 0);
    }
    static void programa8()
    {
        int numero;
        Console.WriteLine("Ingrese un numero por favor:, 0 para salir");
        numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (numero > 0)
            {
                Console.WriteLine("Numero Positivo");
            }
            else
                Console.WriteLine("Numero Negativo");
                Console.WriteLine("Ingrese un numero por favor: 0 para salir");
                numero = int.Parse(Console.ReadLine());
        }

    }
    static void programa9()
    {
          //Variables
            int num, result;

            //Solicitar número al usuario
            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            //Obtener el residuo del número ingresado
            result = num % 2;

            if(result == 0)
            {
                //Imprimir si se cumple la condición
                Console.WriteLine("El número {0} es par", num);
            }
            else
            {
                //Imprimir si la condición no se cumple 
                Console.WriteLine("El número {0} es impar", num);
            }
    }
    static void programa10()
    {
        //Variables
            double num, promedio = 0;

            //Ciclo para solicitar 15 edades
            for (int i = 1; i <= 15; i++)
            {
                //Solicitar edades al usuario
                Console.WriteLine("Ingrese la edad del estudiante {0}:", i);
                num = double.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    //Indicar que las edades negativas o cero es invalido
                    Console.WriteLine("Ingrese una edad valida.");
                    Console.WriteLine("");
                    i -= 1;
                }
                else
                {
                    //Sumar edades
                    promedio += num;
                }
            }

            //Calcular promedio
            promedio = promedio / 15;
            //Imprimir el promedio
            Console.WriteLine("El promedio de edad es: {0}", promedio);
    }
    
}