using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentScoreMaintenance
{
    /// <summary>
    /// Interaction logic for UpdateStudentScores.xaml
    /// </summary>
    public partial class UpdateStudentScores : Window
    {
        public Student Student;
        private List<int> BackUpScores;

        public UpdateStudentScores(Student student)
        {
            InitializeComponent();
            Student = student;
            BackUpScores = new List<int>(student.Scores);

            txtName.Text = student.Name;
            lstScores.ItemsSource = Student.Scores;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Simulate OK button click
                btnOK.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Escape)
            {
                // Simulate Cancel button click
                this.Close();
            }
        }

        public void DisplayScores()
        {
            lstScores.ItemsSource = Student.Scores;
            lstScores.Items.Refresh();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addScoreWindow = new AddScore(Student);
            addScoreWindow.Owner = this;
            addScoreWindow.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int selected = lstScores.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("error: no score selected. please click on a score and try again");
                return;
            }

            var updateScoreWindow = new UpdateScore(Student, selected);
            updateScoreWindow.Owner = this;
            updateScoreWindow.ShowDialog();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            int selected = lstScores.SelectedIndex;
            // Check if user selected a score
            if (selected == -1)
            {
                MessageBox.Show("error: no score selected. please click on a score and try again");
                return;
            }

            // Show a confirmation MessageBox
            var result = MessageBox.Show(
                "Are you sure you want to delete this score?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            // If the user confirms, delete the selected student
            if (result == MessageBoxResult.Yes)
            {
                Student.RemoveScore(selected);
                DisplayScores();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this score?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                Student.ClearScores();
                DisplayScores();
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            (this.Owner as MainWindow).UpdateInfo();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Restore previous scores before modification
            Student.Scores = BackUpScores;
            this.Close();
        }
    }
}
