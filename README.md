# S2016-421 Object-Oriented Programming

# Homework


## Homework 1 - Due Feb. 3, 2016

Create two or 3 classes that represent a real-world system or something or some subject you are familiar with or is of interest to you.
Do not model a concept in computer science like a list or tree.
Which parts of your system should be defines as Properties and which should be defined as Member Variables.
What is the public interface (Member Functions) for your system?
Don't forget to pick a sweet name for your default namespace. 

## Homework 2 - Due Feb. 15, 2016

Implement a class heirachy using a base class and derived classes to implement a weapon for the Oops.Game.Player class.
Think about what properties should be exposed through the base class interface, and what should be internal to the derived classes.
As always, simpler is better - and follow the guidelines below.

Use the General Guidelines below.

# General Guidelines for OOP

The following is a general list of do's and don'ts to remember when designing software.

## Style

* KISS: Keep it Simple, Stupid. (US Navy, 1960)
* DO use Pascal- or OO-casing.  That is, capitalize the first letter of every word (`DateTime`, `StreamWriter`, `EntryPointNotFoundException`, ...).
* DO NOT capitalize all the letters of an abreviation; `HttpRequest` not `HTTPRequest`.
* DO put each class/struct/enum into it's own file.
* DO use sub-directories to reflect nested namespaces.  For example, the class `MyNamespace.MyTech.MyClass` should be located in the folder `./MyNamespace/MyTech/MyClass`.
* Use braces consistently.  
* Prefer key words to built-in types; i.e. bool vs Boolean, int vs Int32, string vs. String, etc...

## Namespaces

* DO use namespaces.
* Your namespace is your brand.  Make it unique, but do not make the names lengthy or unwieldy.
* DO use namespaces to avoid name conflicts.  If you have two classes both called `Message`, put them in separate namespaces.
* Use nested namespaces to group related classes/structs/enums together.
* DO NOT define anything in the global namespace.  This is reserved for special classes/structures/enums.
* DO use `using` clauses to import namespaces into scope, but ONLY namespaces for objects you are referencing.  This helps keep code looking clean and precise.

## Classes

* Give classes names that describe what they are.  For instance, guess what the `Car` defines.
* DO NOT give classes names that are overly generic; `Object` and `Element` for example.  Instead consider prefixing the class name with a type, like `JsonObject` or `XElement`.
* DO NOT create kitchen-sink classes.  Use the __Single Responsibily Principle__: A class should have one and only one responsibilty.

### Members
* DO use member variables to represent an object's internal state.
* DO NOT allow users to directly modify your classes member variables.  Mark them all as private.  

### Constructors, Destructors
* DO NOT implement a destructor.
* DO provide a constructor to initiazize invariant or non-defualt members.
* DO use exceptions to prevent objects from being partially constructed.
* DO NOT subvert the will of the user by replacing invalid constructor arguments with default values.  Throw an `InvalidArgumentException` instead.

### Methods
* DO use methods to modify member variables (i.e. change the state of your object).
* Only mark the methods that you want your users to call as public.  Everything else should be private.

### Properties
* DO use properties to represent observable characteristics of your class.


# Patterns

The following is a list of design patterns we've discussed in class and some basic guidelines for each.

## Factory Pattern


