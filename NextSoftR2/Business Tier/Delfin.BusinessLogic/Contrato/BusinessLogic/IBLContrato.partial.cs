using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLContrato
	{
		#region [ Consultas ]
      ObservableCollection<Contrato> GetAllByFiltro(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta, Boolean CONT_Activo);
      ObservableCollection<Contrato> GetAllByAyuda(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta);
      System.Data.DataTable GetAllByAyudaPivot(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CCOT_Versionada = false);
      System.Data.DataTable GetAllByAyudaPivotOV(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino);
      System.Data.DataTable GetAllByReporte(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo);
      System.Data.DataTable GetAllByReporteCosto(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo);
      #endregion
		
		#region [ Metodos ]
      Contrato GetOneCopy(Int16 EMPR_Codigo, Int32 CONT_Codigo, String AUDI_Usuario);
      Boolean GetOneValidacion(Int32 CONT_Codigo, String CONT_Numero, DateTime CONT_FecIni, DateTime CONT_FecFin);

      Contrato CopiarContrato(Boolean CopiarContrato, Contrato Item, Contrato ItemNew, String AUDI_Usuario, Int32 PUER_Codigo);
		#endregion
	}
}
