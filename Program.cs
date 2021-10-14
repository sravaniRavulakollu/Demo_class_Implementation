using System;

namespace Demo_Class_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LMS sravs = new LMS();
            sravs.Display();
            sravs.Message();
            sravs.placement_record();
           
     
            IAsessment Delhi = sravs;
            Delhi.MCQ_Asessment();
            Delhi.QuestionBank();

            //Placement NIT = new Placement();

        }
    }
}
