using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
   public partial class Parametros
   {
      public Int32 PARA_IntValor
      {
         get
         {
            Int32 _para_intvalor;
            if (!String.IsNullOrEmpty(PARA_Valor) && Int32.TryParse(PARA_Valor, out _para_intvalor))
            { return _para_intvalor; }
            else
            { return -1; }
         }
      }

      
   }
}
