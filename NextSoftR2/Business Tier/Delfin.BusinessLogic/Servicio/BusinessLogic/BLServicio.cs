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
    public partial class BLServicio : IBLServicio
    {
        #region [ Propiedades ]
        [Dependency]
        public IBLServicio_Via BL_ServicioVia { get; set; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Servicio> GetAll()
        {
            try
            {
                return SelectAll(); ;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Servicio GetOne(Int32 SERV_Codigo)
        {
            try
            {
                Servicio item = SelectOne(SERV_Codigo);
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public System.Data.DataTable GetServiciosAdicionales(Int32 SERV_Codigo)
        {
            try
            {
                return SelectServiciosAdicionales(SERV_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Servicio Item)
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

                //DOCUMENTOS
                if (m_isCorrect)
                {
                    if (Item.ServiciosDocumentos != null && Item.ServiciosDocumentos.Count > 0)
                    {
                        for (int indexServicioDoc = 0; indexServicioDoc < Item.ServiciosDocumentos.Count; indexServicioDoc++)
                        {
                            ServiciosDocumentos _itemServicioDoc = Item.ServiciosDocumentos[indexServicioDoc];
                            _itemServicioDoc.SERV_Codigo = Item.SERV_Codigo;
                            _itemServicioDoc.TIPO_TabTDO = "TDO";
                            m_isCorrect = BL_ServicioDocumento.Save(ref _itemServicioDoc);
                            if (!m_isCorrect) { break; }
                        }
                    }
                    if (m_isCorrect)
                    {
                        if (Item.ServiciosDocumentosDelete != null && Item.ServiciosDocumentosDelete.Count > 0)
                        {
                            for (int indexServicioDocDelete = 0; indexServicioDocDelete < Item.ServiciosDocumentosDelete.Count; indexServicioDocDelete++)
                            {
                                ServiciosDocumentos _itemServicioDocDelete = Item.ServiciosDocumentosDelete[indexServicioDocDelete];
                                _itemServicioDocDelete.SERV_Codigo = Item.SERV_Codigo;
                                _itemServicioDocDelete.TIPO_TabTDO = "TDO";
                                m_isCorrect = BL_ServicioDocumento.Save(ref _itemServicioDocDelete);
                                if (!m_isCorrect) { break; }
                            }
                        }
                    }
                }


                //LINEA NEGOCIO

                if (m_isCorrect)
                {
                    if (Item.ServiciosLineaNegocio != null && Item.ServiciosLineaNegocio.Count > 0)
                    {
                        for (int indexServicioLn = 0; indexServicioLn < Item.ServiciosLineaNegocio.Count; indexServicioLn++)
                        {
                            ServiciosLineaNegocio _itemServicioLn = Item.ServiciosLineaNegocio[indexServicioLn];
                            _itemServicioLn.SERV_Codigo = Item.SERV_Codigo;
                            _itemServicioLn.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                            _itemServicioLn.AUDI_UsrMod = Item.AUDI_UsrMod;

                            //_itemServicioLn.AUDI_FecCrea = Item.AUDI_FecCrea;
                            //_itemServicioLn.AUDI_FecMod = Item.AUDI_FecMod;
                            m_isCorrect = BL_ServicioLineaNegocio.Save(ref _itemServicioLn);
                            if (!m_isCorrect) { break; }
                        }
                    }
                    if (m_isCorrect)
                    {
                        if (Item.ServiciosLineaNegocioDelete != null && Item.ServiciosLineaNegocioDelete.Count > 0)
                        {
                            for (int indexServicioLnDelete = 0; indexServicioLnDelete < Item.ServiciosLineaNegocioDelete.Count; indexServicioLnDelete++)
                            {
                                ServiciosLineaNegocio _itemServicioLnDelete = Item.ServiciosLineaNegocioDelete[indexServicioLnDelete];
                                _itemServicioLnDelete.SERV_Codigo = Item.SERV_Codigo;
                               
                                m_isCorrect = BL_ServicioLineaNegocio.Save(ref _itemServicioLnDelete);
                                if (!m_isCorrect) { break; }
                            }
                        }
                    }
                }

                //REGIMEN VIA

                //if (m_isCorrect)
                //{
                //    if (Item.ServiciosRegimenVia != null && Item.ServiciosRegimenVia.Count > 0)
                //    {
                //        for (int indexServicioRv = 0; indexServicioRv < Item.ServiciosRegimenVia.Count; indexServicioRv++)
                //        {
                //            ServiciosRegimenVia _itemServicioRv = Item.ServiciosRegimenVia[indexServicioRv];
                //            _itemServicioRv.SERV_Codigo = Item.SERV_Codigo;
                //            _itemServicioRv.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                //            _itemServicioRv.AUDI_UsrMod = Item.AUDI_UsrMod;

                //            //_itemServicioLn.AUDI_FecCrea = Item.AUDI_FecCrea;
                //            //_itemServicioLn.AUDI_FecMod = Item.AUDI_FecMod;
                //            m_isCorrect = BL_ServicioRegimenVia.Save(ref _itemServicioRv);
                //            if (!m_isCorrect) { break; }
                //        }
                //    }
                //    if (m_isCorrect)
                //    {
                //        if (Item.ServiciosRegimenViaDelete != null && Item.ServiciosRegimenViaDelete.Count > 0)
                //        {
                //            for (int indexServicioRvDelete = 0; indexServicioRvDelete < Item.ServiciosRegimenViaDelete.Count; indexServicioRvDelete++)
                //            {
                //                ServiciosRegimenVia _itemServicioRvDelete = Item.ServiciosRegimenViaDelete[indexServicioRvDelete];
                //                _itemServicioRvDelete.SERV_Codigo = Item.SERV_Codigo;

                //                m_isCorrect = BL_ServicioRegimenVia.Save(ref _itemServicioRvDelete);
                //                if (!m_isCorrect) { break; }
                //            }
                //        }
                //    }
                //}




                if (m_isCorrect)
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
                return m_isCorrect;
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
        public Boolean Save(ref ObservableCollection<Servicio> Items)
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
