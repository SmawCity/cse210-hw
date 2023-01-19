using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Bethesda";
        job1._jobStartYear = 2019;
        job1._jobEndYear = 2023;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Planner";
        job2._jobCompany = "General Dynamics";
        job2._jobStartYear = 2012;
        job2._jobEndYear = 2019;

        Resume myResume = new Resume();
        myResume._name = "Christopher Larson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}