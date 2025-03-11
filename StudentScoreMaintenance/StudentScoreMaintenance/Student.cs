using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentScoreMaintenance
{
    internal class Student
    {
        public String Name;
        public List<int> Scores;

        public Student(String name)
        {
            Name = name;
            Scores = new List<int>();
        }

        private static void ValidateScore(int score)
        {

            if (score < 0 || score > 100)
                throw new Exception("Score must be within 0 to 100.");
        }

        public void AddScore(int score)
        {
            ValidateScore(score);
            Scores.Add(score);
        }

        public void AddScore(int score, int index)
        {
            ValidateScore(score);
            Scores.Insert(index, score);
        }

        public void UpdateScore(int newScore, int index)
        {
            ValidateScore(newScore);
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

        public override string ToString()
        {
            string representation = Name;

            foreach (int score in Scores)
            {
                representation += "|"; // Separator character
                representation += score.ToString();
            }

            return representation;
        }
    }
}
