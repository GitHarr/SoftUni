using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        var stringBuilder = new StringBuilder($"Class under investigation: {classToInvestigate}" + Environment.NewLine);
        var fields = Type.GetType(classToInvestigate)
            .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        var classInstance = Activator.CreateInstance(Type.GetType(classToInvestigate));
        foreach (var field in fields)
        {
            if (fieldsToInvestigate.Contains(field.Name))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}"); 
            }
        }
        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string classToInvestigate)
    {
        var type = Type.GetType(classToInvestigate);
        var sb = new StringBuilder();

        foreach (var field in type.GetFields())
        {
            sb.AppendLine(field.Name + " must be private!");
        }

        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (var property in properties)
        {
            if (property.GetMethod?.IsPrivate == true)
            {
                sb.AppendLine(property.GetMethod.Name + " have to be public!");
            }
        }
        foreach (var property in properties)
        {
            if (property.SetMethod?.IsPublic == true)
            {
                sb.AppendLine(property.SetMethod.Name + " have to be private!");
            }
        }
        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string classToInvestigate)
    {
        var type = Type.GetType(classToInvestigate);
        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");
        foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic))
        {
            sb.AppendLine(method.Name);
        }
        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string classToInvestigate)
    {
        var type = Type.GetType(classToInvestigate);
        var sb = new StringBuilder();

        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (var property in properties)
        {
            if (property.GetMethod != null)
            {
                sb.AppendLine(property.GetMethod.Name + " will return " + property.GetMethod.ReturnType);
            }
        }
        foreach (var property in properties)
        {
            if (property.SetMethod != null)
            {
                sb.AppendLine(property.SetMethod.Name + " will set field of " + property
                    .SetMethod.GetParameters().First().ParameterType);
            }
        }
        return sb.ToString().Trim();
    }
}

