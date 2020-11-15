/*
Programmer: Ben P Sehnert
Program: Command class for Commander application
Date: 11/15/2020
Purpose: a class for storing details of command line commands.
initializes command objects for use at runtime.
 */
namespace Commander.Models
{
    public class Command
    {

        // public Command(int Id, string HowTo, string Line, string Platform)
        // {
        //     this.Id = Id;
        //     this.HowTo = HowTo;
        //     this.Line = Line;
        //     this.Platform = Platform;
        // }
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }

        public string Platform { get; set; }
    }

}