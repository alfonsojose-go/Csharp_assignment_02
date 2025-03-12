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
        }

        private void DisplayScores()
        {
            txtScores.Text = Student.ScoresToString();
        }

        private void btnAddScore_Click(object sender, RoutedEventArgs e)
        {
            int score;
            // TODO: validate
            if (!Int32.TryParse(txtScore.Text, out score))
                return;

            txtScores.Clear();

            Student.AddScore(score);
            DisplayScores();
        }

        private void btnClearScores_Click(object sender, RoutedEventArgs e)
        {
            Student.ClearScores();
            txtScore.Clear();
            txtScores.Clear();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            // Set name at the last minute
            Student.Name = txtName.Text;
            Students.Add(Student);
            (Application.Current.MainWindow as MainWindow).UpdateInfo();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
