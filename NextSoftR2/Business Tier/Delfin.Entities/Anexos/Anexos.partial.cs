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
	public partial class Anexos
	{
      public String ANEX_TipoDesc 
      {
         get
         {
            if (ANEX_Tipo == "R")
            { return "Rectificación"; }
            else if (ANEX_Tipo == "I")
            { return "Incorporación"; }
            else
            { return ""; }
         }
      }
	}
}
