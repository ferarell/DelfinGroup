using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Cotizacion_OV_Servicio : IBLDet_Cotizacion_OV_Servicio
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Det_Cotizacion_OV_Servicio> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Det_Cotizacion_OV_Servicio GetOne(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 SCOT_Item)
		{
			try
			{
				if (CCOT_Tipo == null || CCOT_Numero == null || SCOT_Item == null) { return null; }
				return SelectOne(CCOT_Tipo, CCOT_Numero, SCOT_Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]

      public Boolean Save(ref Det_Cotizacion_OV_Servicio Item, Boolean tran, Cab_Cotizacion_OV.TipoInterfaz x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case Cab_Cotizacion_OV.TipoInterfaz.OVC_Normal:
                  return Save(ref Item, tran);
                  break;
               case Cab_Cotizacion_OV.TipoInterfaz.OVC_Prefacturada:
                  return SavePreFacturada(ref Item, tran);
                  break;
               default:
                  break;
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      public Boolean SavePreFacturada(ref Det_Cotizacion_OV_Servicio Item, Boolean tran)
      {
         try
         {
            Boolean m_isCorrect = true;
            if (tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction(); }
            switch (Item.Instance)
            {               
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateSerieNumero(ref Item); break;
            }
            if (tran)
            {
               if (m_isCorrect)
               {
                  Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction();

                  Det_Cotizacion_OV_Servicio _registro = SelectOne(Item.CCOT_Tipo, Item.CCOT_Numero, Item.SCOT_Item);
                  _registro.CopyTo(ref Item);
               }
               else
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            }
            return m_isCorrect;
         }
         catch (Exception)
         { if (tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } throw; }
      }

		public Boolean Save(ref Det_Cotizacion_OV_Servicio Item, Boolean tran)
		{
			try
			{
				Boolean m_isCorrect = true;
            if (tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction(); }
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete(ref Item); break;
				}
            if (tran)
            {
               if (m_isCorrect)
               {
                  Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction();

                  Det_Cotizacion_OV_Servicio _registro = SelectOne(Item.CCOT_Tipo, Item.CCOT_Numero, Item.SCOT_Item);
                  _registro.CopyTo(ref Item);
               }
               else
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            }
				return m_isCorrect;
			}
			catch (Exception)
         { if (tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } throw; }
		}
		public Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_Servicio> Items)
		{
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            for (int i = 0; i < Items.Count; i++)
            {
               var Item = Items.ElementAt(i);
               switch (Item.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     m_isCorrect = Insert(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     m_isCorrect = Update(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = Delete(ref Item); break;
               }
               if (!m_isCorrect)
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return m_isCorrect; }
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
