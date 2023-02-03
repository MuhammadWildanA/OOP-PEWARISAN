namespace v23 
{

    class Kalkulator
    {
        public void tambah(){
            Console.WriteLine("tambah");
        }

        public void kurang(){
            Console.WriteLine("kurang");
        }
    }

    class Rumus:Kalkulator
    {
        public void lingkaran(){
            Console.WriteLine("lingkaran");
        }
    }
}