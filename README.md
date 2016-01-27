# S2016-421 Object-Oriented Programming


# General Guidelines for OOP

The following is a general list of do's and don'ts to remember when designing software.

## Style

* DO use Pascal- or OO-casing.  That is, capitalize the first letter of every word (`DateTime`, `StreamWriter`, `EntryPointNotFoundException`, ...).
* DO NOT capitalize all the letters of an abreviation; `HttpRequest` not `HTTPRequest`.
* DO put each class/struct/enum into it's own file.
* DO use sub-directories to reflect nested namespaces.  For example, the class `MyNamespace.MyTech.MyClass` should be located in the folder `./MyNamespace/MyTech/MyClass`.

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


