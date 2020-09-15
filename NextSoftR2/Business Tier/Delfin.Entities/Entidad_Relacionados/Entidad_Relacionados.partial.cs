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
	public partial class Entidad_Relacionados
	{
      [DataMember]
      public String ENTC_NomCompleto { get; set; }
      [DataMember]
      public String ENTC_Codigo { get; set; }
      [DataMember]
      public Boolean Agregar { get; set; }
      [DataMember]
      public String REGIMEN { get; set; }
      [DataMember]
      public String CONS_RGM { get; set; }
      [DataMember]
      public String TIPO_TRF { get; set; }
      [DataMember]
      public String RELA_TipoRelacion { get; set; }
      [DataMember]
      public String TIPE_Hijo { get; set; }
	}
}
