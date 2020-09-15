using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServiciosDocumentos
	{
		#region [ Consultas ]
        ObservableCollection<ServiciosDocumentos> GetAllServiciosDocumentosByServCodigo(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
        bool Insert(ref ServiciosDocumentos Item);
        bool Update(ref ServiciosDocumentos Item);
        bool Delete(ref ServiciosDocumentos Item);
		#endregion
	}
}
