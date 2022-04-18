using ConsoleApp.Challenges.stack_queue_animal_shelter;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class TestAnimalShelter
    {
        AnimalShelter animalShelter = new AnimalShelter();
        Dog dog = new Dog();
        Cat cat = new Cat();

        [Fact]
        public void TestEnqueueDequeueDog()
        {
            animalShelter.enqueue(dog);
            Assert.True(animalShelter.DogsQueue.Dequeue() is Dog);
        }
        [Fact]
        public void TestEnqueueDequeueCat()
        {
            animalShelter.enqueue(cat);
            Assert.True(animalShelter.CatsQueue.Dequeue() is Cat);
        }
        [Fact]
        public void TestDequeueNull()
        {
            animalShelter.enqueue(dog);
            Assert.Null(animalShelter.dequeue("horse"));
        }
        [Fact]
        public void TestDequeueCat()
        {
            Cat cat2 = new Cat();
            animalShelter.enqueue(cat);
            Assert.NotEqual(cat2, animalShelter.dequeue("dog"));
        }
    }
}
