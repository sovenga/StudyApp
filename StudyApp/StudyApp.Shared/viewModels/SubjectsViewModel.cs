using StudyApp.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.UI.Xaml;

namespace StudyApp.viewModels
{
    class SubjectsViewModel
    {
        private App app = (Application.Current as App);
        private ObservableCollection<SubjectViewModel> subject;
        private List<SubjectViewModel> subjects;
        public ObservableCollection<SubjectViewModel> Subject
        {
            get { return subject; }

            set
            {
                if (subject == value)
                {
                    return;
                }
                subject = value;

            }
        }
        public ObservableCollection<SubjectViewModel> getEnglishQuestions(string subject_table, string grade)
        {
            subject = new ObservableCollection<SubjectViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //var query = db.Table<English>();
                var query = db.Query<English>("select * from " + subject_table + " where GRADE ='" + grade + "'");
                foreach (var j in query)
                {
                    var sub = new SubjectViewModel()
                    {
                        ID = j.Id,
                        QUESTION = j.question,
                        ANSWER = j.answer,
                        ANSWER1 = j.answer2,
                        ANSWER2 = j.answer3,
                        GRADE = grade
                    };
                    subject.Add(sub);
                }
            }
            return subject;
        }
        public ObservableCollection<SubjectViewModel> getEnglishQuestions1(string gr)
        {
            string no = "no";
            string yes = "yes";
            subject = new ObservableCollection<SubjectViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //var query = db.Table<English>();
                var query = db.Query<English>("select * from english where GRADE ='" + gr + "' and read ='" + no + "'");
                foreach (var j in query)
                {
                    var sub = new SubjectViewModel()
                    {
                        ID = j.Id,
                        QUESTION = j.question,
                        ANSWER = j.answer,
                        ANSWER1 = j.answer2,
                        ANSWER2 = j.answer3,
                        GRADE = j.GRADE,
                        READ = j.read
                    };
                    subject.Add(sub);
                }
            }
            return subject;
        }
        public List<SubjectViewModel> getEnglishQuestion(string gr)
        {
            //string grade = "Grade 6";
            subjects = new List<SubjectViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //var query = db.Table<English>();
                var query = db.Query<English>("select * from english where GRADE ='" + gr + "'");
                foreach (var j in query)
                {
                    var sub = new SubjectViewModel()
                    {
                        ID = j.Id,
                        QUESTION = j.question,
                        ANSWER = j.answer,
                        ANSWER1 = j.answer2,
                        ANSWER2 = j.answer3,
                        GRADE = gr
                    };
                    subject.Add(sub);
                }
            }
            return subjects;
        }
    }
}
