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
	public partial class EntidadCuentaBancaria
	{
      [DataMember]
      public String TipoCuenta { get; set; }
      [DataMember]
      public String TIPO_BCO { get; set; }

	}
}
