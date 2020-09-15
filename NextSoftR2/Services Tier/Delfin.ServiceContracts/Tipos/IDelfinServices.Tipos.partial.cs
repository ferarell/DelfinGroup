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
      String UsuarioTipos { get; set; }
      ObservableCollection<Tipos> GetAllTiposByTipoCodTabla(String TIPO_CodTabla);

      ObservableCollection<Tipos> GetAllTiposFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
   }
}
