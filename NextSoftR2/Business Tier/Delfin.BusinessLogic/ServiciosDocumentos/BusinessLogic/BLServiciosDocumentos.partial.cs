using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
    public partial class BLServiciosDocumentos 
	{
		#region [ Consultas ]
        public ObservableCollection<ServiciosDocumentos> GetAllServiciosDocumentosByServCodigo(Int32 SERV_Codigo)
        {
            try
            {
                if (SERV_Codigo == null) { return null; }
                return SelectAllServiciosDocumentosByServCodigo(SERV_Codigo);
            }
            catch (Exception)
            { throw; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
