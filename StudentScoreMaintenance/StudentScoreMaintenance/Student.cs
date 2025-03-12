using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StudentScoreMaintenance
{
    public class Student
    {
        public String Name { get; set; }
        public List<int> Scores;

        public Student(String name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public Student() : this("") { }

        private static bool ValidateScore(int score)
        {
            if (score < 0 || score > 100)
            {
                MessageBox.Show($"Score must be within 0 to 100. Got {score}.", "Invalid Score",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return false;
            }
            return true;
        }

        public void AddScore(int score)
        {
            if (!ValidateScore(score))
                return;
            Scores.Add(score);
        }

        public void AddScore(int score, int index)
        {
            if (!ValidateScore(score))
                return;
            Scores.Insert(index, score);
        }

        public void UpdateScore(int newScore, int index)
        {
            if (!ValidateScore(newScore))
                return;
            Scores[index] = newScore;
        }

        public void RemoveScore(int index) =>
            Scores.RemoveAt(index);

        public void ClearScores() =>
            Scores.Clear();
        
        public int ScoreTotal() =>
            Scores.Sum();

        public int ScoreCount() =>
            Scores.Count;

        public int ScoreAverage() =>
            ScoreTotal() / ScoreCount();

        public string ScoresToString() =>
            string.Join("|", Scores);

        public override string ToString() =>
            Name + "|" + ScoresToString();
    }
}
