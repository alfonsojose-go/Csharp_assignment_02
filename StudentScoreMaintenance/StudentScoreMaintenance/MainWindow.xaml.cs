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

    

    public MainWindow()
    {
        InitializeComponent();

      
    }

  
    private void btnExit_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
        //// Create an instance of the AddNewStudent window
        var addNewStudentWindow = new AddNewStudent();
        addNewStudentWindow.ShowDialog();

    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {
        var updateStudentWindow = new UpdateStudentScores();
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
}
