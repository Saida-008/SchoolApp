namespace SchoolApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCheckClicked(object sender, EventArgs e)
    {
        count++;
        StatusLabel.Text = $"Button clicked {count} times";
    }

    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}