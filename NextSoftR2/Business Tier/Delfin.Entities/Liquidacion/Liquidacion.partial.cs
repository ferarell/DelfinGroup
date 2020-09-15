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
	public partial class Liquidacion
	{

      #region [ Propiedades ]

      [DataMember]
      public ObservableCollection<Entities.CtaCte> ListCtaCte { get; set; }
      [DataMember]
      public ObservableCollection<Entities.CtaCte> ListCtaCteEliminados { get; set; }
      
      #endregion

      #region [ Metodos ]

      public enum Estado
      {
         Abierta = 0, Cerrada = 1, Anulada = 2, Liquidado = 3
      }

      public enum TOperacion
      {
         Anular = 0, Aprobar = 1, Liquidar = 2
      }

      public void SetEstado(Estado x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case Estado.Abierta:
                  m_liqu_estado = "A";
                  break;
               case Estado.Cerrada:
                  m_liqu_estado = "C";
                  break;
               case Estado.Anulada:
                  m_liqu_estado = "X";
                  break;
               case Estado.Liquidado:
                  m_liqu_estado = "L";
                  break;
               default:
                  m_liqu_estado = null;
                  break;
            }
         }
         catch (Exception)
         { }
      }

      #endregion
   }
}
