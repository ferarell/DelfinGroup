using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;
using System.Data;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      //
      //ObservableCollection<Entidad> GetAllEntidadByNomCompleto(String ENTC_NomCompleto);

      Entidad GetOneEntidadValidarDocIden(Int32 ENTC_Codigo, String TIPO_TabTDI, String TIPO_CodTDI, String ENTC_DocIden);

      DataTable GetTodosEntidadByTIPE_Codigo(Nullable<Int16> x_TIPE_Codigo);

      Entidad GetEntidadOnePorRuc(String x_ENTC_DocIden, Nullable<Int16> x_TIPE_Codigo);

      ObservableCollection<Entidad> GetAllEntidadByNVIA_Codigo(Int32 NVIA_codigo, Int32 TIPO_correo);

      #region [ Control Entidad ]

      ObservableCollection<Entidad> GetAllEntidadByTipoEntidadAndText(Int16 TIPE_CODIGO, string Text, Boolean Activo, String ENTC_DOCIDEN);

      #endregion

      
      ObservableCollection<Entidad> GetAllEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      Boolean GetOneEntidadLimiteCredito(Int16 EMPR_Codigo, Int32 ENTC_Codigo, ref Decimal Monto, ref Int16 DiasDuracion);
   }
}
