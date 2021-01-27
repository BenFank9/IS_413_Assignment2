using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment2.Models
{
    public class GradesModel
    {
        /*this is making a getter and setter for a public property 
         Range is putting validation on the model so above 100 is not put in.
        If invalid numbers are put in, a nice alert will appear telling them to input something valid*/

        [Range(0,50)]
        public int assignmentsPercent { get;set; }

        [Range(0, 10)]
        public int GroupProjectPercent { get;set; }

        [Range(0, 10)]
        public int QuizzesPercent { get;set; }

        [Range(0, 20)]
        public int ExamsPercent { get;set; }

        [Range(0, 10)]
        public int IntexPercent { get;set; }

    }
}
