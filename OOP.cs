//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            
            //create animal
            Animal fox = new Animal();
           
            fox.MakeSound();
            fox.sound= "dksad";
            fox.name="dsasadasd";
            fox.MakeSound();
            
            //call static method
             Console.WriteLine(Animal.GetAnimal());
            
                Animal wolf = new Animal();
            
            //call static method
             Console.WriteLine(Animal.GetAnimal());
           
        }
    }
    
    
    
    public class Animal {
            public string name;
            public string sound;
            public static int counter = 0;
        
        public Animal(string name = "No name", string sound = "No sound"){
            
            //name = n 
            this.name = name;
            this.sound = sound;
            counter++;
            
   
            
    
    }
        public virtual void MakeSound(){
              Console.WriteLine(name);  
              Console.WriteLine(sound);
        }
        
        public static int GetAnimal(){
                return counter;
        }

    
    }//class
    
    
    public class Mamifer:Animal {
        
        public override void MakeSound(int numberSounds=0){
            Console.WriteLine("mammel");
            numberSounds ++;
            
        }
}
