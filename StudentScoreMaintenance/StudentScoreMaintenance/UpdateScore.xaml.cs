﻿using System;
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
            KeyDown += MainWindow_KeyDown;
        }


        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {

            //Check if the Enter key is pressed
            if (e.Key == Key.Enter)
            {
                // Simulate OK button click
                int score;
                // evaluate if score is empty or null
                if (txtScore.Text == "" || txtScore.Text is null)
                {
                    //Display the error message
                    MessageBox.Show("Invalid input! Please enter a score or press ESC to cancel.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    // evaluate if score is an integer type
                    if (!Int32.TryParse(txtScore.Text, out score))
                    {
                        //Display the error message
                        MessageBox.Show("Invalid input! Please enter valid numbers.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        Student.UpdateScore(score, ScoreIndex);
                        (this.Owner as UpdateStudentScores).DisplayScores();
                        this.Close();
                    }
                }

            }
            //Check if the ESC key is pressed
            else if (e.Key == Key.Escape)
            {
                // Simulate Cancel button click
                this.Close();
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int score;
            // evaluate if score is empty or null
            if (txtScore.Text == "" || txtScore.Text is null)
            {
                //Display the error message
                MessageBox.Show("Invalid input! Please enter a score or press ESC to cancel.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                // evaluate if score is an integer type
                if (!Int32.TryParse(txtScore.Text, out score))
                {
                    //Display the error message
                    MessageBox.Show("Invalid input! Please enter valid numbers.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    Student.UpdateScore(score, ScoreIndex);
                    (this.Owner as UpdateStudentScores).DisplayScores();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
