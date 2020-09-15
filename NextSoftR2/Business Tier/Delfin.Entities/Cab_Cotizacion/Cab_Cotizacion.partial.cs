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
   public partial class Cab_Cotizacion
   {
      #region [ Variables Adicionales ]
      private String m_Cliente;
      private String m_CONS_CodEstadosTR;
      private ObservableCollection<Det_Cotizacion> m_itemsDet_Cotizacion;
      private ObservableCollection<Det_Cotizacion_Servicio> m_itemsDet_Cotizacion_Servicio;
      #endregion

      #region [ Propiedades Adicionales ]
      [DataMember]
      public String Cliente
      {
         get { return m_Cliente; }
         set { m_Cliente = value; }
      }

      [DataMember]
      public String Transportista { set; get; }

      [DataMember]
      public String Agente { set; get; }

      [DataMember]
      public String MonedaSTR { set; get; }

      [DataMember]
      public String CONS_CodEstadosTR
      {
         get { return m_CONS_CodEstadosTR; }
         set { m_CONS_CodEstadosTR = value; }
      }
      [DataMember]
      public ObservableCollection<Det_Cotizacion> ItemsDet_Cotizacion
      {
         get { return m_itemsDet_Cotizacion; }
         set { m_itemsDet_Cotizacion = value; }
      }
      [DataMember]
      public ObservableCollection<Det_Cotizacion_Servicio> ItemsDet_Cotizacion_Servicio
      {
         get { return m_itemsDet_Cotizacion_Servicio; }
         set { m_itemsDet_Cotizacion_Servicio = value; }
      }

      [DataMember]
      public String LNaviera { get; set; }

      #endregion
   }
}
