using System;

public class Program
{
    public static void Main(string[] args)
    { 
        var cachorro = new Cachorro();
        cachorro.EmitirSom();

        var gato = new Gato();
        gato.EmitirSom();
    }
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som do animal");
        }
    }
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au au au au");
        }
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau miau");
        }
    }
}