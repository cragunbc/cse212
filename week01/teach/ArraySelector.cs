public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select) // Method called ListSelector that requires the parameters of a list of integars called list1, list2, select
    {
        var result = new int[select.Length]; // Creates a new variable and assigns it a new array of integars equal to the length of the select array
        var index1 = 0; // Defines a new variable called index1 and sets it to 0
        var index2 = 0; // Defines a new variable called index2 and sets it to 0
        for (var i = 0; i < select.Length; i++)
        { // For loop that defines a new variable called i and sets it to 0, while i is less then the length of the select array, increase i with each interation
            if (select[i] == 1) // If the index of the select array is equal to 1
                result[i] = list1[index1++]; // The index of the new result array is equal to the index in list 1
            else // If the index of the select array is not equal to 1
                result[i] = list2[index2++]; // The index of the new result array is equal to the index in list 2
        }

        return result; // Returns the new result array
    }
}