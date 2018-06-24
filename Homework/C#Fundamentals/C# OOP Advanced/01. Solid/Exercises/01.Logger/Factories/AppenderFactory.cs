using System;
using System.Linq;
using System.Reflection;

public class AppenderFactory
{
    public IAppender CreateAppender(string appenderType, ILayout layout)
    {
        Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(a => a.Name == appenderType);
        return (IAppender)Activator.CreateInstance(type, layout);
    }
}
