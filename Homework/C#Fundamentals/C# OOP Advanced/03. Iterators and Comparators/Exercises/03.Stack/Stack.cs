using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private readonly List<T> myStack;

    public Stack()
    {
        this.myStack = new List<T>();
    }

    public void Push(params T[] inputElements)
    {
        this.myStack.AddRange(inputElements);
    }

    public void Pop()
    {
        if (myStack.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
        this.myStack.RemoveAt(myStack.Count - 1);
    }

    public void End()
    {
        StringBuilder sb = new StringBuilder();
        if (this.myStack.Count > 0)
        {
            for (int j = 0; j < 2; j++)     
            {
                for (int i = this.myStack.Count - 1; i >= 0; i--)
                {
                    sb.AppendLine($"{myStack[i]}");
                } 
            }

            string result = sb.ToString().Trim();
            Console.WriteLine(result);
        }
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.myStack.Count; i++)
        {
            yield return this.myStack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

