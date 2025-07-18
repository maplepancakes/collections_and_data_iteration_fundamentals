namespace collections_and_data_iteration_fundamentals;

public class StackPractice
{
    public void ReverseString(String input)
    {
        char[] reversedCharacters = new char[input.Length];
        Stack<char> stack = new Stack<char>();
        foreach (char character in input)
        {
            stack.Push(character);
        }

        int stackCount = stack.Count;
        for (int i = 0; i < stackCount; i++)
        {
            reversedCharacters[i] = stack.Pop();
        }

        String result = new string(reversedCharacters);
        Console.WriteLine($"ReverseString: {result}");
    }

    public void IsPalindrome(String input)
    {
        char[] reversedCharacters = new char[input.Length];
        Stack<char> stack = new Stack<char>();
        
        foreach (char character in input)
        {
            stack.Push(character);
        }

        int stackCount = stack.Count;
        for (int i = 0; i < stackCount; i++)
        {
            reversedCharacters[i] = stack.Pop();
        }
        
        String reversedString = new string(reversedCharacters);
        bool result = true;
        for (int i = 0; i < reversedString.Length; i++)
        {
            if (input[i] != reversedString[i])
            {
                result = false;
                break;
            }
        }
        
        Console.WriteLine($"IsPalindrome: {result}");
    }

    public bool BalancedBrackets(String input)
    {
        bool result = true;
        if (input.Length % 2 != 0)
        {
            return false;
        }
        
        Stack<char> openBrackets = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '[' || input[i] == '{' || input[i] == '(')
            {
                openBrackets.Push(input[i]);
                continue;
            }
            
            char openBracket = openBrackets.Pop();
            
        }
        
    }
}