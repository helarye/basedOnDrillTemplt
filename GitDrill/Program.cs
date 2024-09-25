// See https://aka.ms/new-console-template for more information
using GitDrill;


Console.WriteLine("Hello, World!");
Student[] kita = new Student[3];
kita[0] = new Student( "arye", "arye desc");
kita[1] = new Student();
kita[2] = new Student();
kita[1].Description = "desc1";
kita[2].Description = "desc2";
kita[1].Name = "Ofek";
kita[2].Name = "Peleg";

ConsoleColor[] consCol = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
int colorMaxIndx = consCol.Length;
int currColIndx = 0;

foreach (Student s in kita)
{
    Random random = new Random();
    currColIndx =random.Next(colorMaxIndx);
    Console.ForegroundColor = consCol[currColIndx];
    s.PrintStdDit();
    //comment 4 ver2
    
}
kita[1].Stam();
//master changed


