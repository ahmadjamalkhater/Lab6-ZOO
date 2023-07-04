using Lab6_ZOO;
using Lab7_ZOO;

namespace TestLab7_ZOO
{
    public class UnitTest1
    {
        //Tests of Horse
        [Fact]
        public void Horse_Sound_Test()
        {
            // Arrange
            var horse = new Horse("Bella", 5, 500, "Brown");

            // Act
            string sound = horse.Sound();

            // Assert
            Assert.Equal("Neigh!", sound);
        }

        [Fact]
        public void Horse_GiveBirth_Test()
        {
            // Arrange
            var horse = new Horse("Lily", 7, 600, "Brown");

            // Act
            string sound = horse.GiveBirth();

            // Assert
            Assert.Equal("The horse gives birth to a foal.", sound);
        }

        //Tests of Dog
        [Fact]
        public void Dog_Sleep_Test()
        {
            // Arrange
            var dog = new Dog("Max", 3, 20, "White");

            // Act
            string sleepAction = dog.Sleep();

            // Assert
            Assert.Equal("The dog is lying down and resting.", sleepAction);
        }

        [Fact]
        public void Dog_Sound_Test()
        {
            // Arrange
            var dog = new Dog("Buddy", 2, 12, "Black");

            // Act
            string Sound = dog.Sound();

            // Assert
            Assert.Equal("Woof woof!", Sound);
        }

        //Tests of Cat
        [Fact]
        public void Cat_Domesticated_Test()
        {
            // Arrange
            var cat = new Cat("Zizi", 3, 3, "White");

            // Act
            string LiveInsideHomesAction = cat.LiveInsideHomes();

            // Assert
            Assert.Equal("People love cats to cuddle with them.", LiveInsideHomesAction);
        }

        [Fact]
        public void Cat_Sound_Test()
        {
            // Arrange
            var cat = new Cat("Sally", 2, 4, "Gray");

            // Act
            string Sound = cat.Sound();

            // Assert
            Assert.Equal("Meow!", Sound);
        }

        //Tests of Snake
        [Fact]
        public void Sanke_LayEggs_Test()
        {
            // Arrange
            var snake = new Snake("Sniky", 1, 3, "Green");

            // Act
            string LayEggsAction = snake.LayEggs();

            // Assert
            Assert.Equal("The snake lays eggs.", LayEggsAction);
        }

        [Fact]
        public void Snaket_Sound_Test()
        {
            // Arrange
            var snake = new Snake("Loli", 1, 3, "Green");

            // Act
            string Sound = snake.Sound();

            // Assert
            Assert.Equal("Hiss!", Sound);
        }


        //Tests of Turtle
        [Fact]
        public void Turtle_Sunbathe_Test()
        {
            // Arrange
            var turtle = new Turtle("Taco", 120, 9, "Green");

            // Act
            string SunbatheAction = turtle.Sunbathe();

            // Assert
            Assert.Equal("The turtle basks in the sun to warm up.", SunbatheAction);
        }

        [Fact]
        public void Turtle_Sleep_Test()
        {
            // Arrange
            var turtle = new Turtle("Flippy", 100, 12, "Black");

            // Act
            string sleepAction = turtle.Sleep();

            // Assert
            Assert.Equal("The turtle finds a safe spot and rests.", sleepAction);
        }

        ////////////////////////////////////////////////////Lab7 tests starts///////////////////////////////////////////////////////////////////////////////////////////////

        [Fact]
        public void HorseDoIAttackAndIClimb() //Test that the classes that implement the interface actually implement it
        {
            Horse horse = new Horse("Gece", 3, 400, "Black");

            Assert.IsAssignableFrom<IAttack>(horse);
            Assert.IsAssignableFrom<IClimb>(horse);
        }

        [Fact]
        public void DogDoIAttack() //Test that the classes that implement the interface actually implement it
        {
            Dog dog = new Dog("Jack", 2, 10, "White");

            Assert.IsAssignableFrom<IAttack>(dog);
        }

        [Fact]
        public void TurtleDoIClimb() //Test that the classes that implement the interface actually implement it
        {
            Turtle turtle = new Turtle("Penny", 100, 7, "Dark Brown");

            Assert.IsAssignableFrom<IClimb>(turtle);
        }

        [Fact]
        public void CatDoIClimb() //Test that the classes that implement the interface actually implement it
        {
            Cat cat = new Cat("Karamel", 2, 5, "cinnamon");

            Assert.IsAssignableFrom<IClimb>(cat);
        }

        [Fact]
        public void SnakeDoIAttack() //Test that the classes that implement the interface actually implement it
        {
            Snake snake = new Snake("Slinky", 1, 3, "Yellow");

            Assert.IsAssignableFrom<IAttack>(snake);
        }

        [Fact]
        public void InheritanceTest() //Test inheritance
        {
            //Horse class inherits from the Mammal class
            Horse horse = new Horse("Gece", 3, 400, "Black");

            // Test that the horse object has inherited the properties from the Mammal class
            Assert.Equal("Gece", horse.Name);
            Assert.Equal(3, horse.Age);
            Assert.Equal(400, horse.Weight);
            Assert.Equal("Black", horse.FurColor);

            // Test that the horse object has inherited the methods from the Animal class
            Assert.Equal("Neigh!", horse.Sound());
            Assert.Equal("The horse gives birth to a foal.", horse.GiveBirth());
        }


        [Fact]
        public void PolymorphismTest() //Prove methods have been overridden
        {

            Snake snake = new Snake("Slinky", 1, 3, "Yellow");


            Assert.Equal("Hiss!", snake.Sound());
            Assert.Equal("The snake lays eggs.", snake.LayEggs());
        }

        [Fact]
        public void HorseIsAnimal() //Prove that one of your concrete animals is an Animal
        {
            Horse horse = new Horse("Gece", 3, 400, "Black");

            Assert.IsAssignableFrom<Animal>(horse);
        }


    }
}