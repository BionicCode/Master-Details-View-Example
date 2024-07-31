namespace Main
{
  using System;
  using System.Collections;
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
  using System.Windows.Navigation;
  using System.Windows.Shapes;
  public partial class MasterDetailsControl : UserControl
  {
    public IList ItemsSource
    {
      get => (IList)GetValue(ItemsSourceProperty);
      set => SetValue(ItemsSourceProperty, value);
    }

    public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
      nameof(ItemsSource),
      typeof(IList),
      typeof(MasterDetailsControl),
      new FrameworkPropertyMetadata(default));

    public DataTemplate ItemTemplate
    {
      get => (DataTemplate)GetValue(ItemTemplateProperty);
      set => SetValue(ItemTemplateProperty, value);
    }

    public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register(
      nameof(ItemTemplate),
      typeof(DataTemplate),
      typeof(MasterDetailsControl),
      new FrameworkPropertyMetadata(default));

    public object SelectedDetailsItem
    {
      get => (object)GetValue(SelectedDetailsItemProperty);
      set => SetValue(SelectedDetailsItemProperty, value);
    }

    public static readonly DependencyProperty SelectedDetailsItemProperty = DependencyProperty.Register(
      nameof(SelectedDetailsItem),
      typeof(object),
      typeof(MasterDetailsControl),
      new FrameworkPropertyMetadata(default(object), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public DataTemplate SelectedDetailsItemTemplate
    {
      get => (DataTemplate)GetValue(SelectedDetailsItemTemplateProperty);
      set => SetValue(SelectedDetailsItemTemplateProperty, value);
    }

    public static readonly DependencyProperty SelectedDetailsItemTemplateProperty = DependencyProperty.Register(
      nameof(SelectedDetailsItemTemplate),
      typeof(DataTemplate),
      typeof(MasterDetailsControl),
      new FrameworkPropertyMetadata(default));

    public MasterDetailsControl()
    {
      InitializeComponent();
    }
  }
}
