using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.Collections;

namespace Delfin.BusinessLogic
{
   public partial class BLEntidad : IBLEntidad   //, IBLEntidad_Acuerdo, IBLEntidad_Servicio, IBLENTC_Contacto
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLEntidad_Acuerdo BL_EntidadAcuerdo { get; set; }
      [Dependency]
      public IBLEntidad_Servicio BL_EntidadServicio { get; set; }
      [Dependency]
      public IBLEntidadLimiteCredito BL_EntidadLimiteCredito { get; set; }
      [Dependency]
      public IBLEntidadCuentaBancaria BL_EntidadCuentaBancaria { get; set; }

      [Dependency]
      public IBLDirecENTC BL_DirecENTC { get; set; }

      [Dependency]
      public Entidad_Relacionados BLDepTemporalEntidad { get; set; }

      [Dependency]
      public IBLEntidad_Relacionados BL_EntidadRelacionados { get; set; }
      #endregion

      #region [ Consultas ]
      public ObservableCollection<Entidad> GetAll(Nullable<Int16> x_TIPE_Codigo = null, string x_ENTC_NomCompleto = null)
      {
         try
         {
            return SelectAll(x_TIPE_Codigo, x_ENTC_NomCompleto);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Entidad GetOne(Int32 ENTC_Codigo, Nullable<Int16> x_TIPE_Codigo = null, Boolean x_soloentidad = false)
      {
         try
         {
            if ((Convert.ToInt32(ENTC_Codigo.ToString()) == 0)) { return null; }

            Entidad itemEntidad = SelectOne(ENTC_Codigo, x_TIPE_Codigo);
            if (itemEntidad != null && !x_soloentidad)
            {
               itemEntidad.Relacionados = new ObservableCollection<Entidad>();
               ObservableCollection<Entidad_Relacionados> listEntidadEntidad_Relacionados = BL_EntidadRelacionados.GetAllPorEntidadPadre(itemEntidad.ENTC_Codigo);
               if (listEntidadEntidad_Relacionados != null && listEntidadEntidad_Relacionados.Count > 0)
               {
                  foreach (Entities.Entidad_Relacionados item in listEntidadEntidad_Relacionados)
                  {
                     if (item.ENTC_CodHijo.HasValue && item.TIPE_CodHijo.HasValue)
                     {
                        Entidad _entidad = SelectOne(item.ENTC_CodHijo.Value, item.TIPE_CodHijo.Value);
                        _entidad.Relacionado = item;
                        _entidad.CONS_RGM = item.CONS_RGM;
                        _entidad.RELA_TipoRelacion = item.RELA_TipoRelacion;
                        _entidad.TIPO_TRF = item.TIPO_TRF;
                        _entidad.TIPE_Hijo = item.TIPE_Hijo;
                        itemEntidad.Relacionados.Add(_entidad);
                     }
                  }
               }

               switch (itemEntidad.TIPE_Codigo)
               {
                  case 1:
                  case 6:
                     itemEntidad.EntidadDeposito = GetAllDepositoTemporalByCliente(itemEntidad.ENTC_Codigo);

                     //si es Cliente, buscamos sus servcios por cliente
                     ObservableCollection<Entidad_Servicio> x_Listentidadservicio = new ObservableCollection<Entidad_Servicio>();

                     x_Listentidadservicio = BL_EntidadServicio.GetAll(ENTC_Codigo);

                     if (x_Listentidadservicio != null)
                     {
                        if (x_Listentidadservicio.Count > 0)
                        { itemEntidad.m_listServicio = x_Listentidadservicio; }
                     }

                     break;
                  case 2:
                     
                     break;
               }


             

               #region Direcciones
               /*
                * Obtener Direcciones
                */
               ObservableCollection<Entities.DirecENTC> x_ListDirecciones = new ObservableCollection<DirecENTC>();
               x_ListDirecciones = BL_DirecENTC.GetAll(ENTC_Codigo);

               itemEntidad.DIRE_Direccion = null;
               itemEntidad.DIRE_DireccionComercial = null;
               if (x_ListDirecciones.Where(Dir => Dir.DIRE_Facturar).ToObservableCollection().Count > 0)
               {
                  itemEntidad.DirecEntcFiscal = x_ListDirecciones.Where(Dir => Dir.DIRE_Facturar).FirstOrDefault();
                  itemEntidad.DIRE_Direccion = itemEntidad.DirecEntcFiscal.DIRE_Direccion;
                  itemEntidad.UBIG_CodigoFiscal = itemEntidad.DirecEntcFiscal.UBIG_Codigo;
                  itemEntidad.TIPO_CodPaisFiscal = itemEntidad.DirecEntcFiscal.TIPO_CodPais;
               }
               if (x_ListDirecciones.Where(Dir => !Dir.DIRE_Facturar).ToObservableCollection().Count > 0)
               {
                  itemEntidad.DirecEntcComercial = x_ListDirecciones.Where(Dir => !Dir.DIRE_Facturar).FirstOrDefault();
                  itemEntidad.DIRE_DireccionComercial = itemEntidad.DirecEntcComercial.DIRE_Direccion;
                  itemEntidad.UBIG_CodigoComercial = itemEntidad.DirecEntcComercial.UBIG_Codigo;
                  itemEntidad.TIPO_CodPaisComercial = itemEntidad.DirecEntcComercial.TIPO_CodPais;
               }
               #endregion

               /*
                * Acuerdos
                */
               itemEntidad.EntidadAcuerdo = new Entidad_Acuerdo();
               itemEntidad.EntidadAcuerdo = BL_EntidadAcuerdo.GetOne(ENTC_Codigo);
            }
            return itemEntidad;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      public Entidad Save(ref Entidad Item)
      {
         Boolean m_isCorrect = true;
         try
         {
            //BLENTC_Contacto x_BLentc_contacto;
            // Comenzar Transacción
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            // Grabar Entidad
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  #region Direcciones
                  if (!String.IsNullOrEmpty(Item.DIRE_DireccionComercial))
                  {
                     Item.DirecEntcComercial = new DirecENTC();
                     Item.DirecEntcComercial.ENTC_Codigo = Item.ENTC_Codigo;
                     Item.DirecEntcComercial.DIRE_Direccion = Item.DIRE_DireccionComercial;
                     Item.DirecEntcComercial.UBIG_Codigo = Item.UBIG_CodigoComercial;
                     Item.DirecEntcComercial.TIPO_CodPais = Item.TIPO_CodPaisComercial;
                     Item.DirecEntcComercial.TIPO_TabPais = Item.TIPO_TabPaisComercial;
                     Item.DirecEntcComercial.DIRE_Facturar = false;
                     Item.DirecEntcComercial.DIRE_Activo = true;
                     Item.DirecEntcComercial.Instance = InstanceEntity.Added;
                     Item.DirecEntcComercial.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  }
                  if (!String.IsNullOrEmpty(Item.DIRE_Direccion))
                  {
                     Item.DirecEntcFiscal = new DirecENTC();
                     //Item.DirecEntcFiscal.DIRE_Facturar = true;
                     Item.DirecEntcFiscal.ENTC_Codigo = Item.ENTC_Codigo;
                     Item.DirecEntcFiscal.DIRE_Direccion = Item.DIRE_Direccion;
                     Item.DirecEntcFiscal.UBIG_Codigo = Item.UBIG_CodigoFiscal;
                     Item.DirecEntcFiscal.TIPO_CodPais = Item.TIPO_CodPaisFiscal;
                     Item.DirecEntcFiscal.TIPO_TabPais = Item.TIPO_TabPaisFiscal;
                     Item.DirecEntcFiscal.DIRE_Facturar = true;
                     Item.DirecEntcFiscal.DIRE_Activo = true;
                     Item.DirecEntcFiscal.Instance = InstanceEntity.Added;
                     Item.DirecEntcFiscal.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  }
                  #endregion
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  #region Direcciones
                  if (!String.IsNullOrEmpty(Item.DIRE_DireccionComercial))
                  {
                     if (Item.DirecEntcComercial == null)
                     {
                        Item.DirecEntcComercial = new DirecENTC();
                        Item.DirecEntcComercial.Instance = InstanceEntity.Added;
                        Item.DirecEntcComercial.AUDI_UsrCrea = Item.AUDI_UsrMod;
                     }
                     else
                     {
                        Item.DirecEntcComercial.AUDI_UsrMod = Item.AUDI_UsrMod;
                     }
                     Item.DirecEntcComercial.TIPO_CodPais = Item.TIPO_CodPaisComercial;
                     Item.DirecEntcComercial.TIPO_TabPais = Item.TIPO_TabPaisComercial;
                     Item.DirecEntcComercial.ENTC_Codigo = Item.ENTC_Codigo;
                     Item.DirecEntcComercial.DIRE_Direccion = Item.DIRE_DireccionComercial;
                     Item.DirecEntcComercial.UBIG_Codigo = Item.UBIG_CodigoComercial;
                     Item.DirecEntcComercial.DIRE_Facturar = false;
                     Item.DirecEntcComercial.DIRE_Activo = true;
                  }
                  else
                  {
                     if (Item.DirecEntcComercial != null) { Item.DirecEntcComercial.Instance = InstanceEntity.Deleted; }
                  }
                  if (!String.IsNullOrEmpty(Item.DIRE_Direccion))
                  {
                     if (Item.DirecEntcFiscal == null)
                     {
                        Item.DirecEntcFiscal = new DirecENTC();
                        Item.DirecEntcFiscal.DIRE_Facturar = true;
                        Item.DirecEntcFiscal.Instance = InstanceEntity.Added;
                        Item.DirecEntcFiscal.AUDI_UsrCrea = Item.AUDI_UsrMod;
                     }
                     else
                     {
                        Item.DirecEntcFiscal.AUDI_UsrMod = Item.AUDI_UsrMod;
                     }
                     Item.DirecEntcFiscal.TIPO_CodPais = Item.TIPO_CodPaisFiscal;
                     Item.DirecEntcFiscal.TIPO_TabPais = Item.TIPO_TabPaisFiscal;
                     Item.DirecEntcFiscal.ENTC_Codigo = Item.ENTC_Codigo;
                     Item.DirecEntcFiscal.DIRE_Direccion = Item.DIRE_Direccion;
                     Item.DirecEntcFiscal.UBIG_Codigo = Item.UBIG_CodigoFiscal;
                     Item.DirecEntcFiscal.DIRE_Facturar = true;
                     Item.DirecEntcFiscal.DIRE_Activo = true;
                  }
                  else
                  { if (Item.DirecEntcFiscal != null) { Item.DirecEntcFiscal.Instance = InstanceEntity.Deleted; } }
                  #endregion
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item);
                  if (m_isCorrect)
                  { return null; }
                  else
                  { return Item; }
            }

            #region Actualizar Direcciones
            /*
             * Actualizar Direcciones
             */
            if (Item.DirecEntcFiscal != null)
            {
               DirecENTC _dfiscal = Item.DirecEntcFiscal;
               _dfiscal.Transaccion = false;
               BL_DirecENTC.Save(ref _dfiscal);
            }
            if (Item.DirecEntcComercial != null)
            {
               DirecENTC _dcomercial = Item.DirecEntcComercial;
               _dcomercial.Transaccion = false;
               BL_DirecENTC.Save(ref _dcomercial);
            }
            #endregion

            #region Datos Financieros
            /*
             * Actualizar Datos Financieros de Cliente
             */
            if (Item.ListEntidadLimiteCreditosCliente != null && Item.ListEntidadLimiteCreditosCliente.Count > 0)
            {
               foreach (Entities.EntidadLimiteCredito iLimCredCli in Item.ListEntidadLimiteCreditosCliente)
               {
                  iLimCredCli.ENTC_Codigo = Item.ENTC_Codigo;
                  iLimCredCli.TIPE_Codigo = Item.TIPE_Codigo;
                  Entities.EntidadLimiteCredito _iLimCredCli = iLimCredCli;
                  BL_EntidadLimiteCredito.Save(ref _iLimCredCli);
               }
            }
            /*
             * Actualizar Datos Financieros de Proveedor
             */
            if (Item.ListEntidadLimiteCreditosProveedor != null && Item.ListEntidadLimiteCreditosProveedor.Count > 0)
            {
               foreach (Entities.EntidadLimiteCredito iLimCredPro in Item.ListEntidadLimiteCreditosProveedor)
               {
                  iLimCredPro.ENTC_Codigo = Item.ENTC_Codigo;
                  iLimCredPro.TIPE_Codigo = Item.TIPE_Codigo;
                  Entities.EntidadLimiteCredito _iLimCredPro = iLimCredPro;
                  BL_EntidadLimiteCredito.Save(ref _iLimCredPro);
               }
            }

            if (Item.ListEntidadCuentaBancariasEliminados != null && Item.ListEntidadCuentaBancariasEliminados.Count > 0)
            {
               foreach (Entities.EntidadCuentaBancaria iECBancaria in Item.ListEntidadCuentaBancariasEliminados)
               {
                  Entities.EntidadCuentaBancaria _iECBancaria = iECBancaria;
                  _iECBancaria.Instance = InstanceEntity.Deleted;
                  ;
                  BL_EntidadCuentaBancaria.Save(ref _iECBancaria);
               }
            }
            if (Item.ListEntidadCuentaBancarias != null && Item.ListEntidadCuentaBancarias.Count > 0)
            {
               foreach (Entities.EntidadCuentaBancaria iECBancaria in Item.ListEntidadCuentaBancarias)
               {
                  iECBancaria.ENTC_Codigo = Item.ENTC_Codigo;
                  Entities.EntidadCuentaBancaria _iECBancaria = iECBancaria;
                  BL_EntidadCuentaBancaria.Save(ref _iECBancaria);
               }
            }
            #endregion

            #region Acuerdos
            /*
             * Actualizar Acuerdos
             */
            if (Item.EntidadAcuerdo != null)
            {
               Entidad_Acuerdo x_entidad_acuerdo = new Entidad_Acuerdo();
               Item.EntidadAcuerdo.ENTC_Codigo = Item.ENTC_Codigo;
               x_entidad_acuerdo = Item.EntidadAcuerdo;
               m_isCorrect = BL_EntidadAcuerdo.Save(ref x_entidad_acuerdo);
            }
            #endregion

            #region Almacenados
            /*
             * Guardar Relacionados
             */
            if (Item.Relacionados != null && Item.Relacionados.Count > 0)
            {
               foreach (var x_contacto in Item.Relacionados)
               {
                  Entidad_Relacionados x_entidad_contacto = x_contacto.Relacionado;
                  x_entidad_contacto.ENTC_CodPadre = Item.ENTC_Codigo;
                  x_entidad_contacto.TIPE_CodPadre = Item.TIPE_Codigo;
                  x_entidad_contacto.RELA_Activo = true;
                  x_entidad_contacto.AUDI_UsrCrea = (String.IsNullOrEmpty(Item.AUDI_UsrCrea) ? Item.AUDI_UsrMod : Item.AUDI_UsrCrea);
                  x_entidad_contacto.AUDI_UsrMod = Item.AUDI_UsrCrea;
                  //x_entidad_contacto.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                  m_isCorrect = BL_EntidadRelacionados.Save(ref x_entidad_contacto);
               }
            }
            if (Item.RelacionadosEliminados != null && Item.RelacionadosEliminados.Count > 0)
            {
               foreach (var x_contacto in Item.RelacionadosEliminados)
               {
                  Entidad_Relacionados x_entidad_contacto = x_contacto.Relacionado;
                  x_entidad_contacto.ENTC_CodPadre = Item.ENTC_Codigo;
                  x_entidad_contacto.TIPE_CodPadre = Item.TIPE_Codigo;
                  x_entidad_contacto.RELA_Activo = true;
                  x_entidad_contacto.AUDI_UsrCrea = (String.IsNullOrEmpty(Item.AUDI_UsrCrea) ? Item.AUDI_UsrMod : Item.AUDI_UsrCrea);
                  x_entidad_contacto.AUDI_UsrMod = Item.AUDI_UsrCrea;
                  x_entidad_contacto.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted;
                  m_isCorrect = BL_EntidadRelacionados.Save(ref x_entidad_contacto);
               }
            }
            #endregion

            #region Depositos Almacenados
            // Deposito Temporal
            if (Item.ItemsDepTemporalEntidad != null && Item.ItemsDepTemporalEntidad.Count > 0)
            {
               for (int i = 0; i < Item.ItemsDepTemporalEntidad.Count; i++)
               {
                  Entidad_Relacionados x_entidad_deposito = new Entidad_Relacionados();
                  x_entidad_deposito = Item.ItemsDepTemporalEntidad[i];

                  x_entidad_deposito.ENTC_CodPadre = Item.ENTC_Codigo;
                  x_entidad_deposito.TIPE_CodPadre = Item.TIPE_Codigo;
                  x_entidad_deposito.AUDI_UsrMod = Item.AUDI_UsrMod;
                  x_entidad_deposito.RELA_Activo = true;
                  x_entidad_deposito.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified;
                  m_isCorrect = BL_EntidadRelacionados.UpdateDeposito(ref x_entidad_deposito);

               }
            }
            #endregion

            #region Servicios
            //guardamos los servicios por cliente
            if (Item.ListServicio != null && Item.ListServicio.Count > 0)
            {
               for (int i = 0; i < Item.ListServicio.Count; i++)
               {
                  Entidad_Servicio x_entidad_servicio = Item.ListServicio[i];
                  x_entidad_servicio.ENTC_Codigo = Item.ENTC_Codigo;
                  m_isCorrect = BL_EntidadServicio.Save(ref x_entidad_servicio);
               }
            }
            if (Item.ListServicioDeleted != null && Item.ListServicioDeleted.Count > 0)
            {
               for (int i = 0; i < Item.ListServicioDeleted.Count; i++)
               {
                  Entidad_Servicio x_entidad_servicio = Item.ListServicioDeleted[i];
                  x_entidad_servicio.ENTC_Codigo = Item.ENTC_Codigo;
                  m_isCorrect = BL_EntidadServicio.Save(ref x_entidad_servicio);
               }
            }
            #endregion
         }
         catch (Exception)
         {
            //Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction();
            m_isCorrect = false; throw;
         }
         finally
         {
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
         }
         return Item;
      }
      public Boolean Save(ref ObservableCollection<Entidad> Items)
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