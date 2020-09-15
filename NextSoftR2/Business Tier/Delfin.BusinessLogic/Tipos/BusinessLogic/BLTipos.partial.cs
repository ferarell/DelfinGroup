using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Infrastructure.Aspect.Collections;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Microsoft.Practices.Unity;

namespace Delfin.BusinessLogic
{
	public partial class BLTipos
	{
		#region [ Consultas ]

      public String UsuarioTipos { get; set; }

      private ObservableCollection<Tipos> CargarTablaXML(String x_tipo_codtabla)
      {
         try
         {
            Infrastructure.Aspect.CheckSUM.GenerarChekSum x_CargarTabla = new Infrastructure.Aspect.CheckSUM.GenerarChekSum(Infrastructure.Aspect.CheckSUM.GenerarChekSum.PathAppPublic, UsuarioTipos);
            System.Data.DataTable dtTabla = x_CargarTabla.CargarXML(new Infrastructure.Aspect.CheckSUM.CHKS_Tablas() { CHKS_Tabla = "Tipos" });
            ObservableCollection<Tipos> ListTipos = new ObservableCollection<Tipos>();

            if (dtTabla != null)
            {
               ListTipos = dtTabla.ToObservableCollection<Tipos>().Where(tipo => tipo.TIPO_CodTabla == x_tipo_codtabla).ToObservableCollection();
            }
            else
            {
               return SelectAllByTipoCodTabla(x_tipo_codtabla);
            }
            return ListTipos;
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Tipos> GetAllByTipoCodTabla(String TIPO_CodTabla)
      {
         try
         {
            //return SelectAllByTipoCodTabla(TIPO_CodTabla);
            return CargarTablaXML(TIPO_CodTabla);
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
