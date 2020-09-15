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
	public partial class DetNaveViaje
	{
      [DataMember]
      public String TIPO_TabPAI { get; set; }
      [DataMember]
      public String TIPO_CodPAI { get; set; }
      [DataMember]
      public String TIPO_DescPAI { get; set; }

      [DataMember]
      public String PUER_Nombre { get; set; }


      [DataMember]
      public String NVIA_NroViaje { get; set; }
      [DataMember]
      public String NAVE_Nombre { get; set; }
      [DataMember]
      public Nullable<DateTime> NVIA_FecETA { get; set; }
      [DataMember]
      public Nullable<DateTime> NVIA_FecETDMaster { get; set; }
      [DataMember]
      public Nullable<DateTime> NVIA_FecCutOff { get; set; }


      [DataMember]
      public Nullable<DateTime> NVIA_FecETA_IMPO_ETD_EXPO { get; set; }
      [DataMember]
      public String CONS_DescVIA { get; set; }
      [DataMember]
      public String CONS_DescRGM { get; set; }
      [DataMember]
      public String ENTC_RazonSocial { get; set; }
	}
}
