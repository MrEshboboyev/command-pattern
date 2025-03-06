﻿namespace CommandPatternInConsole.Interfaces.Implementations;

// However, some commands can delegate more complex operations to other objects,
// called "receivers."
public class ComplexCommand : ICommand
{
    private Receiver _receiver;

    // Context data required for launching the receiver's methods.
    private string _a;
    private string _b;
    public ComplexCommand(Receiver receiver, string a, string b)
    {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    // Commands can delegate to any methods of a receiver.
    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
