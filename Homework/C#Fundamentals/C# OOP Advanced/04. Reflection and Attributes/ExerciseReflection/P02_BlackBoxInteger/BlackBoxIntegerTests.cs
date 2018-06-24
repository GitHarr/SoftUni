namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            FieldInfo innerValue = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);

            object instance = Activator.CreateInstance(type, true);

            MethodInfo[] methodsInfo = type
                .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(new[] { '_' });
                string methodName = tokens[0];
                int parameter = int.Parse(tokens[1]);

                foreach (MethodInfo info in methodsInfo)
                {
                    if (info.Name == methodName)
                    {
                        var result = info.Invoke(instance, new object[] { parameter });
                        Console.WriteLine(innerValue.GetValue(instance));
                    }
                }
            }
        }
    }
}
