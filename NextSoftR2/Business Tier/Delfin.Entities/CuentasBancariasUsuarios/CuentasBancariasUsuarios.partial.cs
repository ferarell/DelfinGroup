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
	public partial class CuentasBancariasUsuarios
   {
      /// <summary>
      /// Gets or sets el valor de: USER_Nombres.
      /// </summary>
      [DataMember]
      public String USER_Nombres { get; set; }
   }
}
