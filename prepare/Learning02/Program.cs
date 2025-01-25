using System;
//made by w00f
class Program
{
    static void Main(string[] args)
    {
        Employment job1 = new Employment ();
        job1._title = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //DEbug//job1.Display();

        Employment job2 = new Employment();
        job2._title = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //DEbug//job2.Display();

        //Console.WriteLine($"Hello Learning02 World!{job1._title}");

        Resume myResume = new Resume ();
        myResume._name = "Kaito Rex";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
    }
}