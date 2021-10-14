using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_Implementation
{
    partial class LMS
    {
        string name;
        int SNO;
        long mobilenum;
        string email;

        public void Display()
        void IAsessment.MCQ_Asessment()
        void IAsessment.QuestionBank()
        {
            Console.WriteLine("Returing value from Question Bank defined inside LMS class");
        }

    }
    partial class LMS : Placement,IAsessment
    {
        public void Message()
        {
            Console.WriteLine("This Message is coming from second Implementation of class");
        }
    }
    abstract class Placement
    {
        string name_of_company;
        int No_of_students_placed;
        DateTime Year_of_placement;

        public void placement_record()
        {
            Console.WriteLine("This method will show you complete record of the placement");

        }

    }
    public interface Asessment
    {
        public void MCQ_Asessment();
        public void QuestionBank();
    }
}



   
