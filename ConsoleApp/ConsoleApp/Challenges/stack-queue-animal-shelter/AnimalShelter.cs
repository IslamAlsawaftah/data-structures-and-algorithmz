using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.stack_queue_animal_shelter
{
   
    public class AnimalShelter
    {
        public Queue<Cat> CatsQueue = new Queue<Cat>();
        public Queue<Dog> DogsQueue = new Queue<Dog>();

        public void enqueue(Animal animal)
        {
            //if(animal.GetType() == typeof(Cat))
            if (animal is Cat)
            {
                Cat cat = new Cat();
                //cat.Name = animal.Name;
                //cat.Type = animal.Type;
                CatsQueue.Enqueue(cat);
            }
            else if (animal is Dog)
            {
                Dog dog = new Dog();
                //dog.Name = animal.Name;
                //dog.Type = animal.Type;
                DogsQueue.Enqueue(dog);
            }
        }

        public Animal dequeue(string pref) {
            if (pref=="cat")
            {
                return CatsQueue.Dequeue();
       
            } else if (pref=="dog")
            {
                return DogsQueue.Dequeue();
            }
                return null;
            }
    }
}
