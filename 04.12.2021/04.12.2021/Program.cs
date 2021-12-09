using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._12._2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(10, "Plane Il-2", 555.5f);
            plane.ShowInfo();
            plane.Move();
            plane.Sound();

            Helicopter helicopter = new Helicopter(6, "Black Hawk", 654.6f);
            helicopter.ShowInfo();
            helicopter.Move();
            helicopter.Sound();

            Rocket rocket = new Rocket();
            rocket.Sound();
            rocket.Move();
            rocket.ShowInfo();

            Auto auto = new Auto(200, 4, "Black");
            auto.Move();
            auto.Sound();
            auto.ShowInfo();

            Bike bike = new Bike();
            bike.Sound();
            bike.Move();
            bike.ShowInfo();

            Ship ship = new Ship();
            ship.Sound();
            ship.Move();
            ship.ShowInfo();


            Console.ReadLine();
        }


    }
    public abstract class Technick
    {
        protected float volumeTank;
        protected string name;

        public abstract void Move();
        public abstract void Sound();
    }
    public class AirTransport : Technick
    {
        public override void Move()
        {
            Console.WriteLine("Air mooving");
        }
        public override void Sound()
        {
            Console.WriteLine("Air Sound");
        }
    }
    public class Plane:AirTransport
    {
        private int wingAmount = 0;
       
        public Plane(int wingAmount, string name, float volumeTank)
        {
            this.wingAmount = wingAmount;
            this.name = name;
            this.volumeTank = volumeTank;
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Plane sound");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Move plane");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"wingAmount = {wingAmount} volumeTank = {volumeTank} name = {name}");
        }
    }
    public class Helicopter : AirTransport 
    {
        private int helicopterBlades = 0;
        public Helicopter(int helicopterBlades, string name, float volumeTank)
        {
            this.helicopterBlades=helicopterBlades;
            this.name = name;
            this.volumeTank=volumeTank;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Helicopter is moving");
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Helicopter sound");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"helicopterBlades = {helicopterBlades}, name {name}, volumeTank {volumeTank}");
        }
    }
    public class Rocket : AirTransport
    {
        private int _speed;
        private string _name;
        private float _volumeTank;
        public Rocket()
        {
            _speed = 2000;
            _volumeTank = 1000;
            _name = "BFR";
        }
        public override void Move()
        {
            Console.WriteLine("Rocket is mooving");
        }
        public override void Sound()
        {
            Console.WriteLine("Rocket sound");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"speed = {_speed}, name {_name}, volumeTank {_volumeTank}");
            Console.WriteLine("__________________________________________________________\t");
        }
        
    } 
    public class GroundTransport: Technick
    {
        public override void Move()
        {
            Console.WriteLine("Ground Transport is moving");
        }
        public override void Sound()
        {
            Console.WriteLine("Ground Transport is sounding");
        }
    }
    public class Auto:GroundTransport
    {
        private float speed;
        private int wheels;
        private string colour;
        public Auto(float speed, int wheels, string colour)
        {
            this.speed = speed;
            this.wheels = wheels;
            this.colour = colour;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Auto is moving");
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Auto is sounding");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Speed Auto = {speed}, Auto has {wheels} wheels, Colour {colour}");
        }
    }
    public class Bike : GroundTransport
    {
        private int _wheels;
        private string _colour;
        private float _speed;
        private string _model;
        public Bike()
        {
            _wheels = 2;
            _colour = "Black";
            _speed = 350.5f;
            _model = "BMW";
        }
        public override void Move()
        {
            Console.WriteLine("Bike is moving");
        }
        public override void Sound()
        {
            Console.WriteLine("Bike is sounding");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Bike has {_wheels}, Colour is {_colour}, Move speed is {_speed}, Model is {_model}");
            Console.WriteLine("___________________________________________________________________________________");
        }
    }
    public class WaterTransport : Technick
    {
        public override void Move()
        {
            Console.WriteLine("Water transport is moving");
        }
        public override void Sound()
        {
            Console.WriteLine("Water transport sound");
        }
    }
    public class Ship : WaterTransport
    {
        private string _name;
        private string _color;
        private float _speed;
        public Ship()
        {
            _name = "Titanic";
            _color = "White";
            _speed = 60;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Titanic is moving");
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Ship sound");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ships name is {_name}, Ships colour is {_color}, Ships speed is {_speed}");
        }
    }

}
