# Challenge Summary

Multi-bracket Validation.Parenthesis/Brackets Matching using Stack algorithm

# Whiteboard Process

![](whiteboard.png)

# Approach & Efficiency

ValidateBrackets(x) : Time/Complexity => O(n)

# API

### ValidateBrackets(x): 

1- if str equal null return true, Initialize a Stack.

2- Iterate the input string, one character at a time.

3- Check if character is open bracket
  * ‘(‘, if yes then push closed bracket ‘)’ to stack.
  
  * ‘[‘, if yes then push closed bracket ‘]’ to stack.
   
  * ‘{‘, if yes then push closed bracket ‘}’ to stack

4- Else check if character is close bracket, either ‘)‘ or ‘]’ or ‘}’  if yes then

5- Check if stack is empty, if yes return false.

6- Else if stack is not empty, pop from stack and popped bracket should be same as current bracket else return false.

7- If at the end stack is empty, return true else return false.

### Result

```
  Console.WriteLine(ValidateBrackets("()[[Extra Characters]]"));
  Console.WriteLine(ValidateBrackets("{}(){}"));
  Console.WriteLine(ValidateBrackets("[({}]"));
  Console.WriteLine(ValidateBrackets("("));
```

![](result.png)
