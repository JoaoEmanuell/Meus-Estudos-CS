class Aula_02{
    
    static void main(String[] args){
        Console.WriteLine("Hello world!");
        if (args.GetLength(0) > 0){
            Console.WriteLine(args.GetValue(0));
        }
        else {
            Console.WriteLine("No arguments");
        }
    }
}