﻿namespace MyApp1.Model.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }//globally unic identifier(GUID)
        public required string Name { get; set; }
        public required string  Email { get; set; }
        public  string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
