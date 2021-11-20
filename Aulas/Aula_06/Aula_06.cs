class Aula_06{
    static void main(){
        double price, sale, gain;
        price = 5.50; sale = 2.00; gain = 0.1;
        Console.WriteLine($"Produto {price,15}");
        Console.WriteLine($"Venda {sale,15:c}");
        Console.WriteLine($"Lucro {gain,15:p}");
    }
}