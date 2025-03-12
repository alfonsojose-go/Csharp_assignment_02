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
    /// Interaction logic for UpdateScore.xaml
    /// </summary>
    public partial class UpdateScore : Window
    {
        public Student Student;
        public int ScoreIndex { get; }

        public UpdateScore(Student student, int scoreIndex)
        {
            InitializeComponent();
            Student = student;
            ScoreIndex = scoreIndex;

            txtScore.Text = student.Scores[scoreIndex].ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int score;
            // TODO: add message
            if (!Int32.TryParse(txtScore.Text, out score))
                return;
            Student.UpdateScore(score, ScoreIndex);
            (this.Owner as UpdateStudentScores).DisplayScores();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
