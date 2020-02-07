using System;
using System.Collections.Generic;
using System.Text;

namespace Practice {
    class Major { //Class Major with properties id, description, and minsat
        public int id;
        public string description;
        public int minsat;

        public Major(int Id, string Description, int MinSAT) { //Method Major with input Id, Description, and MinSAT
            id = Id;
            description = Description;
            minsat = MinSAT;
            }//Major constructor
        public void Print() { //Method Print to display properties
            Console.WriteLine($"The {description} major has an ID of {id} and Minimum SAT Score of {minsat}.");
            } //print method
        } //class Major
    class Student {
        public string firstname;
        public string lastname;
        public int sat;
        public double gpa;
        public Major major; //must be an existing Major class
        public int id;

        public Student(int Id, string Firstname, string Lastname, int SAT, double GPA, Major Major) {
            id = Id;
            firstname = Firstname;
            lastname = Lastname;
            sat = SAT;
            gpa = GPA;
            major = Major;
            }
        public void Print() { //Method Print to display properties
            Console.WriteLine($"Student {firstname} {lastname} has a major of {major.description}, an SAT Score of {sat}, and GPA of {gpa}.");
            } //print method
        }//Class Student
    class Instructor {
        public int id;
        public string firstname;
        public string lastname;
        public int yrsexp;
        public bool tenure;

        public Instructor(int Id, string Firstname, string Lastname, int EXP, bool Tenure = false) {
            id = Id;
            firstname = Firstname;
            lastname = Lastname;
            yrsexp = EXP;
            tenure = Tenure;
            }
        public void Print() { //Method Print to display properties
            Console.WriteLine($"Instructor {firstname} {lastname} has {yrsexp} years of experience" + ((tenure == true) ? " and is tenured." : "."));
            } //print method
        }
    class Course {
        public int id;
        public string description;
        public int section;
        public Instructor instructor;
        public Course(int Id, string Description, int Section, Instructor Instructor) { //how can i set the instructor to null or TBD?
            id = Id;
            description = Description;
            section = Section;
            instructor = Instructor;
            }
        public void Print() { //Method Print to display properties
            Console.WriteLine($"Course {description} is {section} and is taught by {instructor.lastname}.");
            } //print method
        } //end of course class

    }//namespace Practice
