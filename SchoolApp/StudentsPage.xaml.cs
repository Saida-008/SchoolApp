using System.Linq;

namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new[]
        {
            "Aida",
            "Bekzat",
            "Dana",
            "Erlan",
            "Madina"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name)
            return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={name}");

        StudentsList.SelectedItem = null;
    }
}