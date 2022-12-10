class Program
{
    static void Main(string[] args)
    {
        Tree<string> Tree = new Tree<string>();
        Stack<string> Finding = new Stack<string>();
        bool Met = false;

        Tree.addingRootNode();
        int countNum = 0;

        do
        {
            string PeopleName = Console.ReadLine();
            int Node = int.Parse(Console.ReadLine());
            Tree.AddForTree(PeopleName, Node);
            countNum++;

        } while (Tree.GetLength() != countNum);

        string vacationName = Console.ReadLine();
        Tree.FindAns(Tree.getRoot(), vacationName, ref Finding, ref Met);


    }
}