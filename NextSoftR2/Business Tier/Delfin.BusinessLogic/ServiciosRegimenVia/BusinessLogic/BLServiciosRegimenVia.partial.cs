using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
    public partial class BLServiciosRegimenVia 
	{
		#region [ Consultas ]
        public ObservableCollection<ServiciosRegimenVia> GetAllServiciosRegimenViaByServCodigo(Int32 SERV_Codigo)
        {                                                  
            try
            {
                if (SERV_Codigo == null) { return null; }
                return SelectAllServiciosRegimenViaByServCodigo(SERV_Codigo);
            }
            catch (Exception)
            { throw; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
