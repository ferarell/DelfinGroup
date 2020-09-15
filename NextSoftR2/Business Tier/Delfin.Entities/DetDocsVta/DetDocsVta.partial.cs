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
   public partial class DetDocsVta
   {
      #region [ Variables Adicionales ]
      private String m_Descripcion;

      private bool m_Agregar;
      private Boolean m_Trasanct = true;
      #endregion

      #region [ Propiedades Adicionales ]
      [DataMember]
      public String Servicio
      {
         get { return m_Descripcion; }
         set { m_Descripcion = value; }
      }

      [DataMember]
      public bool Agregar
      {
         get { return m_Agregar; }
         set { m_Agregar = value; }
      }
      [DataMember]
      public String CTAR_Tipo { set; get; }

      public Boolean Trasanct
      {
         get { return m_Trasanct; }
         set { m_Trasanct = value; }
      }

      [DataMember]
      public Decimal DDOV_ValorTotal { set; get; }


      [DataMember]
      public Decimal DDOV_ValorTotalD { set; get; }

      [DataMember]
      public Int32 SOPE_Item { set; get; }

      [DataMember]
      public Servicio ItemServicio { get; set; }

      #endregion
   }
}
