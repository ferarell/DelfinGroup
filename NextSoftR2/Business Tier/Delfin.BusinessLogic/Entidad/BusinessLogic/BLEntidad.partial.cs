using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;
using Microsoft.Practices.Unity;


namespace Delfin.BusinessLogic
{
   public partial class BLEntidad
   {
       /// <summary>
       /// CRISTHIAN JOSE APAZA ARHUATA
       /// ENTIDAD RELACIONADOS
       /// </summary>
       //[Dependency]
       //public IBLEntidad_Relacionados BL_EntidadRelacionados { get; set; }
                                      
      #region [ Consultas ]
      //public ObservableCollection<Entidad> GetAllByNomCompleto(String ENTC_NomCompleto)
      //{
      //   try
      //   {
      //      return SelectAllByNomCompleto(ENTC_NomCompleto);
      //   }
      //   catch (Exception)
      //   { throw; }
      //}

      public DataTable GetTodosEntidadByTIPE_Codigo(Nullable<Int16> x_TIPE_Codigo)
      {
         try
         {
            return SelectTodosEntidadByTIPE_Codigo(x_TIPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Entidad GetEntidadOnePorRuc(String x_ENTC_DocIden, Nullable<Int16> x_TIPE_Codigo)
      {
         try
         {
            return SelectOnePorRuc(x_ENTC_DocIden, x_TIPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Entidad> GetAllByTipoEntidadAndText(Int16 TIPE_CODIGO, string Text, Boolean Activo, String ENTC_DOCIDEN)
      {
         try
         {
            return SelectAllByTipoEntidadAndText(TIPE_CODIGO, Text, Activo, ENTC_DOCIDEN);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Entidad> GetAllEntidadByNVIA_Codigo(Int32 NVIA_codigo, Int32 TIPO_correo)
      {
          try
          {
              return SelectAllEntidadByNVIA_Codigo(NVIA_codigo, TIPO_correo);
          }
          catch (Exception)
          { throw; }
      }

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA
      /// ENTIDAD DEPOSITO TEMPORAL
      /// </summary>      
      public ObservableCollection<Entidad_Relacionados> GetAllDepositoTemporalByCliente(Int32 ENTC_Codigo)
      {
          try
          {
              return BL_EntidadRelacionados.GetAllDepositoTemporalByCliente(ENTC_Codigo);
          }
          catch (Exception)
          { throw; }
      }
      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA
      /// ENTIDAD RELACIONADAS A UN CLIENTE (CONTACTOS)
      /// </summary>  
      public ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByCliente(Int32 ENTC_Codigo, String RELA_Tipos)
      {
          try
          {
              return BL_EntidadRelacionados.GetAllEntidadRelacionadosByCliente(ENTC_Codigo,RELA_Tipos);
          }
          catch (Exception)
          { throw; }
      }

      public ObservableCollection<Entidad> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean GetLimiteCredito(Int16 EMPR_Codigo, Int32 ENTC_Codigo, ref Decimal Monto, ref Int16 DiasDuracion)
      {
         try
         {
            return SelectLimiteCredito(EMPR_Codigo, ENTC_Codigo, ref Monto, ref DiasDuracion);
         }
         catch (Exception)
         { throw; }
      }


      #endregion

      #region [ Metodos ]
      public Entidad GetOneValidarDocIden(Int32 ENTC_Codigo, String TIPO_TabTDI, String TIPO_CodTDI, String ENTC_DocIden)
      {
         try
         {
            return ValidarDocIden(ENTC_Codigo, TIPO_TabTDI, TIPO_CodTDI, ENTC_DocIden);
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
