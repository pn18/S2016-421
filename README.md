# S2016-421 Object-Oriented Programming


# General Guidelines for OOP

The following is a general list of do's and don'ts to remember when designing software.

## Namespaces

* DO use namespaces.
* Your namespace is your brand.  Make it unique, but do not make the names lengthy or unwieldy.
* DO use namespaces to avoid name conflicts.  If you have two classes both called `Message`, put them in separate namespaces.
* Use nested namespaces to group related classes/structs/enums together.
* DO NOT define anything in the global namespace.  This is reserved for special classes/structures/enums.
* DO use `using` clauses to import namespaces into scope, but ONLY namespaces for objects you are referencing.  This helps keep code looking clean and precise.

## Classes

* Give classes names that describe what they are.  
* DO NOT give classes names that are overly generic; `Object` and `Element` for example.  Instead consider prefixing the class name with a type, like `JsonObject` or `XElement`.

