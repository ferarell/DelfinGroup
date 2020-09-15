using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Operacion
	{
		#region [ Consultas ]
      public DataTable GetAyudaOperacionXProveedor(Int32 x_COPE_Codigo, String x_Moneda, Decimal x_TipoCambio, Int32 x_CCCT_Codigo)
      {
         try
         {
            return SelectAyudaOperacionXProveedor(x_COPE_Codigo, x_Moneda, x_TipoCambio, x_CCCT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Boolean UpdateEstado(Int32 x_COPE_Codigo, String x_CTAR_Tipo, Int32 x_CCCT_Codigo, Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo, Decimal x_Monto, Boolean x_UltimoCosto, String x_Usuario, String x_DOPE_Items)
      {
         try
         {
            return ActualizaEstado(x_COPE_Codigo, x_CTAR_Tipo, x_CCCT_Codigo, x_TIPE_Codigo, x_ENTC_Codigo, x_Monto, x_UltimoCosto, x_Usuario, x_DOPE_Items);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Boolean DeleteServicioCtaCte(CtaCte ItemCtaCte)
      {
         try
         {
            return EliminarServicioCtaCte(ItemCtaCte);
         }
         catch (Exception)
         { throw; }
      }

      public DataTable GetServicioByOperacion(Int32 x_COPE_Codigo)
      {
          try { return ServicioByOperacion(x_COPE_Codigo); }
          catch (Exception ex)
          { throw ex; }
      }
      public DataTable GetVerificaServicioFacturado(Int32 x_COPE_Codigo, Int32 x_DOPE_Item)
      {
          try { return VerificaServicioFacturado(x_COPE_Codigo, x_DOPE_Item); }
          catch (Exception ex)
          { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
      public Boolean UpdateDetOperacionPreFactura(Int32 x_COPE_Codigo, Int32 x_DOPE_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodEST)
      {
          try
          {
              Boolean m_isCorrect = true;
              m_isCorrect = UpdateDetOperacion(x_COPE_Codigo, x_DOPE_Item, x_PDDO_Item, x_DOCV_Codigo, x_CONS_CodEST);
              return m_isCorrect;
          }
          catch (Exception)
          {  throw; }
      }
		#endregion
	}
}
