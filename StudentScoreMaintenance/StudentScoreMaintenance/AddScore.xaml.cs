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
    /// Interaction logic for AddScore.xaml
    /// </summary>
    public partial class AddScore : Window
    {
        public Student Student;

        public AddScore(Student student)
        {
            InitializeComponent();
            Student = student;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int score;
            if (!Int32.TryParse(txtScore.Text, out score))
                return;

            Student.AddScore(score);
            (this.Owner as UpdateStudentScores).DisplayScores();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
