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
	public partial class CuentasBancarias
	{
      #region [ Propiedades ]

      [DataMember]
      public String SUCR_Desc { get; set; }
      [DataMember]
      public String TIPO_BCO { get; set; }
      [DataMember]
      public String TIPO_MND { get; set; }
      [DataMember]
      public String TipoCuenta { get; set; }
      [DataMember]
      public String TIPO_MND_Simbolo { get; set; }

      #endregion
	}
}
