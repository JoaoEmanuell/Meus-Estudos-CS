namespace Meus_Estudos_CS{
    class Aula_08{
        static void main(){
            int v1 = 0, v2, sum;
            Console.Write("First Number : ");
            //v1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number : ");
            v2 = Convert.ToInt32(Console.ReadLine());
            sum = v1 + v2;
            Console.WriteLine($"Sum of {v1} and {v2} is {sum}");
        }
    }
}