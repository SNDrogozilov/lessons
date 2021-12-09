using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._12._2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human humanObject = new Human();
            humanObject.Name = null;
            humanObject.Age = 0;
            humanObject.IsHaveCar = false;
            humanObject.IsHaveCar = false;
            humanObject.Result();

            Human human1 = new Human();
            human1.Age = 30;
            Human human2 = new Human();
            human2.Age = 20;
            string whoIsOlder = human1.Age > human2.Age ? "human1 older human2" : "human2 older human1";
            Console.WriteLine(whoIsOlder);

            var cube = new Cube();
            cube.Move();

            Console.ReadLine();


        }

    public class Human
        {
            private string _name;
            private int _age;
            private bool _isHaveCar;
            private bool _isHavePet;

            public string Name
            {
                get { return _name; }
                set
                {
                    if (value is null)
                    {
                        _name = "Петр";
                    }
                }
            }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        _age = value;
                    }
                }
            }
            public bool IsHaveCar
            {
                get { return _isHaveCar; }
                set { _isHaveCar = false; }
            }
            public bool HasPet
            {
                get { return _isHavePet; }
                set { _isHavePet = false; }
            }
            public Human()
            {
                _name = null;
                _age = 0;
                _isHaveCar = false;
                _isHavePet = false;
            }
            public void Result() => Console.WriteLine($"Human name is {_name}, Human age is {_age}, " +
            $"Human have {_isHaveCar} car, Human have {_isHavePet} pet");
        }
    public class Cube
        {   
            private float _positionX;
            private float _positionY;
            private char _moveButton;

            public Cube()
            {
                _positionX = 0;
                _positionY = 0;
                _moveButton = ' ';
            }

            public float PositionX
            {
                get { return _positionX; }
                set { _positionX = value; }
            }
            public float PositionY
            {
                get { return _positionY; }
                set { _positionY = value; }
            }
            public char MoveButton
            {
                get { return _moveButton; }
                set { _moveButton = value; }
            }

            public void Move()
            {
                while (_moveButton!='q')
                {
                    MoveButton = char.Parse(Console.ReadLine());
                    switch (_moveButton)
                    {
                        case 'w':
                            _positionY++;
                            break;
                        case 's':
                            _positionY--;
                            break;
                        case 'a':
                            _positionX--;
                            break;
                        case 'd':
                            _positionX++;
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    Console.WriteLine($"{_positionY} {_positionX}");
                }
            }
        }
    }
}
