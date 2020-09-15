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
      String UsuarioParametros { get; set; }

      Parametros GetOneParametrosByClave(String PARA_Clave);

      ObservableCollection<Parametros> GetAllParametrosByClave(String PARA_Clave);
   }
}