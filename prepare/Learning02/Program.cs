using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a job instance of Software Engineer at Microsoft from 2019 to 2022
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Test its display method
        //job1.Display();

        // Create a job instance of Manager at Apple from 2022 to 2023
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Test its display method
        //job2.Display();

        // Create an instance of Resume
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Test member attribute of resume
        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

        myResume.Display();
    }
}