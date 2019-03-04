using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios111Mil
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            Saludo();
            Console.Write("\n");
            Suma();
            Console.Write("\n");
            Login();
            Console.Write("\n");
            int[] diasdelMes;
            diasdelMes = cargarDias();
            int Mes;

            Console.Write("Ingrese el n° de mes que desee averiguar: ");
            Mes = int.Parse(Console.ReadLine());

            Console.Write("El mes " + Mes + " tiene " + diasdelMes[Mes - 1] + " dias");
            Console.ReadKey();
            Console.Write("\n");
            AlternativaDoble();
            Console.Write("\n");
            Descuento();
            AlternativaMultiple();
            Console.Write("\n");
            RepetitivaMientras();
            Console.Write("\n");
            HacerMientras();
            Console.Write("\n");
            EstructuradeDatos();
            Console.Write("\n");
            DosArreglos();
            RepetitivaPara();
            Console.Write("\n");
            BusquedaSecuencial();
            Console.Write("\n");
            Busquedasecuencial();
        }

        public static void Saludo()
        {
            Console.Write("Hola Mundo");
        }

        public static void Suma()
        {

            int a, b, c;
            string datos;
            Console.Write("\n");
            Console.Write("Ingrese el primer número: ");
            datos = Console.ReadLine();
            a = int.Parse(datos);
            Console.Write("Ingrese el segundo número: ");
            datos = Console.ReadLine();
            b = int.Parse(datos);

            c = a + b;

            Console.Write("El resultado es: {0}",c);
            Console.ReadKey();
        }

        public static void Login()
        {
            try
            {
                string nombre = "";
                string pass = "";

                Console.Write("Ingrese el usuario: ");
                nombre = Console.ReadLine();
                Console.Write("\n");
                Console.Write("Ingrese el pass: ");
                pass = Console.ReadLine();

                if (nombre == "Juan" && pass == "Pokemon")
                {
                    Console.Write("Usuario Logeado Correctamente.");
                }
                if (nombre == "Julieta" && pass == "Pikachu")
                {
                    Console.Write("Usuario Logeado Correctamente.");
                }
                if (nombre == "Andrea" && pass == "NoSoyFanDePokemo")
                {
                    Console.Write("Usuario No Valido.");
                }
            }catch(Exception ex)
            {
                Console.Write("Usuario o Contraseña ¡¡Incorrecta!!");
            }

            Console.ReadKey();
        }

        public static int[] cargarDias()
        {
            String[] Meses = new String[]{"Enero: ","Febrero: ","Marzo: ","Abril: ",
            "Mayo: ","junio: ","Julio: ",
            "Agosto: ","Septiembre: ","Octubre: ","Noviembre: ","Diciembre: "};
            int[] DiasMes = new int[12];
            
             for (int i = 0; i < 12; i ++)
             {
                Console.Write("Ingrese los dias del mes de "+ Meses[i]);

                DiasMes[i] = int.Parse(Console.ReadLine());
             }
             return DiasMes;
             //Console.ReadKey();
        }

        public static void AlternativaDoble()
        {
            int cantBancosAula;
            int cantAlumnosInscriptos;
            int bancosFaltantes;
            string datos;

            Console.Write("Ingrese la cantidad de bancos disponibles en el aula: ");
            datos = Console.ReadLine();
           cantBancosAula = int.Parse(datos);
           Console.Write("Ingrese la cantidad de alumnos inscriptos: ");
            datos = Console.ReadLine();
            cantAlumnosInscriptos = int.Parse(datos);
        
           bancosFaltantes = cantAlumnosInscriptos - cantBancosAula;
           
           if (cantAlumnosInscriptos >= cantBancosAula)
           { 
               Console.Write("La cantidad de bancos faltantes es: {0}", bancosFaltantes);
               Console.ReadKey();
           }
           else 
               Console.Write("Los bancos del aula son suficiente: {0}", bancosFaltantes);
               Console.ReadKey();
            }

        public static void Descuento()
        {
            float montoTotal;
            string formadePago;
            float montoconDescuento;
            string datos;

           Console.Write("Ingrese el monto total de la compra: ");
           datos = Console.ReadLine();
           montoTotal = float.Parse(datos);
           
           Console.Write("Ingre forma de pago, Credito o Contado: ");
           formadePago = Console.ReadLine();
           
           if (formadePago == "Contado")
           {
               montoconDescuento = montoTotal * 0.9f;
               Console.Write("El monto total con descuento aplicado,"
                       + "por pago al contado es de:$" + montoconDescuento);
               Console.ReadKey();
           }
           else
               Console.Write("La forma de pago no tiene descuento. Su monto es de ${0}", montoTotal);
           Console.ReadKey();
            }

        public static void AlternativaMultiple()
        {
            int numeroMes;
            string datos;
            Console.Write("Ingrese el número del mes: ");
            datos = Console.ReadLine();
            numeroMes = int.Parse(datos);

            switch(numeroMes)
            {
                case 1:
                    Console.Write("Enero");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Febrero");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Marzo");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("Abril");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("Mayo");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Write("Junio");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Write("Julio");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.Write("Agosto");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.Write("Septiembre");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.Write("Octubre");
                    Console.ReadKey();
                    break;
                case 11:
                    Console.Write("Noviembre");
                    Console.ReadKey();
                    break;
                case 12:
                    Console.Write("Diciembre");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("El mes no existe");
                    Console.ReadKey();
                    break;
                    
            }
        }

        public static void RepetitivaMientras()
        {
           int tablaNum;
           int tablaHasta;
           int contador = 1;
           int multiplicacion;
           string datos;
           
           Console.Write("Ingrese el numero del cual desea conocer la tabla de multiplicar: ");
           datos = Console.ReadLine();
           tablaNum = int.Parse(datos);
           
           Console.Write("Ingrese el numero hasta donde desea conocer la tabla: ");
           datos = Console.ReadLine();
           tablaHasta = int.Parse(datos);
           Console.Write("\n");
           while(contador <= tablaHasta)
           {
               multiplicacion = tablaNum * contador;
               Console.WriteLine(tablaNum + " * " + contador + " = " + multiplicacion);
               contador ++;
           }
           Console.ReadKey();
        }

        public static void HacerMientras()
   {
       int tablaNum;
       int tablaHasta;
       int contador = 1;
       int multiplicacion;
       string datos;
       
           Console.Write("Ingrese el numero del cual desea conocer la tabla de multiplicar: ");
           datos = Console.ReadLine();
           tablaNum = int.Parse(datos);
       
           Console.Write("Ingrese el numero hasta donde desea conocer la tabla: ");
           datos = Console.ReadLine();
           tablaHasta = int.Parse(datos);
           Console.Write("\n");
       
       do
       {
           multiplicacion = tablaNum * contador;
           Console.WriteLine(tablaNum + " * " + contador + " = " + multiplicacion);
           contador ++;    
       }
       
       while(contador <= tablaHasta);
       Console.WriteLine("\n");
       Console.ReadKey();
   }
        
        public static void EstructuradeDatos()
   {
       
       bool [] butacas = {true,false,false,true,true};
       int butacasVacias = 0;
       
       for(int i = 0; i < butacas.Length; i++)
       {
           bool butacasActual = butacas[i];
           
           if (butacasActual == true)
           {
               butacasVacias = butacasVacias + 1;
           }
       }
       
       Console.Write("La cantidad de vutacas vacias en la sala es: " + butacasVacias);
       Console.ReadKey();
   }

         public static void DosArreglos()
   {
       String [] ColoresAula = new String []{"Azul","Verde","Amarillo"};
       int [] CapacAula = new int []{40, 35, 30};
       int cantAlumIns;
       string datos;
       
            Console.Write("Ingrese la cantidad de alumnos inscriptos al cursado: ");
            datos = Console.ReadLine();
            cantAlumIns = int.Parse(datos);
            Console.Write("\n\n");

            int capacidadAulaAux = CapacAula[0];
       
       for(int i = 0; i < CapacAula.Length; i++)
       {
           int capacidadAulaActual = CapacAula[i];
           
           if((capacidadAulaActual >= cantAlumIns) && (capacidadAulaActual < capacidadAulaAux))
           {
               capacidadAulaAux = capacidadAulaActual;
               int indiceAulaAux = i ;
               String colorAula = (String)ColoresAula[indiceAulaAux];
               
               Console.Write("El aula indicada para la cantidad ingresada de " +
               "alumnos es el aula: " + colorAula + " con una capacidad de: " + 
               capacidadAulaAux);
           }
       } 
       Console.Write("\n\n");
   }

         public static void RepetitivaPara()
   {      
       double acumulador = 0;
       double promedio = 0;
       double numero = 0;
       string datos;
       
       for (int i = 1; i <= 4; i++)
       {
           Console.Write(i + "° Ingrese el numero: ");
           datos = Console.ReadLine();
           numero = int.Parse(datos);
           
           acumulador = acumulador + numero;
       } 
       promedio = acumulador / 4;
       Console.Write("El promedio de los numeros es: " + promedio);
       Console.ReadKey();
       }

        public static void BusquedaSecuencial()
   {
        String [] Nombres = new String[]{"Miguel","Jose","Pedro","Joza"};
        int [] Edades = new int []{40,25,32,18};
        int pos = -1;
        
        Console.Write("Ingrese el nombre de la persona, para averiguar su edad: ");
        String nombre = Console.ReadLine();
        
        for(int i = 0; i < Nombres.Length; i++)
        {
            if(nombre == Nombres[i])
            {
                pos = i;
                break;
            }
        }
        
        if (pos != -1)
        {
            Console.Write("Su edad es de: "+Edades[pos] + " años");
            Console.ReadKey();
        }
       }

        public static void Busquedasecuencial()
   {
       String [] clientes = new String [] {"Juan", "Martin","Julieta","Sol","Sofia"};
       int posicion = 0;
       String nombre;
       Console.Write("Ingrese el nombre del cliente a buscar: ");
       nombre = Console.ReadLine();
       
       bool seencontro = false;
       
       for(int i = 0; i < 5 - 1; i++)
       {
           if(clientes[i] == nombre)
           {
               seencontro = true;
               posicion = i;
               break;
           }
       }
       if(seencontro == true)
       {
           Console.Write("El cliente buscado se encuentra en la posición: "+ posicion);
           Console.ReadKey();
       }
       else
           Console.Write("El cliente no se encuentra en la lista");
           Console.ReadKey();
       }
    }
}
