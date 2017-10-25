using ClickOnceIssueDemo.Helpers;
using ClickOnceIssueDemoStd.Helpers;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using System.Windows;

namespace ClickOnceIssueDemo
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {
      static App()
      {
         DispatcherHelper.Initialize();
         SimpleIoc.Default.Register<IDispatcherHelper, DispatcherHelperEx>();
      }
   }
}
