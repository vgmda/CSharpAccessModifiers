# CSharpAccessModifiers

> An access modifier in C# specifies who can see and use a resource. These are mainly used to restrict unwanted data manipulation by external programs or classes. There are **4** access modifiers (public, protected, internal, private) which defines the **6 accessibility levels** as follows.

### Six different access modifiers:

*   `Private` - Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.
*   `Internal` - The code is only accessible within its own assembly, but not from another assembly.
*   `Public` - The code is accessible for all classes.
*   `Protected` - The type or member can be accessed only by code in the same class, or in a class that is obtained from that class.
*   `Private Protected` - The type or member can be accessed by types derived from the class that are declared within its containing assembly.
*   `Protected Internal` - The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
