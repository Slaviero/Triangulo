using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;

        public string tipoTriangulo;
        public string DetectarTipoTriangulo(int x, int y, int z) 
        {
            if(x > y + z)
            {
                tipoTriangulo = ", não é um triangulo";
            }
            else
            {
                if(x == y && y == z && z == x)
                {
                    tipoTriangulo = " é Eqüilátero.";
                }
                else  if(x != y && y != z && z != x)
                {
                    tipoTriangulo = " é Escaleno.";
                }
                else if(x == y && x != z || x == z && x != y || y == x && y != z || y == z && y != x || z == x && z != y || z == y && z != x)
                {
                    tipoTriangulo = " é Isósceles.";
                }
            }

            return tipoTriangulo;
        }
    }
}
