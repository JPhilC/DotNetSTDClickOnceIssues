﻿using GalaSoft.MvvmLight.Ioc;

namespace ClickOnceIssueDemoStd.ViewModel
{
   public class ViewModelLocator
   {
      static ViewModelLocator()
      {
         SimpleIoc.Default.Register<MainViewModel>();
      }

      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
          "CA1822:MarkMembersAsStatic",
          Justification = "This non-static member is needed for data binding purposes.")]
      public MainViewModel Main
      {
         get
         {
            return SimpleIoc.Default.GetInstance<MainViewModel>();
         }
      }
   }
}
