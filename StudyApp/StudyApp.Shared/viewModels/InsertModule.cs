using System;
using System.Collections.Generic;
using System.Text;

namespace StudyApp.viewModels
{

    class InsertModule
    {
        private SubjectViewModel subject = new SubjectViewModel();

        public void populateEnglishTables()
        {
            subject.addEnglishSubject("Which country does the soccer team Bafana Bafana represent?", "South Africa", "Australia", "Cameroon", "GRADE 6", "no");
            subject.addEnglishSubject("The perfect pot boasted about its achievements is an example of?", "metaphor", "personification", "Humanity", "GRADE 6", "no");
            subject.addEnglishSubject("The colour red usually represents love.", "common noun", "abstract noun", "proper noun", "GRADE 6", "no");
            subject.addEnglishSubject("What does past tence mean?", "Already passed", "still to happen", "happen any time", "GRADE 6", "no");
            subject.addEnglishSubject("Which city is lagos located?", "Nigeria", "Congo", "Zimbabwe", "GRADE 6", "no");
            subject.addEnglishSubject("How many provinces are there in south africa?", "9", "24", "7", "GRADE 6", "no");
            subject.addEnglishSubject("what are the normal working hours in South Africa?", "metaphor", "personification", "Humanity", "GRADE 6", "no");
            subject.addEnglishSubject("Who is the first black president of south africa", "nelson mandela", "Thabo Mbeki", "Jacob Zuma", "GRADE 6", "no");
            subject.addEnglishSubject("In which day of month does christmas fall?", "25", "31", "01", "GRADE 6", "no");
            subject.addEnglishSubject("Who is the current president of USA.", "Barack Obama", "FW De- Clerk", "Arnold Obama", "GRADE 6", "no");
        }

    }
}
