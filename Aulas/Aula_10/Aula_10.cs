namespace Meus_Estudos_CS{
    class Aula_10{
        enum WeekDays{ Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        static void main(){
            WeekDays wd = WeekDays.Monday;

            //WeekDays wd = (WeekDays)3;

            Console.WriteLine(wd);

            int wd2 = (int)WeekDays.Monday;

            Console.WriteLine(wd2);
        }
    }
}