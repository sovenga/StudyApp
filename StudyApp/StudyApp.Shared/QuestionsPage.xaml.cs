using StudyApp.model;
using StudyApp.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace StudyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuestionsPage : Page
    {
        InsertModule module = null;
        English correct_answer = null;
        double marks = 0.0;
        List<string> list = new List<string>();
        private ObservableCollection<SubjectViewModel> subjects = null;
        private SubjectViewModel subject = null;
        private SubjectsViewModel subjectModel = null;
        string[] question;
        string[] questionss, answers;
        string[] names = null;
        private ObservableCollection<SubjectViewModel> questions = null;
        List<SubjectViewModel> myList;
        List<SubjectViewModel> subjectsList = null;
        Random random = new Random();
        string it;
        int pressed = 0;
        string item;
        int readQuestion = 0;
        string myQuestion = null;
        string pass_question = string.Empty;
        int countButton = 0;
        public QuestionsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            item = e.Parameter as string;

        }
        private async void messageBox(string msg)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(msg);
            await dialog.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            subject.updateEnglishToNotRead();
            this.Frame.Navigate(typeof(DemoPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(QuestionsPage));
        }
        private void radAnswer1_Checked(object sender, RoutedEventArgs e)
        {
            radAnswer2.IsEnabled = false;
            radAnswer3.IsEnabled = false;
            if (radAnswer1.IsChecked == true)
            {
                subject.remove(pass_question);
                if (radAnswer1.Content.Equals(correct_answer.answer))
                {
                    marks = marks + 2;
                }
            }
            lblMarks.Text = marks + "%";
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            module = new InsertModule();
            int number = 0;
            countButton++;
            myList = new List<SubjectViewModel>();
            subjects = new ObservableCollection<SubjectViewModel>();
            subjectsList = new List<SubjectViewModel>();

            subjectModel = new SubjectsViewModel();

            string grade = item.Substring(0, item.IndexOf(":"));
            string table = item.Substring(item.IndexOf(":") + 1);
            subject = new SubjectViewModel();
            try
            {
                if (table.Equals("English"))
                {
                    subjects = subjectModel.getEnglishQuestions1(grade);
                    subjectsList = subjectModel.getEnglishQuestion(grade);
                    myList = subjectModel.getEnglishQuestion(grade);
                    int totalItems = subjects.Count();
                    int count = 0;
                    names = new string[subjects.Count()];
                    foreach (var i in subjects)
                    {
                        names[count] = i.QUESTION + "#" + i.ANSWER + "#" + i.ANSWER1 + "#" + i.ANSWER2;
                        count++;
                    }

                    string answer1 = string.Empty, answer2 = string.Empty, answer3 = string.Empty;
                    if (readQuestion.Equals(number)) { }
                    number = random.Next(0, totalItems);
                    readQuestion = number;

                    it = names[number];

                    names = it.Split('#');
                    answer1 = names[1];
                    answer2 = names[2];
                    answer3 = names[3];
                    pass_question = it.Substring(0, it.IndexOf("#"));

                    myQuestion = pass_question;
                    lblQuestion.Text = it.Substring(0, it.IndexOf("#"));
                    correct_answer = subject.getEnglishCorrectAnswer(pass_question);
                    string[] answers_array = { answer1, answer2, answer3 };
                    Random ran = new Random();
                    int num = 0;
                    num = ran.Next(0, 2);
                    int num1 = ran.Next(0, 2);
                    int num2 = ran.Next(0, 2);
                    if (num == num1)
                    {
                        radAnswer1.Content = answers_array[2];
                        radAnswer2.Content = answers_array[1];
                        radAnswer3.Content = answers_array[0];

                    }
                    else if (num == num2)
                    {
                        radAnswer1.Content = answers_array[0];
                        radAnswer2.Content = answers_array[1];
                        radAnswer3.Content = answers_array[2];
                    }
                    else if (num1 == num2)
                    {
                        radAnswer1.Content = answers_array[2];
                        radAnswer2.Content = answers_array[0];
                        radAnswer3.Content = answers_array[1];
                    }
                    else if (num == num1 && num == num2)
                    {
                        radAnswer1.Content = answers_array[2];
                        radAnswer2.Content = answers_array[0];
                        radAnswer3.Content = answers_array[1];
                    }
                    else
                    {
                        radAnswer1.Content = answers_array[num];
                        radAnswer2.Content = answers_array[num1];
                        radAnswer3.Content = answers_array[num2];
                    }

                }
                else if (table.Equals("Maths"))
                {


                }
            }
            catch
            {

            }

            radAnswer1.IsChecked = false;
            radAnswer2.IsChecked = false;
            radAnswer3.IsChecked = false;

            radAnswer1.IsEnabled = true;
            radAnswer2.IsEnabled = true;
            radAnswer3.IsEnabled = true;
            if(countButton > 9)
            {
                messageBox("Test Completed :Total marks "+marks +"%");
                subject.removeAll();
                module.populateEnglishTables();
            }
            //subject.remove(pass_question);
        }

        private void radAnswer2_Checked(object sender, RoutedEventArgs e)
        {
            radAnswer1.IsEnabled = false;
            radAnswer3.IsEnabled = false;
            if (radAnswer2.IsChecked == true)
            {
                subject.remove(pass_question);
                if (radAnswer2.Content.Equals(correct_answer.answer))
                {
                    marks = marks + 2;
                }
            }
            lblMarks.Text = marks + "%";
        }

        private void radAnswer3_Checked(object sender, RoutedEventArgs e)
        {
            radAnswer2.IsEnabled = false;
            radAnswer1.IsEnabled = false;
            if (radAnswer3.IsChecked == true)
            {
                subject.remove(pass_question);
                if (radAnswer3.Content.Equals(correct_answer.answer))
                {
                    marks = marks + 2;
                }
            }
            lblMarks.Text = marks + "%";
        }
    }
}
