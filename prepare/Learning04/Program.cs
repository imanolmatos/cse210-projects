using System;

class Program
{
    static void Main(string[] args)
    {

    //FIRST 
     Assignment assignment = new Assignment("Mario Perez","Historia");
    string display = assignment.GetSummary();
    Console.WriteLine($"{display}");
        
    //SECOND
    MathAssignment a2 = new MathAssignment ("Roberto Rodriguez","Fractions","Section 7.3", "Problems 8-19");
    string a2Display = a2.GetSummary();
    Console.WriteLine($"{a2Display}");
    string a2HomeworkList = a2.GetHomeworkList();
    Console.WriteLine($"{a2HomeworkList}");
    
    //THIRD
    WritingAssignment a3 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
    string a3Display = a3.GetSummary();
    Console.WriteLine($"{a3Display}");
    string a3HomeworkList = a3.GetWritingInformation();
    Console.WriteLine($"{a3HomeworkList}");


    }
}
