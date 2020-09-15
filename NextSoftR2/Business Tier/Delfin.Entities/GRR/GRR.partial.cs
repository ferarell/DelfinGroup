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
	public partial class GRR
   {
      #region [ Variables ]
      private ObservableCollection<GRR_Paquetes> m_listGRR_Paquetes;
      private ObservableCollection<GRR_Paquetes> m_listGRR_PaquetesDeleted;
      private ObservableCollection<GRR_Contrato> m_listGRR_Contratos;
      private ObservableCollection<GRR_Contrato> m_listGRR_ContratosDeleted;
      #endregion

      #region [ Propiedades ]
      public ObservableCollection<GRR_Paquetes> ListGRR_Paquetes
      {
         get
         {
            if (m_listGRR_Paquetes == null) { m_listGRR_Paquetes = new ObservableCollection<GRR_Paquetes>(); }
            return m_listGRR_Paquetes;
         }
         set { m_listGRR_Paquetes = value; }
      }
      public ObservableCollection<GRR_Paquetes> ListGRR_PaquetesDeleted
      {
         get
         {
            if (m_listGRR_PaquetesDeleted == null) { m_listGRR_PaquetesDeleted = new ObservableCollection<GRR_Paquetes>(); }
            return m_listGRR_PaquetesDeleted;
         }
         set { m_listGRR_PaquetesDeleted = value; }
      }
      public ObservableCollection<GRR_Contrato> ListGRR_Contratos
      {
         get
         {
            if (m_listGRR_Contratos == null) { m_listGRR_Contratos = new ObservableCollection<GRR_Contrato>(); }
            return m_listGRR_Contratos;
         }
         set { m_listGRR_Contratos = value; }
      }
      public ObservableCollection<GRR_Contrato> ListGRR_ContratosDeleted
      {
         get
         {
            if (m_listGRR_ContratosDeleted == null) { m_listGRR_ContratosDeleted = new ObservableCollection<GRR_Contrato>(); }
            return m_listGRR_ContratosDeleted;
         }
         set { m_listGRR_ContratosDeleted = value; }
      }

      public String ENTC_NomTransportista { get; set; }
      public String TIPO_DescMND { get; set; }
      public String REBA_TipoDesc {
         get {
            switch (REBA_Tipo)
            {
               case "G":
                  return "GRR";
               case "R":
                  return "Rebate";
               default:
                  return "";
            }
         }
      }
      #endregion
	}
}
