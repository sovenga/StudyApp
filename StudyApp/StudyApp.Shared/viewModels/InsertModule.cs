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
            subject.addEnglishSubject("The perfect pot boasted about its achievements is an example of?" ,"personification", "metaphor", "Humanity", "GRADE 6", "no");
            subject.addEnglishSubject("The colour red usually represents love.", "abstract noun", "common noun", "proper noun", "GRADE 6", "no");
            subject.addEnglishSubject("What does past tence mean?", "Already passed", "still to happen", "happen any time", "GRADE 6", "no");
            subject.addEnglishSubject("Which city is lagos located?", "Nigeria", "Congo", "Zimbabwe", "GRADE 6", "no");
            subject.addEnglishSubject("How many provinces are there in south africa?", "9", "24", "7", "GRADE 6", "no");
            subject.addEnglishSubject("what are the normal working hours in South Africa?", "8", "9", "8.5", "GRADE 6", "no");
            subject.addEnglishSubject("Who is the first black president of south africa?", "nelson mandela", "Thabo Mbeki", "Jacob Zuma", "GRADE 6", "no");
            subject.addEnglishSubject("In which day of month does christmas fall?", "25", "31", "01", "GRADE 6", "no");
            subject.addEnglishSubject("Who is the current president of USA?", "Barack Obama", "FW De- Clerk", "Arnold Obama", "GRADE 6", "no");
            subject.addEnglishSubject("What is the psychological moment?", "A suitable Moment", "A very wrong moment", "A moment tot do nothing", "GRADE 6", "no");
            subject.addEnglishSubject("What does Pull Strings mean?", "Be able to Excert private Influence", "Being controlled", "An introvert person", "GRADE 6", "no");
            subject.addEnglishSubject("What does Put all oness egg in one backet mean?", "Risk Everything", "Do whatever it takes to win the fight", "To protect others", "GRADE 6", "no");
            subject.addEnglishSubject("April fool", "Person sportively Imposed on the first of April", "Summer Time", "Month of fools", "GRADE 6", "no");
            subject.addEnglishSubject("His Bark is worse than his bite", "Threatening without action", "His Bark is very strong", "Taking matters serious", "GRADE 6", "no");
            subject.addEnglishSubject("Beat a person to it", "Do it before he can get chance", "Challenged by the main man", "Beat someone very bad", "GRADE 6", "no");
            subject.addEnglishSubject("CATALINA is in spanish,what does it mean in english?", "A flower", "Clever Person", "An Idiot", "GRADE 6", "no");
            subject.addEnglishSubject("Bite a persons head off", "Speak angrily to a person without allowing excuses", "To betray a person", "To Respect person religion", "GRADE 6", "no");
            subject.addEnglishSubject("Bite off more than one can chew", "Undertake more than one is able to perfom", "Taking enough into consideration","To cause trouble for others", "GRADE 6", "no");
            subject.addEnglishSubject("Blood is thicker than water...", "Family", "Friendship", "Marriage", "GRADE 6", "no");
            subject.addEnglishSubject("What is to speak by the book", "To quote precisely from a statement", "Speak from experience", "Wrote your own book", "GRADE 6", "no");
            subject.addEnglishSubject("Be in ones good books", "In high favors", "To threaten beloved ones", "Someone's name in your book", "GRADE 12", "no");
            subject.addEnglishSubject("Brake the reocrd", "Do Extraordinary", "Do good like others", "Break the challenge", "GRADE 6", "no");
            subject.addEnglishSubject("Bite a persons head off Speak angrily to a person without allowing excuses Speak angrily to a person without allowing excuses Speak angrily to a person without allowing excuses", "Speak angrily to a person without allowing excuses", "To betray a person", "Respect person's religion", "GRADE 12", "no");
        }
        public void pupulateMathsTable()
        {
            subject.addMathsSubject("1 + 1 = ", "2", "1", "5", "GRADE 6", "no");
            subject.addMathsSubject("(if X = 15 and Y = 10), What is the product of the two numbers", "150", "25", "5", "GRADE 6", "no");
            subject.addMathsSubject("(if X = 15 and Y = 10), What is the Sum of the two numbers", "25", "5", "150", "GRADE 6", "no");
            subject.addMathsSubject("(if X = 15 and Y = 10), What is the Difference of the two numbers", "5", "60", "15", "GRADE 6", "no");
            subject.addMathsSubject("(X = 11 and Y = 18) : What is the answer of (Y + 2) * X - 10", "20", "210", "21", "GRADE 6", "no");
            subject.addMathsSubject("(X = 16 : Y = 11 and Z = 0) : What is the answer of (X - Y) * 0 - 10 / Z", "Impossible equation", "-1", "0", "GRADE 6", "no");
        }
        public void pupulateAccountingTable()
        {
            subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }
        public void pupulateBusinessTable()
        {
            subject.addBusinessStuddiesSubject("What is an enterprenuer", "Starts business by themselves", "A Dengeraous person", "I donk know", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }
        public void pupulateGeographyTable()
        {
            subject.addGeographySubject("One of these is a type of rock", "Ignatious Rock", "Dampor Rock", "Mental Rock", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }
        public void pupulateHistoryTable()
        {
            subject.addHistorySubject("Who is the first president of south africa", "FW-De Clerk", "Nelson Mandela", "Thabo Mbeki", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }
        public void pupulateLifeOrientationTable()
        {
            subject.addLifeOrientationSubject("What does Life oriontation infers", "The studdy of life and people", "Life Organization", "It represent Life In general", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }
        public void pupulatePhysicsTable()
        {
            subject.addPhysicsSubject("What does physics subject involve", "Science", "Technology", "Science represent nature", "GRADE 6", "no");
            //subject.addAccountingSubject("What is accounting", "Subject", "Economy", "I donk know", "GRADE 6", "no");
        }



    }
}
