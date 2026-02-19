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

        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        //base case
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
        else if (value > Data)
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

        int leftH = 1;
        int rightH = 1;


        //base case
        if (Left is null && Right is null)
        {
            return 1;
        } 
        

            if (Left is not null)
            {
                leftH = Left.GetHeight();
            } 

            if (Right is not null)
            {
                rightH = Right.GetHeight();
            }


        

        return Math.Max(leftH, rightH) + 1;

        // return Math.Max(Left.GetHeight(), Right.GetHeight()) + 1;


    }
}