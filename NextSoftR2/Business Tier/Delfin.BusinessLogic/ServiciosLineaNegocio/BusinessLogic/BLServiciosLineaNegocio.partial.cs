using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
    public partial class BLServiciosLineaNegocio 
	{
		#region [ Consultas ]
        public ObservableCollection<ServiciosLineaNegocio> GetAllServiciosLineaNegocioByServCodigo(Int32 SERV_Codigo)
        {                                                  
            try
            {
                if (SERV_Codigo == null) { return null; }
                return SelectAllServiciosLineaNegocioByServCodigo(SERV_Codigo);
            }
            catch (Exception)
            { throw; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
