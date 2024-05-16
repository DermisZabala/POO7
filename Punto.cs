using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace POO7
{
    internal class Punto
    {
        //Distancia de los puntos en el eje X y el eje Y
        private int x1, x2, y1, y2;
        private static int contadorObjetos = 0;
       
        public Punto(int x1, int x2)
        {
            this.x1 = x1;
            this.x2 = x2;
            contadorObjetos++;
        }
        public Punto(int y1, int y2, int nulo)
        {
            this.y1 = y1;
            this.y2 = y2;
            contadorObjetos++;
        }
        public double Distancia(Punto puntos2, Punto puntos1)
        {
            int xDif = puntos1.x2 - puntos1.x1;
            int yDif = puntos2.y2 - puntos2.y1;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            double resultado = Math.Round(distanciaPuntos, 2);

            return resultado;
        }
        public string GetPuntosX()
        {
            return "Puntos X: (x1=" + x1 + ", x2=" + x2 + ")";

        }
        public String GetPuntosY()
        {
            return "Puntos Y: (y1=" + y1 + ", y2=" + y2 +")";
        }
        public static int GetContadorObjetos()
        {
            return contadorObjetos;
        }        
    }
}
