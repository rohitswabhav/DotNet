namespace DelegateWithAnonymous
{

    public delegate double DelegateMultiplication(int number1, int number2);
    class Program
    {
        public double Addition(int num1, int num2)
        {
            Console.WriteLine("Addition");
            return num1+num2;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();    
            Console.WriteLine("Delegate with ANonymous");

           // DelegateMultiplication multiplication1 = program.Addition;

            DelegateMultiplication multiplication =  (int number1, int number2)=>
            {
                return number1 * number2;
            };


            DelegateMultiplication addition = (int number1, int number2) =>
            {
                return number1 + number2;
            };

            double result = multiplication(10, 2);
            double addResult = addition(10, 20);
           // DelegateMultiplication addition = program.Addition;
            Console.WriteLine(result);


           // double addResult = addition(10, 20);
            Console.WriteLine(addResult);
        }
        

    }
}