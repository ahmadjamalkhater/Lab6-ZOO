# Zoo Management System

## Introduction
In this project, I have developed a zoo management system that utilizes object-oriented programming principles. The system incorporates various animal classes with inheritance and polymorphism concepts, enabling the representation of different animal categories within the zoo.

## Digital UML Drawing
This is UML diagram a visual representation of the class hierarchy and relationships between different animal classes in the zoo.

![here](./Lab7-ZOO/ZOOUMLLab7.png)

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

### Interface
An interface, is a blueprint or contract that defines a set of methods or properties that a class must implement. It establishes a common behavior or functionality that multiple classes can adhere to, promoting code consistency and allowing objects of different classes to be treated uniformly based on their shared interface.

### Interfaces in my Project

1. `IAttack` : This interface defines the behavior of attacking. It includes a method `MightAttack()` that represents the action of attacking. The interface is implemented by classes representing animals capable of attacking, such as Horse , Snake and Dog.

```

public interface IAttack
{
    void MightAttack();
}

```


2. `IClimb` : This interface defines the behavior of climbing. It includes a method Climb() that represents the action of climbing. The interface is implemented by classes representing animals capable of climbing, such as the Horse, Turtle, and Cat classes.

```

public interface IClimb
{
    void MightAttack();
}

```

**the Horse Class** 

```

//<IAttack> implementation
public string MightAttack()
{
return "If I'm afraid of you, I may kick or fight back as a defense!";
}

//<IClimb> implementation
public string MightClimb()
{
return "I can climb up and down stairs. Also, mountains!";
}

```        


**the Snake class**

```

//<IAttack> implementation
public string MightAttack()
{
return "If provoked or threatened, I attack!";
}

```   


**the Dog class**

```

//<IAttack> implementation
public string MightAttack()
{
return "If I feel threatened, guarding my food I may attack as a defense!";
}

``` 

**the Turtle Class** 

```

//<IClimb> implementation
public string MightClimb()
{
return "I can climb Trees!";
}

``` 

**the Cat Class** 

```

//<IClimb> implementation
public string MightClimb()
{
return "We are built to climb and jump! walls, fences, trees.. more and more!";
}

``` 