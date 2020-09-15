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
      String UsuarioPuertos { get; set; }
      
      ObservableCollection<Puerto> GetAllPuertoByVia(String CONS_TabVia, String CONS_CodVia);

      Puerto GetOnePuertoByCodEstandar(String CONS_TabVia, String CONS_CodVia, String PUER_CodEstandar);

      ObservableCollection<Puerto> GetAllPuertoByAyuda(String CONS_TabVia, String CONS_CodVia, String TIPO_TabPais, String TIPO_CodPais, String PUER_CodEstandar, String PUER_Nombre);
   }
}
