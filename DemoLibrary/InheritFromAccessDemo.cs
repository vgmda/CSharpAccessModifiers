using System;
namespace DemoLibrary;

class InheritFromAccessDemo : AccessDemo
{

    public void Test()
    {
        // These methods can be called from the class where they were created OR -
        // inside the class that inherits the original class
        // Can be used as a helper methods
        ProtectedDemo();
        InternalDemo();

    }

}

