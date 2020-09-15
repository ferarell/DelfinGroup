﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Delfin.Principal
{
   public interface ICOM004LView
   {
      Telerik.WinControls.UI.RadPageViewPage TabPageControl { get; set; }
      COM004Presenter Presenter { get; set; }
      Image IconView { get; set; }
      event Infrastructure.Client.FormClose.FormCloseEventArgs.FormCloseEventHandler CloseForm;

      void LoadView();
      void ShowItems();
   }
   //public interface ICOM002MView
   //{
   //   COM002Presenter Presenter { get; set; }

   //   void LoadView();

   //   void ClearItem();
   //   void GetItem();
   //   void SetItem();

   //   void ShowValidation();
   //}
}
