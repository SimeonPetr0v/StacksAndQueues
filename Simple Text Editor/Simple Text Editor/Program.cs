namespace Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            var textStack = new Stack<string>();
            textStack.Push("");

            for (int i = 0; i < numberOfOperations; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                switch (command)
                {
                    case "1":
                        string currentText = textStack.Peek() + input[1];
                        textStack.Push(currentText);
                        break;
                    case "2":
                        string previousText = textStack.Peek();
                        int elementsToRemove = int.Parse(input[1]);
                        string newString = previousText.Substring(0, previousText.Length - elementsToRemove);
                        textStack.Push(newString);
                        break;
                    case "3":
                        string allTheText = textStack.Peek();
                        int indexToReturn = int.Parse(input[1]);
                        Console.WriteLine(allTheText[indexToReturn - 1]);
                        break;
                    case "4":
                        textStack.Pop();
                        break;
                }
            }
        }
    }
}