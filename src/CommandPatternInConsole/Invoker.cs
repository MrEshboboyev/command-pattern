﻿using CommandPatternInConsole.Interfaces;

namespace CommandPatternInConsole;

// The Invoker associated with one or several commands.
// It sends a request to the command.
public class Invoker
{
    private ICommand _onStart;
    private ICommand _onFinish;

    // Initialize Commands
    public void SetOnStart(ICommand command)
    {
        _onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        _onFinish = command;
    }

    // The Invoker does not depend on concrete command or receiver classes.
    // The Invoker passes a request to a receiver indirectly, by executing a 
    // command
    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        if (_onStart is ICommand)
        {
            _onStart.Execute();
        }

        Console.WriteLine("Invoker: ... doing something really important ...");

        Console.WriteLine("Invoker: Does anybody want something done after I begin?");
        if (_onFinish is ICommand)
        {
            _onFinish.Execute();
        }
    }
}
