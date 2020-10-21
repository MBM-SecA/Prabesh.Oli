using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name =  "Last Name")]
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    //Object initializer syntax
    public static List<Person> GetEmployee()
    {

        Person emp1 = new Person()
        {
            Id = 1,
            FirstName = "Prabesh",
            SurName = "oli",
            Address = "Bankey",
            Salary = 200.0


        };
        Person emp2 = new Person()
        {
            Id = 2,

            FirstName = "Rames",
            SurName = "oli",
            Address = "butwal",
            Salary = 200.0


        };
        Person emp3 = new Person()
        {
            Id = 3,
            FirstName = "Shyam",
            SurName = "oli",
            Address = "pokhara",
            Salary = 200.0


        };
        Person emp4 = new Person()
        {
            Id = 4,
            FirstName = "Hari",
            SurName = "oli",
            Address = "kathmandu",
            Salary = 200.0
        };
        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4 };
        return employees;

    }

}