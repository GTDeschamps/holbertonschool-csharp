using System;
using System.Reflection;
    class Obj
    {
        public static void Print(object myObj)
        {
        Type objType = myObj.GetType();

        // Print properties
        Console.WriteLine( $"{objType.Name} Properties:");

        PropertyInfo[] properties = objType.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name);
        }

        // Print methods
        Console.WriteLine($"{objType.Name} Methods:");
        MethodInfo[] methods = objType.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
