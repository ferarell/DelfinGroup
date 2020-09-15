using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLNaveViaje
   {
      #region [ Consultas ]
      public ObservableCollection<NaveViaje> GetAllByViajeTransportista(String NVIA_NroViaje, Nullable<Int32> ENTC_CodTransportista, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> NVIA_FecETA)
      {
         try
         {
            return SelectAllByViajeTransportista(NVIA_NroViaje, ENTC_CodTransportista, CONS_TabVIA, CONS_CodVIA, NVIA_FecETA);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<NaveViaje> GetAllByFiltros(Boolean AcceptNulls, String NVIA_Estado, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVia, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo, Nullable<DateTime> NVIA_FecCreacion, String NVIA_NroViaje)
      {
         try
         {
            return SelectAllByFiltros(AcceptNulls, NVIA_Estado, CONS_TabRGM, CONS_CodRGM, CONS_TabVia, CONS_CodVia, ENTC_CodTransportista, NAVE_Codigo, NVIA_FecCreacion, NVIA_NroViaje);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilters(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Cab_Cotizacion_OV> GetAllCab_OV_CabByNVIA_Codigo(Int32 NVIA_Codigo)//Int16 EMPR_Codigo, Int16 SUCR_Codigo,
      {
         try
         {
            return SelectAllCab_OV_CabByNVIA_Codigo(NVIA_Codigo);//EMPR_Codigo, SUCR_Codigo, 
         }
         catch (Exception ex)
         { throw ex; }
      }

      public System.Data.DataTable ReportByFilters(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETAIni, Nullable<DateTime> NVIA_FecETAFin, Nullable<DateTime> NVIA_FecZarpeIni, Nullable<DateTime> NVIA_FecZarpeFin, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo)
      {
         try
         {
            return SelectReportByFilters(CONS_TabRGM, CONS_CodRGM, NVIA_FecETAIni, NVIA_FecETAFin, NVIA_FecZarpeIni, NVIA_FecZarpeFin, ENTC_CodTransportista, NAVE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public System.Data.DataTable MBLsByNaveViaje(Nullable<Int32> NVIA_Codigo, Int32 TIPO_Direccionamiento, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            return SelectMBLByFilters(NVIA_Codigo, TIPO_Direccionamiento, CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public System.Data.DataTable CargaTarjadaByNaveViaje(Nullable<Int32> NVIA_Codigo, String TIPO_Embarque, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            return SelectCargaTarjadaByNaveViaje(NVIA_Codigo, TIPO_Embarque, CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public System.Data.DataTable EmisionHBLByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero)
      {
         try
         {
            return SelectEmisionHBL(NVIA_Codigo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable AvisosByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero, String CCOT_NumDoc, Nullable<Int32> ENTC_CodCliente)
      {
         try
         {
            return SelectAvisos(NVIA_Codigo, CCOT_Numero, CCOT_NumDoc, ENTC_CodCliente);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataSet GetEmisionAduana(Int32 NVIA_Codigo, string Formato)
      {
         try
         {
            return SelectEmisionAduana(NVIA_Codigo, Formato);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet GetEmisionAduanaTeledespacho(Int32 NVIA_Codigo)
      {
         try
         {
            return SelectEmisionAduanaTeledespacho(NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByControlTransmisiones(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETA_ETDIni, Nullable<DateTime> NVIA_FecETA_ETDFin)
      {
         try
         {
            return SelectControlTransmisiones(CONS_TabRGM, CONS_CodRGM, NVIA_FecETA_ETDIni, NVIA_FecETA_ETDFin);
         }
         catch (Exception)
         { throw; }
      }

      /// <summary>
      /// Verifica si existe una nave viaje con el mismo transportista, regimen, nave, nroViaje, Puerto
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public String CheckAllNaveViaje(NaveViaje Item)
      {
         try
         {
            return VerifyExistenceNaveViaje(Item);
         }
         catch (Exception)
         { throw; }
      }
      public String OVsByNVIA(Nullable<Int32> x_NVIA_Codigo)
      {
         try
         {
            return OrdenesVentaByNVIA(x_NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean UpdateTransportistaOVs(Nullable<Int32> x_NVIA_Codigo, Nullable<Int32> x_ENTC_CodTransportista)
      {
         try
         {
            return UpdateTransportistaOVsByNVIA(x_NVIA_Codigo, x_ENTC_CodTransportista);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public bool SaveAprobarStatment(Int32 x_NVIA_Codigo, String x_AUDI_Usuario, ref String x_NVIA_MensajeError)
      {
         try
         {
            return UpdateAprobarStatment(x_NVIA_Codigo, x_AUDI_Usuario, ref x_NVIA_MensajeError);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean AbrirStatment(Nullable<Int32> NVIA_Codigo, ref String x_Mensaje)
      {
         try
         {
            return AbrirStatment_Update(NVIA_Codigo, ref x_Mensaje);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean EmiteStatment(Nullable<Int32> NVIA_Codigo, String NVIA_UsrEmiteStatment)
      {
         try
         {
            return EmitirStatment_Update(NVIA_Codigo, NVIA_UsrEmiteStatment);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean Save(ref ObservableCollection<NaveViaje> Items, Entities.NaveViaje.TInterfazNaveViaje x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case NaveViaje.TInterfazNaveViaje.Normal:
                  return Save(ref Items);
                  break;
               case NaveViaje.TInterfazNaveViaje.GenerarAsientos:
                  return SaveGAsientos(ref Items);
                  break;
               default:
                  break;
            }
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
         return false;
      }

      private Boolean SaveGAsientos(ref ObservableCollection<NaveViaje> Items)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            foreach (NaveViaje iNaveViaje in Items)
            {
               //NaveViaje x_NaveViaje = SelectOne(iNaveViaje.NVIA_Codigo);
               GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoSTATEMENT);

               genAsientos.ItemNaveViaje = iNaveViaje;
               
               //genAsientos.SUCR_Codigo = iNaveViaje.SUCR_Codigo;
               //genAsientos.CABA_Ano = x_NaveViaje.CABA_Ano;
               //genAsientos.CABA_Mes = x_NaveViaje.CABA_Mes;
               //genAsientos.TIPO_TabREG = x_NaveViaje.TIPO_TabREG;
               //genAsientos.TIPO_CodReg = x_NaveViaje.TIPO_CodREG;
               //genAsientos.CABA_NroVoucher = x_NaveViaje.CABA_NroVoucher;

               String x_usuario = String.IsNullOrEmpty(iNaveViaje.AUDI_UsrMod) ? iNaveViaje.AUDI_UsrCrea : iNaveViaje.AUDI_UsrMod;

               m_isCorrect = genAsientos.GenerarAsientoBD(x_usuario);
               //m_isCorrect = genAsientos.GenerarAsiento(x_NaveViaje.AUDI_UsrCrea, iNaveViaje.SUCR_Codigo);
               //if (m_isCorrect)
               //{ genAsientos.ActualizarNaveViaje(x_NaveViaje.AUDI_UsrCrea); }
            }

            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
         return false;
      }


      
      #endregion
   }
}
