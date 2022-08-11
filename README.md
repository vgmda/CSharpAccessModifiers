## CSharpAccessModifiers

> An access modifier in C# specifies who can see and use a resource. These are mainly used to restrict unwanted data manipulation by external programs or classes. There are **4** access modifiers (public, protected, internal, private) which defines the **6 accessibility levels** as follows.

## Six different access modifiers:

| Access Modifier | Description |
| --- | --- |
| `Private` | Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members. |
| `Internal` | The code is only accessible within its own assembly, but not from another assembly. |
| `Public` | The code is accessible for all classes. |
| `Protected` | The type or member can be accessed only by code in the same class, or in a class that is obtained from that class. |
| `Private Protected` | The type or member can be accessed by types derived from the class that are declared within its containing assembly. |
| `Protected Internal` | The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly. |

The situation when a class with a protected internal element and an instantiated instance of this class are in the same assembly. In this case, access from the class instance to the protected internal element is (extension of the internal keyword). There is also access from a derived class (extension of the protected keyword).
The situation when a class with a protected internal element is declared in one assembly and an instance of this class is created in another assembly. In this case, the instance does not have access to the protected internal element (internal constraint). But you can create a derived class and from this class access the protected internal element (extension protected).

There are many benefits of using an access modifier. Above all, the accessibility of class members can be controlled at will. In other words, access modifiers prevent users to access sensitive data. This prevents accidental or malicious changes to the data.
