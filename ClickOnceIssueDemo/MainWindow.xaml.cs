using ClickOnceIssueDemoStd.ViewModel;
using System.Windows;

namespace ClickOnceIssueDemo
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {

      public MainViewModel Vm => (MainViewModel)DataContext;

      public MainWindow()
      {
         InitializeComponent();

         Loaded += (s, e) => Vm.StartClock();
         Unloaded += (s, e) => Vm.StopClock();
      }
   }
}
