using System.ComponentModel.DataAnnotations;
using System;

namespace Survey.Models
{
    public class SurveyResults
    {
        [Required (ErrorMessage = "Name Required!")]
        [MinLength(2, ErrorMessage ="Needs at least 2 characters!")]

        public string Name {get;set;}
        [Required (ErrorMessage = "Dojo Required!")]
        public string Dojo {get;set;}
        [Required (ErrorMessage = "Location Required!")]
        public string Language {get;set;}


        [MinLength(20, ErrorMessage ="Must be at least 20 characters!")]
        public string Comments {get;set;}
    }
}