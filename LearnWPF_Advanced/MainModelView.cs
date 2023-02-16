using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearnWPF_Advanced.Lesson01;
using LearnWPF_Advanced.WpfTreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LearnWPF_Advanced
{
    public partial class MainModelView: ObservableObject
    {
        public MainModelView()
        {
            wpfTreeView wpfTree = new wpfTreeView();
            wpfTree.ShowDialog();
        }
        [RelayCommand]
        private void GotoLesson(Button btn)
        {
            if(btn.Content.ToString() == "Lesson01")
            {
                ViewLesson01 lesson01 = new ViewLesson01();
                lesson01.ShowDialog();
            }
            else if(btn.Content.ToString() == "lesson02")
            {

            }
        }
   }
}
