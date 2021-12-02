using System;

namespace Evaluacion_3
{
    class Program
    {
        static void Main(string[] args)
        {
          
           string dato = "";
            double peso = 0;
            int actividaddelperro = 0;
            int edaddelperro = 0;
            int opcion = 0;
            int año = 0 ;
         do {



            Console.WriteLine("Hola, Bienvenido a tu guia de alimentacion para su perro");

            Console.WriteLine("Su perro tiene más de un año de vida?");
            Console.WriteLine("1- No");
            Console.WriteLine("2- Si");
            dato = Console.ReadLine();
            año = Convert.ToInt32(dato);
            
            if (año == 1){

             Console.WriteLine("Por favor, introduzca los meses de edad de su mascota");
             dato = Console.ReadLine();
             edaddelperro = Convert.ToInt32(dato);
        

             Console.WriteLine("Por favor, introduzca el peso de su mascota");
             dato = Console.ReadLine();
             peso = Convert.ToDouble(dato);

             if (peso == 2 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 50 gramos.");
               if (peso == 2 && edaddelperro == 3 || peso == 2 && edaddelperro == 4 ||  peso == 2 && edaddelperro == 5)
                 Console.WriteLine("Su perro debe comer 55 gramos."); 
               if (peso == 5 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 95 gramos."); 
               if (peso == 5 && edaddelperro == 3 || peso == 5 && edaddelperro >= 6)
                 Console.WriteLine("Su perro debe comer 110 gramos."); 
               if (peso == 5 && edaddelperro == 4 || peso == 5 &&  edaddelperro == 5)
                 Console.WriteLine("Su perro debe comer 115 gramos.");
               if (peso == 10 && edaddelperro == 2)  
                 Console.WriteLine("Su perro debe comer 155 gramos.");
               if (peso == 10 && edaddelperro == 3 || peso == 10 && edaddelperro >= 6) 
                 Console.WriteLine("Su perro debe comer 185 gramos."); 
               if (peso == 10 && edaddelperro == 4) 
                 Console.WriteLine("Su perro debe comer 195 gramos."); 
               if (peso == 10 && edaddelperro == 5)  
                 Console.WriteLine("Su perro debe comer 190 gramos."); 
               if (peso == 17 && edaddelperro == 2) 
                 Console.WriteLine("Su perro debe comer 215 gramos.");
               if (peso == 17 && edaddelperro == 3) 
                 Console.WriteLine("Su perro debe comer 265 gramos.");
               if (peso == 17 && edaddelperro == 4 || peso == 17 && edaddelperro == 5) 
                 Console.WriteLine("Su perro debe comer 285 gramos."); 
               if (peso == 17 && edaddelperro >= 6) 
                 Console.WriteLine("Su perro debe comer 280 gramos.");
               if (peso == 25 && edaddelperro == 2)   
                 Console.WriteLine("Su perro debe comer 270 gramos.");
               if (peso == 25 && edaddelperro == 3)
                 Console.WriteLine("Su perro debe comer 350 gramos.");
               if (peso == 25 && edaddelperro == 4 || peso == 25 &&  edaddelperro == 5) 
                 Console.WriteLine("Su perro debe comer 375 gramos.");   
               if (peso == 25 && edaddelperro >= 6)
                 Console.WriteLine("Su perro debe comer 370 gramos.");
               if (peso == 32 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 300 gramos."); 
               if (peso == 32 && edaddelperro == 3) 
                 Console.WriteLine("Su perro debe comer 400 gramos.");
               if (peso == 32 && edaddelperro == 4) 
                 Console.WriteLine("Su perro debe comer 445 gramos.");
               if (peso == 32 && edaddelperro >= 5)
                 Console.WriteLine("Su perro debe comer 450 gramos.");
               if (peso == 40 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 355 gramos.");
               if (peso == 40 && edaddelperro == 3)
                 Console.WriteLine("Su perro debe comer 475 gramos.");
               if (peso == 40 && edaddelperro == 4)
                 Console.WriteLine("Su perro debe comer 525 gramos.");
               if (peso == 40 && edaddelperro >= 5)  
                 Console.WriteLine("Su perro debe comer 530 gramos.");
               if (peso == 50 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 405 gramos.");
               if (peso == 50 && edaddelperro == 3)
                 Console.WriteLine("Su perro debe comer 545 gramos."); 
               if (peso == 50 && edaddelperro == 4)
                 Console.WriteLine("Su perro debe comer 610 gramos.");
               if (peso == 50 && edaddelperro == 5) 
                 Console.WriteLine("Su perro debe comer 625 gramos."); 
               if (peso == 60 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 450 gramos.");
               if (peso == 60 && edaddelperro == 3) 
                 Console.WriteLine("Su perro debe comer 605 gramos.");
               if (peso == 60 && edaddelperro == 4) 
                 Console.WriteLine("Su perro debe comer 685 gramos.");
               if (peso == 70 && edaddelperro == 2) 
                 Console.WriteLine("Su perro debe comer 485 gramos.");
               if (peso == 70 && edaddelperro == 3)
                 Console.WriteLine("Su perro debe comer 670 gramos.");
               if (peso == 90 && edaddelperro == 2)
                 Console.WriteLine("Su perro debe comer 580 gramos.");
            }
            else if (año == 2) {           
                Console.WriteLine("Por favor, introduzca el peso de su mascota");
             dato = Console.ReadLine();
             peso = Convert.ToDouble(dato);
             
             Console.WriteLine("En base a su conocimiento sobre su mascota, ¿como considera la actividad de su mascota?");
             Console.WriteLine("1- Actividad Alta");
             Console.WriteLine("2- Actividad Media");
             Console.WriteLine("3- Actividad Baja");
             dato = Console.ReadLine();
             actividaddelperro = Convert.ToInt32(dato);
              
              if (peso >=2 && peso <= 5)
                
                switch (actividaddelperro) {

                    case 1:
                    Console.WriteLine("Su perro debe comer 60-115 gramos.");
                    break;

                    case 2:
                    Console.WriteLine("Su perro debe comer 55-100 gramos.");
                    break;

                    case 3:
                    Console.WriteLine("Su perro debe comer 45-85 gramos.");
                    break;
                }
              if (peso >=6 && peso <= 10)

                 switch (actividaddelperro) {

                    case 1:
                    Console.WriteLine("Su perro debe comer 115-190 gramos.");
                    break;

                    case 2:
                    Console.WriteLine("Su perro debe comer 100-170 gramos.");
                    break;

                    case 3:
                    Console.WriteLine("Su perro debe comer 85-145 gramos.");
                    break;
                 }
              if (peso >= 11 && peso <= 15)
                   
                    switch (actividaddelperro) {

                        case 1:
                        Console.WriteLine("Su perro debe comer 190-255 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 170-225 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 145-195 gramos.");
                        break;
                        
                    }
              if (peso >= 16 && peso <= 25)  

                     switch (actividaddelperro) {

                        case 1:
                        Console.WriteLine("Su perro debe comer 255-380 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 225-330 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 195-285 gramos.");
                        break;
                        
                     }

              if (peso >= 26 && peso <= 40)
                     
                      switch (actividaddelperro) {

                        case 1:
                        Console.WriteLine("Su perro debe comer 380-535 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 330-475 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 285-410 gramos.");
                        break;
                      }

              if (peso >= 41 && peso <= 55)

                      switch (actividaddelperro) {
                        
                        case 1:
                        Console.WriteLine("Su perro debe comer 535-680 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 475-600 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 410-520 gramos.");
                        break;
                      }
              if (peso >= 56 && peso <= 70)

                      switch (actividaddelperro) {

                        case 1:
                        Console.WriteLine("Su perro debe comer 680-820 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 600-720 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 520-620 gramos.");
                        break;
                       }
              if (peso >= 71 && peso <= 90)

                      switch (actividaddelperro) {

                        case 1:
                        Console.WriteLine("Su perro debe comer 820-985 gramos.");
                        break;

                        case 2:
                        Console.WriteLine("Su perro debe comer 720-870 gramos.");
                        break;

                        case 3:
                        Console.WriteLine("Su perro debe comer 620-750 gramos.");
                        break;
                      }
            }

            Console.WriteLine(" Si desea saber la antidad de comida de cualquier otra mascota pulse 4");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

         }while(opcion == 4);

         

        }
    }
}
