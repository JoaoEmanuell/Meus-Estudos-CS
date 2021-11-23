namespace Meus_Estudos_CS{
    class Aula_19{
        static void main(){
            /*
            for (short i = 1; i <= 10; i++){
                Console.WriteLine(i);
            }
            */
            int[] numeros = new int[10];
            for (short i = 0; i < numeros.Length; i++){
                numeros[i] = 0;
            }
            for (short i = 0; i < numeros.Length; i++){
                Console.WriteLine($"{i} : {numeros[i]}");
            }
        }
    }
}