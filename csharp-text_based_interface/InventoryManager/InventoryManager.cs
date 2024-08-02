using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        private static JSONStorage _storage;

        static void Main(string[] args)
        {
            _storage = new JSONStorage();
            _storage.Load();

            PrintPrompt();

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                switch (parts[0].ToLower())
                {
                    case "classnames":
                        PrintClassNames();
                        break;
                    case "all":
                        if (parts.Length == 1)
                        {
                            PrintAllObjects();
                        }
                        else
                        {
                            PrintAllObjectsOfClassName(parts[1]);
                        }
                        break;
                    case "create":
                        CreateObject(parts[1]);
                        break;
                    case "show":
                        ShowObject(parts[1], parts[2]);
                        break;
                    case "update":
                        UpdateObject(parts[1], parts[2]);
                        break;
                    case "delete":
                        DeleteObject(parts[1], parts[2]);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }

                PrintPrompt();
            }
        }

        private static void PrintPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        private static void PrintClassNames()
        {
            List<string> classNames = _storage.GetClassNames();
            foreach (string className in classNames)
            {
                Console.WriteLine(className);
            }
        }

        private static void PrintAllObjects()
        {
            List<object> objects = _storage.GetAllObjects();
            foreach (object obj in objects)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        private static void PrintAllObjectsOfClassName(string className)
        {
            List<object> objects = _storage.GetAllObjectsOfClassName(className);
            if (objects == null)
            {
                Console.WriteLine($"{className} is not a valid object type");
                return;
            }
            foreach (object obj in objects)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        private static void CreateObject(string className)
        {
            object obj = _storage.CreateObject(className);
            if (obj == null)
            {
                Console.WriteLine($"{className} is not a valid object type");
                return;
            }
            _storage.SaveObject(obj);
            Console.WriteLine($"Object created: {obj.ToString()}");
        }

        private static void ShowObject(string className, string id)
        {
            object obj = _storage.GetObject(className, id);
            if (obj == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }
            Console.WriteLine(obj.ToString());
        }

        private static void UpdateObject(string className, string id)
        {
            object obj = _storage.GetObject(className, id);
            if (obj == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }
            // Update object properties here
            _storage.SaveObject(obj);
            Console.WriteLine($"Object updated: {obj.ToString()}");
        }

        private static void DeleteObject(string className, string id)
        {
            object obj = _storage.GetObject(className, id);
            if (obj == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }
            _storage.DeleteObject(obj);
            Console.WriteLine($"Object deleted: {obj.ToString()}");
        }
    }
}
