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
        // Create an array of type double with the given length.
        // This array will store all the multiples of the given number. 
        double[] multiples = new double[length];

        // A loop is used to go through each index of the array.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
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
        // TODO Problem 2 Start
        //Determine how many items will be moved from the end of the list.
        int splitIndex = data.Count - amount;

        // Get the portion of the list that will move to the front.
        List<int> rightPart = data.GetRange(0,splitIndex);

        //Get the remaining portion of the list 
        List<int> LeftPart = data.GetRange(0, splitIndex);

        //Clear the original list.
        data.Clear();

        //Add the right part to the front 
        data.AddRange(rightPart);
        
    }
}
