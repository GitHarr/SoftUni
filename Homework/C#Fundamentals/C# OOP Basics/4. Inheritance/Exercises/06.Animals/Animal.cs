using System;
using System.Collections.Generic;
using System.Text;

public class Animal : ISoundProducable
{
    private const string ErrorMessage = "Invalid input!";

    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }
    
    public virtual string ProduceSound()
    {
        return "NOISE!!!";
    } 

    public string Name
    {
        get => name;
        set
        {
            NotEmptyValidation(value);
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMessage);
            }
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            NotEmptyValidation(value);
            gender = value;
        }
    }

    private static void NotEmptyValidation(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(ErrorMessage);
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}")
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine(this.ProduceSound());

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

