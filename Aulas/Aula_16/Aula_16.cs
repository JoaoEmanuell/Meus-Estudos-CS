namespace Meus_Estudos_CS{
    class Aula_16{
        static void main(){
            start : 

            Console.Clear();
            string name;
            Console.Write("Type your name: ");
            name = "0";//Console.ReadLine();

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

            Console.Write("Restart ? [s/n] ");
            char answer = '0';//Convert.ToChar(Console.ReadLine());

            if (answer == 's'){
                goto start;
            }
        }
    }
}