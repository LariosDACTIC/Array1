namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tama;o del arreglo");
            int tam = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tam];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero a guardar en la posicion "+(i+1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El arreglo se lleno");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine((i+1)+"-> "+numeros[i]);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }




        }
    }
}
