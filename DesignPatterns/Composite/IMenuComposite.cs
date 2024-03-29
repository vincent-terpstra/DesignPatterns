﻿namespace DesignPatterns.Composite;

public interface IMenuComposite
{
    string Name { get; }
    string Description { get; }

    void Print();

    IEnumerable<MenuItem> GetMenuItems();
    IEnumerable<IMenuComposite> GetAllMenuComposites();
}