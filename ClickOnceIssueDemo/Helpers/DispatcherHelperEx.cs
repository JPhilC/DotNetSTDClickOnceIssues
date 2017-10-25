using ClickOnceIssueDemoStd.Helpers;
using GalaSoft.MvvmLight.Threading;
using System;


namespace ClickOnceIssueDemo.Helpers
{
   public class DispatcherHelperEx : IDispatcherHelper
   {
      public void CheckBeginInvokeOnUi(Action action)
      {
         DispatcherHelper.CheckBeginInvokeOnUI(action);
      }
   }
}
