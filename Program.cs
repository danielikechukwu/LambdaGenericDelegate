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
        }
    }
}