﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Delfin.Principal
{
   public interface ICOM001LView
   {
      Telerik.WinControls.UI.RadPageViewPage TabPageControl { get; set; }
      COM001Presenter Presenter { get; set; }
      Image IconView { get; set; }
      event Infrastructure.Client.FormClose.FormCloseEventArgs.FormCloseEventHandler CloseForm;

      void LoadView();
      void ShowItems(Boolean Habilitar);
   }
   //public interface ICOM001MView
   //{
   //   COM001Presenter Presenter { get; set; }

   //   void LoadView();

   //   void ClearItem();
   //   void GetItem();
   //   void SetItem();

   //   void ShowValidation();
   //}
}
