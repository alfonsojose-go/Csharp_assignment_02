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
    /// Interaction logic for AddNewStudent.xaml
    /// </summary>
    public partial class AddNewStudent : Window
    {
        public List<Student> Students;
        private Student Student;

        public AddNewStudent(List<Student> students)
        {
            InitializeComponent();
            Students = students;
            Student = new Student();
            KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {

            //Check if the Enter key is pressed
            if (e.Key == Key.Enter)
            {
                //Trigger the Add New Student button's Click event
                Student.Name = txtName.Text;
                Students.Add(Student);
                (Application.Current.MainWindow as MainWindow).UpdateInfo();
                this.DialogResult = false;
            }
            //Check if the ESC key is pressed
            else if (e.Key == Key.Escape)
            {
                //Trigger the Exit button's Click event
                this.Close();
            }
        }

       

        // Define the Window_Loaded event handler
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus(); // Set focus to the AddNewStudent window
        }

        private void DisplayScores()
        {
            txtScores.Text = Student.ScoresToString();
        }

        private void btnAddScore_Click(object sender, RoutedEventArgs e)
        {
            int score;
            // evaluate if score is an integer type
            if (!Int32.TryParse(txtScore.Text, out score))
            {
                //Display the error message
                MessageBox.Show("Invalid input! Please enter valid numbers.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else 
            {
                
                Student.AddScore(score);
                DisplayScores();
                txtScore.Text = string.Empty;
                txtScore.Focus();
            }


                
        }

        private void btnClearScores_Click(object sender, RoutedEventArgs e)
        {
            Student.ClearScores();
            txtScore.Clear();
            txtScores.Clear();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

            //check if Student name is empty
            if (txtName.Text == "" || txtName.Text is null) 
            {
                //Display the error message
                MessageBox.Show("Invalid input! Please enter a name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else 
            {
                // Set name at the last minute
                Student.Name = txtName.Text;
                Students.Add(Student);
                (Application.Current.MainWindow as MainWindow).UpdateInfo();
                this.Close();
            }
                
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClearPrevious_Click(object sender, RoutedEventArgs e)
        {
            // Remove the last score from the list
            Student.RemoveLastScore();

            // Update the display
            DisplayScores();

            //Clears the value in textbox
            txtScore.Text = string.Empty;

            // Set focus back to the score input text box
            txtScore.Focus();
        }
    }
}
