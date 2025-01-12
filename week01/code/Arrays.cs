using System.Globalization;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length) // number = the number you're wanting to know the multiple of, length = the amount of numbers you're wanting
    {
        // 1. Create a new array of doubles that will store the multiples after they're calculated
        double[] results = new double[length];
        // 2. Creates a for loop in a variable of int i equal to 0, while i is less then length (provided as the parameter), increase i by 1 with each iteration
        for (int i = 0; i < length; i++)
        {
            // 3. Create a variable called outcome and assign it the result of the number provided as the parament times i + 1
            double outcome = number * (i + 1);
            // 4. Assign the result of the outcome to the index of the results array, starting with position 1 since position 0 was done at the top
            results[i] = outcome;
        }

        // 5. Returns the array list after the calculations are done
        return results;
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
        // 1. Creates a new list with the number that are removed from the data list
        List<int> removals = data.GetRange(data.Count - amount, amount); // Gets the range of the amount of numbers in the list minus the amount you're wanting to remove, how many you're wanting to remove
        // 2. Removes the integars from the list of data
        data.RemoveRange(data.Count - amount, amount); // Gets the range of the amount of numbers in the list minus the amount you're wanting to remove, the amount you're wanting to remove
        // 3. Inserts the integars that were removed at the beginning of the array
        data.InsertRange(0, removals); // Identifies where you want to add the array, in this case index zero, inserts the numbers you're specifiying

    }
}
