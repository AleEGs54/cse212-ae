using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");


        //Asegúrate de que funciona con números, palabras, sets vacíos (ambos vacíos y uno vacío.)
        var set1 = new HashSet<string>() {"a", "b", "c", "d"};
        var set2 = new HashSet<string>() {"c","d","e","f"};
        var set3 = new HashSet<int>() {1,2,3,4};
        var set4 = new HashSet<int>() {3,4,5,6};
        var set5 = new HashSet<string>() ;
        var set6 = new HashSet<string>();
        

        var resultSet1 = IntersectSets(set1, set2);
        var resultSet2 = IntersectSets(set3,set4);
        var resultSet3 = IntersectSets(set2, set5);
        var resultSet4 = IntersectSets(set5,set6);

        




        Console.WriteLine($"Intersection: {string.Join(", ", resultSet1)}");
        Console.WriteLine($"Intersection: {string.Join(", ", resultSet2)}");
        Console.WriteLine($"Intersection: {string.Join(", ", resultSet3)}");
        Console.WriteLine($"Intersection: {string.Join(", ", resultSet4)}");


    }

    static HashSet<T> IntersectSets<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> resultSet = new HashSet<T>();

        //Intersection: common elements, no common elements, one is empty
        foreach (var item in set1)
        {
            if (set2.Contains(item))
            {
                resultSet.Add(item);
            }
        }
        return resultSet;
    }

    static HashSet<T> UnionSets<T>(HashSet<T> set1, HashSet<T> set2)
    {

        // Merge two sets and returns all unique values, first set is empty, both are empty
        HashSet<T> resultSet = new HashSet<T>();

        //Union: 
        foreach (var item in set1)
        {
            resultSet.Add(item);
        }
        foreach (var item in set2)
        {
            resultSet.Add(item);
        }

        return resultSet;
    }
}