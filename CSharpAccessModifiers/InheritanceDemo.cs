using System;
using DemoLibrary;

namespace ConsoleUI;

public class InheritanceDemo : AccessDemo
{
    private void Demo()
    {
        ProtectedDemo();
        // Access from the same assembly and where the class inherits the other class
        ProtectedInternalDemo();
    }

}

