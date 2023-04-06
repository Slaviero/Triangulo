namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Vamos verificar o tipo de seu triangulo.");
            Console.WriteLine("Informe o primeiro lado do triangulo: ");
            triangulo.lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo lado do triangulo: ");
            triangulo.lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro lado do triangulo: ");
            triangulo.lado3 = int.Parse(Console.ReadLine());

            triangulo.tipoTriangulo = triangulo.DetectarTipoTriangulo(triangulo.lado1, triangulo.lado2, triangulo.lado3);

            Console.WriteLine($"O seu triangulo{triangulo.tipoTriangulo}");
        }
    }
}