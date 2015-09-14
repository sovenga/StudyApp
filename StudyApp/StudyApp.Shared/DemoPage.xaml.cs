﻿using StudyApp.viewModels;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StudyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoPage : Page
    {
        InsertModule insert = null;
        private string selectedGrade = string.Empty;
        private SubjectViewModel model = null;
        public DemoPage()
        {
            this.InitializeComponent();
            model = new SubjectViewModel();
        }

        private void linkQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            insert = new InsertModule();
            if (model.getEnglish() == null)
            {
                insert.populateEnglishTables();
            }
            comboList.Items.Add("GRADE 1");
            comboList.Items.Add("GRADE 2");
            comboList.Items.Add("GRADE 3");
            comboList.Items.Add("GRADE 4");
            comboList.Items.Add("GRADE 5");
            comboList.Items.Add("GRADE 6");
            comboList.Items.Add("GRADE 7");
            comboList.Items.Add("GRADE 8");
            comboList.Items.Add("GRADE 9");
            comboList.Items.Add("GRADE 10");
            comboList.Items.Add("GRADE 11");
            comboList.Items.Add("GRADE 12");
            base.OnNavigatedFrom(e);
        }
        private void btnEnglish_Click(object sender, RoutedEventArgs e)
        {
            
            //string myGrade = item.Substring(0,item.IndexOf(':'));
            if (comboList.SelectedItem == null)
            {
                
                messageBox("You must select the grade first");
            }
            else { 
                string item = comboList.SelectedItem.ToString()+":English";
            this.Frame.Navigate(typeof(QuestionsPage),item);
            }
            
        }

        private void btnMaths_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string items = comboList.SelectedItem.ToString();
            selectedGrade = items;
            //messageBox("You clicked "+items);
        }
        private async void messageBox(string msg)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(msg);
            await dialog.ShowAsync();
        }
    }
}