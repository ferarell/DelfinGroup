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
	public partial class Det_Cotizacion_OV_Documento
	{
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescDTM.
      /// </summary>
      [DataMember]
      public string TIPO_DescDTM { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescVapor.
      /// </summary>
      [DataMember]
      public string TIPO_DescVapor { get; set; }
	}
}
