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
	public partial class DetPerfilAsientos
   {
      #region Propiedades
      [DataMember]
      public Decimal Debe { get; set; }
      [DataMember]
      public Decimal Haber { get; set; }

      [DataMember]
      public string CENT_Desc { get; set; }
      [DataMember]
      public string CUEN_Desc { get; set; }

      #endregion
   }
}
