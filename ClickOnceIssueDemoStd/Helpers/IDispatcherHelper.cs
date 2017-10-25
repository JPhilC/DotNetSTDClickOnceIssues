using System;
using System.Collections.Generic;
using System.Text;

namespace ClickOnceIssueDemoStd.Helpers
{
   public interface IDispatcherHelper
   {
      void CheckBeginInvokeOnUi(Action action);
   }
}
