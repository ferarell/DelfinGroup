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
   public partial class PreDocsVta
   {
      [DataMember]
      public ObservableCollection<PreDetDocsVta> ItemsPreDetDocsVta { set; get; }
      [DataMember]
      public ObservableCollection<PreDetDocsVta_Det_Operacion> ItemsPreDetDocsVta_Det_Operacion { set; get; }

      [DataMember]
      public Int32 ENTC_Codigo { set; get; }
      [DataMember]
      public String DOCV_EstadoStr { set; get; }
      [DataMember]
      public String DOCV_Origen { set; get; }
      [DataMember]
      public String Cliente { set; get; }
      [DataMember]
      public String Moneda { set; get; }
      [DataMember]
      public String COPE_HBL { set; get; }
      [DataMember]
      public String COPE_NumDoc { set; get; }
      [DataMember]
      public String ENTC_DocIden { get; set; }
      [DataMember]
      public String TIPO_TDO { get; set; }

   }
}
