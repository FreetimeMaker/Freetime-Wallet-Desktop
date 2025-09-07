using Avalonia.Controls;
using Avalonia.AvaloniaUIFactory;
using NetSparkleUpdater;

namespace Freetime_Wallet;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnCheckUpdateClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var sparkle = new SparkleUpdater(
            new NetSparkleConfiguration("https://github.com/FreetimeMaker/Freetime-Wallet-Desktop/appcast.xml"),
            new AvaloniaUIFactory()
        );
        sparkle.StartLoop(true, true);
    }
}
