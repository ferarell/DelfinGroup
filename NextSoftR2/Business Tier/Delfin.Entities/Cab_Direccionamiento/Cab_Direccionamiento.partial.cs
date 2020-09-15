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
	public partial class Cab_Direccionamiento
   {
      #region [ Variables ]
      private String m_cliente;
      private String m_lnaviera;
      private String m_dtemporal;
      private String m_nave_nombre;
      #endregion
      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: Contrato.
      /// </summary>
      [DataMember]
      public String Cliente
      {
         get { return m_cliente; }
         set { m_cliente = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Contrato.
      /// </summary>
      [DataMember]
      public String LNaviera
      {
         get { return m_lnaviera; }
         set { m_lnaviera = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Contrato.
      /// </summary>
      [DataMember]
      public String DTemporal
      {
         get { return m_dtemporal; }
         set { m_dtemporal = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Contrato.
      /// </summary>
      [DataMember]
      public String NAVE_Nombre
      {
         get { return m_nave_nombre; }
         set { m_nave_nombre = value; }
      }
      #endregion
   }
}
