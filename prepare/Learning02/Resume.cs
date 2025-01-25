using System;
//made by w00f
public class Resume
{
    public string _name;
    public List<Employment> _jobs = new List<Employment>();
    public void Display()
    {
        Console.WriteLine($"Name:{_name}");
        Console.WriteLine($"jobs:");

        foreach (Employment job in _jobs)
        {
            job.Display();
            //Console.WriteLine(job);
        }
    }
}