using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLoadingList
	{
		#region [ Consultas ]
        LoadingList GetALoadingListByLoad_Codigo(Nullable<Int32> LOAD_Codigo);
		#endregion
		
		#region [ Metodos ]
     Boolean SaveControlDoc(ref LoadingList Item);
      Boolean SaveImportResumido(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_Mensajeerror);
      ObservableCollection<LoadingList> GetAllImportResumido(DateTime LOAD_CargaFecha);

      Boolean SaveImportDetallado(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError);
      ObservableCollection<LoadingListDetallado> GetAllImportDetallado(DateTime LOAD_CargaFecha);

      Boolean UpdateCorreo(Int32 LOAD_Codigo, Boolean LOAD_EnvioCorreo, String LOAD_EnvioCorreoUsr);
		#endregion
	}
}
