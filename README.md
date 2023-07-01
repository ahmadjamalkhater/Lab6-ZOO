# Zoo Management System

## Introduction
In this project, I have implemented a zoo management system using object-oriented programming principles. The system includes various animal classes with inheritance and polymorphism, allowing us to represent different categories of animals in the zoo.

## Digital UML Drawing
This is UML diagram a visual representation of the class hierarchy and relationships between different animal classes in the zoo.

![here](./Lab6-ZOO/ZOOUML.png)

## Technical Documentation : OOP Principles

#### Encapsulation
Encapsulation is the principle of bundling data and methods together within a class, providing control over access to the internal state of an object. In our zoo management system, each animal class encapsulates its specific attributes (name, age, weight) and behaviors (methods) within the class definition. By encapsulating data and methods, we ensure that they are accessed and modified only through the defined interfaces (properties and methods) of the class, promoting data integrity and encapsulation.

**Example in the project:** The `Animal` class encapsulates the `Name`, `Age`, `Weight`, and other properties, as well as the methods `Sound()`, `Sleep()`, and `Eat()`.

#### Inheritance
Inheritance is the principle of creating new classes (derived classes) from existing classes (base classes), inheriting their attributes and behaviors. It allows us to establish a hierarchy of classes, where derived classes inherit and extend the characteristics of their base classes. In our zoo management system, we have implemented inheritance to represent the relationships between different categories of animals. For example, the `Mammal` class inherits from the `Animal` class, and the `Horse` class inherits from the `Mammal` class.

**Example in the project:** The `Horse` class inherits attributes and behaviors from the `Mammal` class, which in turn inherits from the `Animal` class.

#### Polymorphism
Polymorphism is the principle of using a single interface (base class or interface) to represent different types of objects. It allows objects of different classes to be used interchangeably through a common interface, enabling code reuse and flexibility. In our zoo management system, we utilize polymorphism to treat different animals uniformly based on their common base class or interface. For example, we can store various animals in a list of type `Animal` and call their common methods without knowing the specific derived class.

**Example in the project:** The `Animal` class defines the `Sound()` method, which is overridden by each concrete animal class (e.g., `Horse`, `Dog`, `Snake`). We can call the `Sound()` method on any animal object regardless of its specific type.