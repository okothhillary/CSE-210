using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LinkedIn Resume");

        
        Job job1 = new Job(); 
        job1._jobTitle = "Software Engineer"; 
        job1._company = "Flow Yetu"; 
        job1._startYear = "2024"; 
        job1._endYear = "2075";

        Resume myResume = new Resume();
        myResume._name = "Hillary Okoth";
        myResume._jobs.Add(job1);

        myResume.Display();


        
       

    }
}