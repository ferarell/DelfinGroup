using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;

namespace Delfin.BusinessLogic
{
   public partial interface IBLEntidad
   {
      #region [ Consultas ]
      
      //ObservableCollection<Entidad> GetAllByNomCompleto(String ENTC_NomCompleto);
      DataTable GetTodosEntidadByTIPE_Codigo(Nullable<Int16> x_TIPE_Codigo);
      
      Entidad GetEntidadOnePorRuc(String x_ENTC_DocIden, Nullable<Int16> x_TIPE_Codigo);
      
      ObservableCollection<Entidad> GetAllEntidadByNVIA_Codigo(Int32 NVIA_codigo, Int32 TIPO_correo);

      #region [ Control Entidad ]

      ObservableCollection<Entidad> GetAllByTipoEntidadAndText(Int16 TIPE_CODIGO, string Text, Boolean Activo, String ENTC_DOCIDEN);
      #endregion
      ObservableCollection<Entidad> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      Boolean GetLimiteCredito(Int16 EMPR_Codigo, Int32 ENTC_Codigo, ref Decimal Monto, ref Int16 DiasDuracion);
      
      #endregion

      #region [ Metodos ]

      Entidad GetOneValidarDocIden(Int32 ENTC_Codigo, String TIPO_TabTDI, String TIPO_CodTDI, String ENTC_DocIden);
      
      #endregion
   }
}
