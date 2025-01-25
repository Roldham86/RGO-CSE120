using System.Security.Cryptography.X509Certificates;
using System;
//made by w00f
public class Employment 
{
    public string _title;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"   {_title} ({_company}) {_startYear}-{_endYear}");
    }
}
