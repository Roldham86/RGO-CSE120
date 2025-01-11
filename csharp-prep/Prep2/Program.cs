using System;
// made by w00f
class Program
{
    static void Main(string[] args)
    {
    // intial declarations
        string letter   = "!!Error: no value assined loc<letter>!!";
        string message  = "!!Error: no value assined loc<message>!!";
        string modifier = "!!Error: no value assined loc<modifier>!!";

    // prompt for grade
        Console.Write("What is your grade: ");
        string gradeStr = Console.ReadLine(); 

        int grade = int.Parse(gradeStr); // convert grade to int

    // determain letter greade condition
        if (grade == 90 || grade > 90 && grade < 100)
        {
            letter = "an A";
        }
        else if (grade == 80 || grade > 80 && grade < 90)
        {
            letter = "a B";
        }
        else if (grade == 70 || grade > 70 && grade < 80)
        {
            letter = "a C";
        }
        else if (grade == 60 || grade > 60 && grade < 70)
        {
            letter = "a D";
        }
        else if (grade > 0 && grade < 60)
        {
            letter = "an F";
        }
        else 
        {
            letter = "!!Error: else trigger loc<grade>!!";
        }

    // pass / fail condition 
        if (grade == 70 || grade > 70 && grade < 100)
        {
            message = "conGratualtions You Passed Your Class!";
        }
        else if (grade > 0 && grade < 70)
        {
            message = "Womp Wopm you failed, better luck next time";
        }
        else 
        {
            message = "!!Error: else trigger loc<pass/fail>!!";
        }

    // dertermain modifyer condition
        if (grade < 95 && grade > 60)
        {
            if (grade%10 > 7 || grade%10 == 3)
            {
                modifier = "+";
            }
            else if (grade%10 < 3 && grade%10 > 7)
            {
                modifier = "" ;
            }
            else if (grade%10 < 3 || grade%10 == 3)
            {
                modifier = "-" ;
            }
            else 
            {
                message = "!!Error: else trigger loc<madifier>!!";
            }
        }
        else 
        {
            modifier = "" ;
        }

    // Display out
        Console.WriteLine($"Your Grade is {letter}{modifier}.");   
        Console.WriteLine($"{message}"); 
        //Console.WriteLine("Hello Prep2 World!");
             
    }
}