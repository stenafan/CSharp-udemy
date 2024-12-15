using System

Console.WriteLine("Enter the name of the file you want to read");
var fileName = Console.Readline();

public class Dog
{
    [StringLengthValidate(2,10)]
    public string Name { get; }

    public Dog(string name) => Name = name;
}

[AttributeUsage(AttributeTargets.Property)]
public class StringLengthValidateAttribute : Attribute
{
    public Min {get;}
    public Max {get;}

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

public class Validator
{
    public bool Validate (object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type
        .GetProperties()
        .Where(property => 
        Attribute.IsDefined(
            property, typeof(StringLengthValidateAttribute)));

        foreach(var prop in propertiesToValidate)
        {
            object? propertyVal
        }
    }
}