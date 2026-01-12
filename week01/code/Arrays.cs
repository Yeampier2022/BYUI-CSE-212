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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // step 1  get the list

        List<double> results = new();

        // step 2 to do for for obtener the multiples


        for (int i = 0; i < length; i++)
        {
            double multiple = number * (i + 1);
            results.Add(multiple);
        }

        // step 3  show the result of the list in array

        return results.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<double> RotateListRight(List<int> data, int amount)
    {
        // Step 1: Handle edge cases - if data is null or empty, return empty list
        if (data == null || data.Count == 0)
        {
            return new List<double>();
        }

        // Step 2: Calculate the split point for right rotation
        // Elements from splitIndex to end will move to the front
        int splitIndex = data.Count - amount;

        // Step 3: Get the part that needs to move to the front
        List<int> secondPart = data.GetRange(splitIndex, amount);

        // Step 4: Remove the second part from its original position
        data.RemoveRange(splitIndex, amount);

        // Step 5: Insert the second part at the beginning
        data.InsertRange(0, secondPart);

        // Step 6: Convert the modified list to List<double> for return
        // This maintains compatibility with the method signature
        List<double> result = new List<double>();
        foreach (int num in data)
        {
            result.Add((double)num);
        }

        return result;
    }
}
