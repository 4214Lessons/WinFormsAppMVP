﻿namespace Source.Models;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
    public float Score { get; set; }


    public Student()
    {
        Id = Guid.NewGuid();
    }

    public Student(string firstName, string lastName, DateOnly dateOfBirth, float score)
        : this()
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Score = score;
    }


    public override string ToString()
        => $"Id: {Id.ToString().Remove(8)}    FirstName: {FirstName}    DateofBirth: {DateOfBirth}    Score: {Score}";
}