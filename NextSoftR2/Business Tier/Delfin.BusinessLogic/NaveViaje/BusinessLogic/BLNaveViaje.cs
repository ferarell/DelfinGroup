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
    public partial class BLNaveViaje : IBLNaveViaje
    {
        #region [ Propiedades ]
        [Dependency]
        public IBLDetNaveViaje BL_DetNaveViaje { get; set; }
        [Dependency]
        public IBLEntidad BL_Entidad { get; set; }
     
        //[Dependency]
        //public IBLCab_Cotizacion_OV BL_Cab_Cotizacion_OV { get; set; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<NaveViaje> GetAll()
        {
            try
            {
                return SelectAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public NaveViaje GetOne(Int32 NVIA_Codigo)
        {
            try
            {
                if (NVIA_Codigo == null) { return null; }
                NaveViaje Item = SelectOne(NVIA_Codigo);
                Item.ItemsDetNaveViaje = BL_DetNaveViaje.GetAllByNaveViaje(NVIA_Codigo);
                Item.ItemsNVIA_Clientes = BL_Entidad.GetAllEntidadByNVIA_Codigo(NVIA_Codigo, 1); //1 correo mandato - 2 correo otros tráficos
                Item.ItemsNVIA_DepTemp = GetAllCab_OV_CabByNVIA_Codigo(NVIA_Codigo); //Dep Temporal por OV segun Nave Viaje
                return Item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Int32 Save(ref NaveViaje Item)
        {
            try
            {
                Boolean m_isCorrect = true;
                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
                switch (Item.Instance)
                {
                    case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                        m_isCorrect = Insert(ref Item); break;
                    case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                        m_isCorrect = Update(ref Item); break;
                    case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                        m_isCorrect = Delete(ref Item); break;
                }
                if (m_isCorrect)
                {
                    if (Item.ItemsDetNaveViaje != null)
                    {
                        for (int i = 0; i < Item.ItemsDetNaveViaje.Count; i++)
                        {
                            DetNaveViaje itemDetNaveViaje = Item.ItemsDetNaveViaje[i];
                            itemDetNaveViaje.NVIA_Codigo = Item.NVIA_Codigo;
                            m_isCorrect = BL_DetNaveViaje.Save(ref itemDetNaveViaje);

                            if (!m_isCorrect)
                            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return -1; }
                        }

                        for (int i = 0; i < Item.ItemsDeletedDetNaveViaje.Count; i++)
                        {
                            DetNaveViaje itemDetNaveViaje = Item.ItemsDeletedDetNaveViaje[i];
                            m_isCorrect = BL_DetNaveViaje.Save(ref itemDetNaveViaje);

                            if (!m_isCorrect)
                            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return -1; }
                        }

                        if (m_isCorrect)
                        { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                        else
                        { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return -1; }
                    }
                    else
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return -1; }
                return Item.NVIA_Codigo;
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
        public Boolean Save(ref ObservableCollection<NaveViaje> Items)
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
