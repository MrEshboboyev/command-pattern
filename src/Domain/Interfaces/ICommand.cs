﻿namespace Domain.Interfaces;

public interface ICommand
{
    void Execute();
    void Undo();
}
