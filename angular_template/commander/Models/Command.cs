/*
Programmer: Ben P Sehnert
Program: Command class for Commander application
Date: 11/15/2020
Purpose: a class for storing details of command line commands.
initializes command objects for use at runtime.
 */
using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }


        [Required]
        public string Platform { get; set; }
    }

}