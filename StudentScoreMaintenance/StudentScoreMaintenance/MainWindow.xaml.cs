using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentScoreMaintenance;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<Student> Students;

    public MainWindow()
    {
        InitializeComponent();
        Students = new List<Student>();
        lstbxStudents.ItemsSource = Students;
    }

    public void UpdateInfo()
    {
        lstbxStudents.Items.Refresh();
        DisplayStudentInfo(Students.Count - 1);
    }

    public void DisplayStudentInfo(int index)
    {
        if (index < 0 || index >= Students.Count)
            return;

        Student student = Students[index];
        int total = student.ScoreTotal();
        int count = student.ScoreTotal();
        txtScoreTotal.Text = total.ToString();
        txtScoreCount.Text = count.ToString();
        if (count == 0)
            txtAverage.Text = "0";
        else
            txtAverage.Text = (total / count).ToString();
    }

    public int CalculateScoreTotal()
    {
        int total = 0;
        foreach (Student student in Students)
            total += student.ScoreTotal();

        return total;
    }

    public int CalculateScoreCount()
    {
        int count = 0;
        foreach (Student student in Students)
            count += student.ScoreCount();

        return count;
    }
  
    private void btnExit_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
        //// Create an instance of the AddNewStudent window
        var addNewStudentWindow = new AddNewStudent(Students);
        addNewStudentWindow.ShowDialog();

    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {
        int selected = lstbxStudents.SelectedIndex;
        if (selected == -1)
        {
            MessageBox.Show("Error: no student selected. Please click on a student and try again");
            return;
        }
        var updateStudentWindow = new UpdateStudentScores(Students[selected]);
        updateStudentWindow.Owner = this;
        updateStudentWindow.ShowDialog();
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
        // Check if an item is selected
        if (lstbxStudents.SelectedItem != null)
        {
            // Show a confirmation MessageBox
            var result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            // If the user confirms, delete the selected student
            if (result == MessageBoxResult.Yes)
            {
                // Remove the selected student from the list
                Students.RemoveAt(lstbxStudents.SelectedIndex);

                // Refresh the ListBox to reflect the changes
                lstbxStudents.Items.Refresh();
            }
        }
        else
        {
            // Show a message if no student is selected
            MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    /*
     * Button Shorthands
     */

    private void lstbxStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        DisplayStudentInfo(lstbxStudents.SelectedIndex);
    }

    private void lstbxStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        btnUpdate_Click(sender, e);
    }

    private void lstbxStudents_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Delete)
        {
            btnDelete_Click(sender, e);
        }
    }
}
