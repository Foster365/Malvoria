using System.Collections.Generic;

public class ActionNode<T> : INode<T>
{
    // Delegate that takes a parameter of type T
    public delegate void ActionDelegate(T value);
    private ActionDelegate action;

    // Constructor that takes an ActionDelegate (a method with a parameter of type T)
    public ActionNode(ActionDelegate action)
    {
        this.action = action;
    }

    // Execute method that requires a value of type T to execute the delegate
    public void Execute(T value)
    {
        // Invoke the action delegate with the value of type T
        action(value);
    }
}
