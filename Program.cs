namespace LambdaGenericDelegate {
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };

            double result = obj1.Invoke(100, 125.45f, 456.789);

            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) => {
                Console.WriteLine(x + y + z);
            };

            obj2.Invoke(50, 255.45f, 123.456);

            Predicate<string> obj3 = (name) =>
            {
                if(name.Length > 5) 
                    return true;

                return false;
            };

            bool res = obj3.Invoke("Ikechukwu");

            Console.WriteLine(res);
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}