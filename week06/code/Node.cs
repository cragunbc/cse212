using System.Formats.Asn1;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // Value is the number to add to the tree and Data is the value of the node that we're looking at
        if (value == Data)
        {
            return;
        }
        else
        {
            // Insert to the left
            if (value < Data)
            {
                if (Left is null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            // Insert to the right
            if (value > Data)
            {
                if (Right is null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            if (Left != null)
            {
                return Left.Contains(value);
            }
        }
        if (value > Data)
        {
            if (Right != null)
            {
                return Right.Contains(value);
            }
        }
        return false;

    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Checks to see if the right and left are both null, in other words saying that it's only one node
        // in the list. If so then 1 is returned
        if (Left == null && Right == null)
        {
            return 1;
        }
        else
        {
            // Variable to get the left height. If left is not null then GetHeight is continually called
            // Otherwise -1 is returned
            int leftHeight = Left?.GetHeight() ?? -1;
            // Variable to get the right height. If right is not null then GetHeight is continually called
            // Otherwise -1 is returned
            int rightHeight = Right?.GetHeight() ?? -1;

            // Returns the highest plus 1 to account for the root node
            return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
        }
    }
}