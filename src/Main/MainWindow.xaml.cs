namespace Main
{
  using System;
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

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private readonly MainViewModel mainViewModel;
    public MainWindow()
    {
      this.mainViewModel = new MainViewModel();
      this.DataContext = this.mainViewModel;
      InitializeComponent();

      this.Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
      => this.mainViewModel.Initialize();
  }
}