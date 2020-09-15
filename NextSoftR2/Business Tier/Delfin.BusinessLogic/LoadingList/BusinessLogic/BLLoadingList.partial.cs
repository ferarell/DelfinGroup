using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;

namespace Delfin.BusinessLogic
{
	public partial class BLLoadingList
	{
		#region [ Consultas ]
        public LoadingList GetALoadingListByLoad_Codigo(Nullable<Int32> LOAD_Codigo)
        {
            try
            {
                return SelectALoadingListByLoad_Codigo(LOAD_Codigo);
            }
            catch (Exception)
            { throw; }
        }
		#endregion
		
		#region [ Metodos ]
      public Boolean SaveImportResumido(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError)
      {
         try
         {
            return ImportResumido(dtImportacion, LOAD_CargaUsuario, LOAD_CargaFecha, CONS_TabVIA, CONS_CodVIA, ref LOAD_MensajeError);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<LoadingList> GetAllImportResumido(DateTime LOAD_CargaFecha)
      {
         try
         {
            return SelectImportResumido(LOAD_CargaFecha);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveImportDetallado(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError)
      {
         try
         {
            return ImportDetallado(dtImportacion, LOAD_CargaUsuario, LOAD_CargaFecha, CONS_TabVIA, CONS_CodVIA, ref LOAD_MensajeError);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<LoadingListDetallado> GetAllImportDetallado(DateTime LOAD_CargaFecha)
      {
         try
         {
            return SelectImportDetallado(LOAD_CargaFecha);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean UpdateCorreo(Int32 LOAD_Codigo, Boolean LOAD_EnvioCorreo, String LOAD_EnvioCorreoUsr)
      {
          try
          {
              return UpdateCorreoPreAlerta(LOAD_Codigo,LOAD_EnvioCorreo,LOAD_EnvioCorreoUsr);
          }
          catch (Exception)
          { throw; }
      }

      public Boolean SaveControlDoc(ref LoadingList Item)
      {
          try
          {
              Boolean m_isCorrect = true;
              Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
              switch (Item.Instance)
              {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                      m_isCorrect = InsertControlDoc(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                      m_isCorrect = UpdateControlDoc(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                      m_isCorrect = DeleteControlDoc(ref Item); break;
              }
              if (m_isCorrect)
              { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
              else
              { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
              return m_isCorrect;
          }
          catch (Exception)
          { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
		#endregion
	}
}
