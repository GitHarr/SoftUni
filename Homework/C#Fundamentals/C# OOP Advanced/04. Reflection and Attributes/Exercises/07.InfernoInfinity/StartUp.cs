namespace _07.InfernoInfinity
{
    using P07.InfernoInfinity.Contracts;
    using P07.InfernoInfinity.Core;
    using P07.InfernoInfinity.IO;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
