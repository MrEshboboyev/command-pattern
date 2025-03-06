// The Client code can parameterize an invoker with any commands
using CommandPatternInConsole;
using CommandPatternInConsole.Interfaces.Implementations;

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();