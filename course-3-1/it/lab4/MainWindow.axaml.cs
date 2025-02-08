using Avalonia.Controls;

namespace lab4;

public partial class MainWindow : Window
{
    public string Greeting => "Welcome to Avalonia! This is my added text.";

    public MainWindow()
    {
        InitializeComponent();
    }
}