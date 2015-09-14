using StudyApp.model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;

namespace StudyApp.viewModels
{
    class SubjectViewModel
    {
        private App app = (Application.Current as App);
        private int id = 0;
        public int ID
        {
            get { return id; }
            set
            {
                if (id == value)
                {
                    return;
                }
                id = value;
            }
        }

        private string question = string.Empty;
        public string QUESTION
        {
            get { return question; }
            set
            {
                if (question == value)
                {
                    return;
                }
                question = value;
            }
        }
        private string answer = string.Empty;
        public string ANSWER
        {
            get { return answer; }
            set
            {
                if (answer == value)
                {
                    return;
                }
                answer = value;
            }
        }
        private string answer1 = string.Empty;
        public string ANSWER1
        {
            get { return answer1; }
            set
            {
                if (answer1 == value)
                {
                    return;
                }
                answer1 = value;
            }
        }
        private string answer2 = string.Empty;
        public string ANSWER2
        {
            get { return answer2; }
            set
            {
                if (answer2 == value)
                {
                    return;
                }
                answer2 = value;
            }
        }
        private string grade = string.Empty;
        public string GRADE
        {
            get { return grade; }
            set
            {
                if (grade == value)
                {
                    return;
                }
                grade = value;
            }
        }
        private string read = string.Empty;
        public string READ
        {
            get { return read; }
            set
            {
                if (read == value)
                {
                    return;
                }
                read = value;
            }
        }
        public English getEnglish()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var q = db.Query<English>("select * from English").FirstOrDefault();
                return q;
            }
        }
        public void addEnglishSubject(string question, string answer, string answer1, string answer2, string grade, string read)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    int data = db.Insert(new English()
                    {
                        Id = 0,
                        question = question,
                        answer = answer,
                        answer2 = answer1,
                        answer3 = answer2,
                        GRADE = grade,
                        read = read
                    });
                }
                catch (Exception e)
                {

                }
            }

        }
        public English getEnglishCorrectAnswer(string question)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var q = db.Query<English>("select * from English where question = '" + question + "'").FirstOrDefault();
                return q;
            }
        }
        public void updateToRead(string quetion)
        {
            string yes = "yes";
            string no = "no";
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    //var existing = db.Query<English>("update English set read ='" + yes + "' where question ='" + question + "'");
                    var existing = db.Execute("update English set read ='" + yes + "' where answer ='"+question+"'");
                    //var q = db.Execute("update English set read ='" + yes + "'");
                }

                catch (Exception e)
                {

                }
            }
        }
        public string updateToRead2(string quetion)
        {
            string isUpdated = "";
            string yes = "yes";
            string no = "no";
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    var existing = db.Execute("update English set read ='" + yes + "' where question ='" + question + "'");
                    if (existing != null)
                    {
                        isUpdated = "true";
                    }
                    else {
                        isUpdated = "false";
                    }
                }

                catch (Exception e)
                {

                }
            }
            return isUpdated;
        }
        public void updateEnglishToNotRead()
        {
            string yes = "yes";
            string no = "no";
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    var existing = db.Query<English>("update English set read ='" + no + "'");
                }
                catch (Exception e)
                {

                }
            }

        }
        public void remove(string question)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    var existing = db.Query<English>("delete from English where question ='"+question+"'");
                }
                catch (Exception e)
                {

                }
            }
        }
        public void removeAll()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    var existing = db.Query<English>("delete from English");
                }
                catch (Exception e)
                {

                }
            }
        }

    }
}
