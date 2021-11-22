namespace Meus_Estudos_CS{
    class Aula_15{
        static void main(){
            string name;
            Console.Write("Type your name: ");
            name = "0"; //Console.ReadLine();

            switch(name){
                case "João":
                    Console.WriteLine("Your name is João");
                    break;
                case "Maria":
                    Console.WriteLine("Your name is Maria");
                    break;
                case "Pedro":
                    Console.WriteLine("Your name is Pedro");
                    break;
                default:
                    Console.WriteLine("Name not found");
                    break;
            }
        }
    }
}