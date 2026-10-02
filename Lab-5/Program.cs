namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Dog dog = new Dog("Shellby", 3, 15.5, "Female", "Dog", "Labrador");

        Cat cat = new Cat("Whiskers", 2, 10.2, "Male", "Cat", true);

            Lion lion = new Lion("Simba", 5, 420.0, "Male", "Lion", true);

            Bulldog bulldog = new Bulldog("Woofy", 4, 25.0, "Male", "Bulldog", "Bulldog", true); 

            Dalmatian dalmatian = new Dalmatian("Spots", 3, 20.0, "Female", "Dalmatian", "Dalmatian", 87);   

            dog.makeSound();
            cat.makeSound();
            lion.makeSound();
            bulldog.ShowWrinkles();
            dalmatian.ShowSpots();
        }
    }
}
