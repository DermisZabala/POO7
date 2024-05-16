using System;

namespace POO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            Console.ReadKey();
        }
        
        static void realizarTarea()
        {         
          
            Punto puntos1 = new Punto(33, 50);
            Punto puntos2 = new Punto(32, 22, 0);
                        
            double distancia = puntos1.Distancia(puntos2, puntos1);                      

            Console.WriteLine("La distancia entre: \n" + puntos1.GetPuntosX() + "\n" 
                + puntos2.GetPuntosY() + "\nes igual a " + distancia);

            Console.WriteLine($"La clase punto ha creado {Punto.GetContadorObjetos()} Objetos");

        }
    }
}
