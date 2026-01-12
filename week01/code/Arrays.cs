using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // How to solve the problem: Reverse engineering can be used when calculating the remainder of a division:
        // 1. Create a fixed array that will store "length" amount of numbers. Then declare "multiple" as 1, which will be used to multiplicate to "number".
        // 2. Create a loop that will iterate "lenght" times. In other words, as long as "i" is less than "length". Declare "i" as 0 and make it go up in each iteration.
        // 3. Inside the loop, the fixed array in position "i" will store the value "number" times "multiple".
        // 4. Inside the loop, add 1 to "multiple".
        // 4. Outside the loop, return the array.

        var result = new double[length];
        var multiple = 1;


        for (int i = 0; i < length; ++i)
        {
            result[i] = number * multiple;
            multiple++;
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Comments here!
        // 1. Take the data array and slice it in 2 parts: the first part will be the numbers that must go to the right (from index 0 to all the numbers minus the ones that must go to the left), the second part are the numbers that must go to the left (index is data's lenght - amount to amount).
        // 2. Append the right part to the end of the left part: leftPart adds rightPart to the end of the leftPart array.
        // 3. Create a for loop that iterates as long as data's length, starts from 0 and increases by 1 each iteration.
        // 4. Inside the loop, replace each index from data with the values from leftpart. Basically you are copying the data from the new array (leftpart) into the original array (data).

        var leftPart = data.GetRange(0, data.Count - amount);
        var rightPart = data.GetRange(data.Count - amount, amount);
        rightPart.AddRange(leftPart);

        
        for (int i = 0; i < data.Count; i++)
        {
            
            data[i] = rightPart[i];
        }


    }
}
