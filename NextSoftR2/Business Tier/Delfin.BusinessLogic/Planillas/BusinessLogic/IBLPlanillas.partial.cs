using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLPlanillas
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      Boolean SaveLevantarRespuesta(Infrastructure.Aspect.Constants.CCabeceraRDetracciones RDetraccion, ref String x_resultado);

		#endregion
	}
}
