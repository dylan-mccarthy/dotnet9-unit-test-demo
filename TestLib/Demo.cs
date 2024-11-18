namespace TestLib
{
    public class Demo
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}!";
        }

        public string SayGoodbye(string name)
        {
            return $"Goodbye, {name}!";
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void ShortRunningMethod()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public void MediumRunningMethod()
        {
            System.Threading.Thread.Sleep(5000);
        }

        public void LongRunningMethod()
        {
            System.Threading.Thread.Sleep(10000);
        }
    }
}
