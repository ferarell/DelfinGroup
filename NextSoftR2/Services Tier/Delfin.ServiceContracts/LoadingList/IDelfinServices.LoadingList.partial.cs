using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
		#region [ Consultas ]
		#endregion

		#region [ Metodos ]
       Boolean SaveLoadingListControlDoc(LoadingList Item);

      Boolean SaveLoadingListImportResumido(System.Data.DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError);
      ObservableCollection<LoadingList> GetAllLoadingListImportResumido(DateTime LOAD_CargaFecha);

      Boolean SaveLoadingListImportDetallado(System.Data.DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError);
      ObservableCollection<LoadingListDetallado> GetAllLoadingListImportDetallado(DateTime LOAD_CargaFecha);

       Boolean UpdateLoadingListCorreo (Int32 LOAD_Codigo, Boolean LOAD_EnvioCorreo, String LOAD_EnvioCorreoUsr);

       LoadingList GetALoadingListByLoad_Codigo(Nullable<Int32> LOAD_Codigo);
		#endregion
   }
}
