using System;
// The parent class
public class Employee
{
    public float salary = 40000;
}
//The first child class under inheritance
public class Programmer : Employee
{
    public float Developersbonus = 10000;
}
//The second child class under inheritance
public class Animator : Employee
{
    public float Animatorbonus = 8000;
}
//The third child class under inheritance
public class Designers : Employee
{
    public float Designersbonus = 5000;
}
