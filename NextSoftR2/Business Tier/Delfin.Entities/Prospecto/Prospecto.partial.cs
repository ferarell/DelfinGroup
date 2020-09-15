using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;
using Infrastructure.Aspect.Attributes;

namespace Delfin.Entities
{
   public partial class Prospecto
   {
      #region [ Variables ]
      private Boolean m_pros_asignar;
      private Int32 m_pros_diasasignacion;

      private String m_entc_razonsocialcliente;
      private String m_entc_razonsocialagentecarga;
      private String m_entc_nomcompletoejecutivo;
      private String m_entc_nomcompletocustomer;
      private String m_entc_notas;
      private Boolean m_entc_prospecto;

      private String m_tipo_desccdt;
      private String m_cons_descrgm;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: PROS_Asignar.
      /// </summary>
      [DataMember]
      public Boolean PROS_Asignar
      {
         get { return m_pros_asignar; }
         set
         {

            if (m_pros_asignar != value)
            {
               m_pros_asignar = value;
               OnPropertyChanged("PROS_Asignar");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: PROS_DiasAsignacion.
      /// </summary>
      [DataMember]
      public Int32 PROS_DiasAsignacion
      {
         get { return m_pros_diasasignacion; }
         set
         {

            if (m_pros_diasasignacion != value)
            {
               m_pros_diasasignacion = value;
               OnPropertyChanged("PROS_DiasAsignacion");
            }
         }
      }


      /// <summary>
      /// Gets or sets el valor de: ENTC_RazonSocialCliente.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 3)]
      public String ENTC_RazonSocialCliente
      {
         get { return m_entc_razonsocialcliente; }
         set
         {
            if (m_entc_razonsocialcliente != value)
            {
               m_entc_razonsocialcliente = value;
               OnPropertyChanged("ENTC_RazonSocialCliente");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_RazonSocialAgenteCarga.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 5)]
      public String ENTC_RazonSocialAgenteCarga
      {
         get { return m_entc_razonsocialagentecarga; }
         set
         {
            if (m_entc_razonsocialagentecarga != value)
            {
               m_entc_razonsocialagentecarga = value;
               OnPropertyChanged("ENTC_RazonSocialAgenteCarga");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomCompletoEjecutivo.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 7)]
      public String ENTC_NomCompletoEjecutivo
      {
         get { return m_entc_nomcompletoejecutivo; }
         set
         {
            if (m_entc_nomcompletoejecutivo != value)
            {
               m_entc_nomcompletoejecutivo = value;
               OnPropertyChanged("ENTC_NomCompletoEjecutivo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomCompletoCustomer.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 9)]
      public String ENTC_NomCompletoCustomer
      {
         get { return m_entc_nomcompletocustomer; }
         set
         {
            if (m_entc_nomcompletocustomer != value)
            {
               m_entc_nomcompletocustomer = value;
               OnPropertyChanged("ENTC_NomCompletoCustomer");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: ENTC_Notas.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 20)]
      public String ENTC_Notas
      {
         get { return m_entc_notas; }
         set
         {
            if (m_entc_notas != value)
            {
               m_entc_notas = value;
               OnPropertyChanged("ENTC_Notas");
            }
         }
      }


      /// <summary>
      /// Gets or sets el valor de: ENTC_Prospecto.
      /// </summary>
      [DataMember]
      public Boolean ENTC_Prospecto
      {
         get { return m_entc_prospecto; }
         set
         {
            if (m_entc_prospecto != value)
            {
               m_entc_prospecto = value;
               OnPropertyChanged("ENTC_Prospecto");
            }
         }
      }



      /// <summary>
      /// Gets or sets el valor de: TIPO_DescCDT.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 16)]
      public String TIPO_DescCDT
      {
         get { return m_tipo_desccdt; }
         set
         {
            if (m_tipo_desccdt != value)
            {
               m_tipo_desccdt = value;
               OnPropertyChanged("TIPO_DescCDT");
            }

         }
      }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescRGM.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 19)]
      public String CONS_DescRGM
      {
         get { return m_cons_descrgm; }
         set
         {
            if (m_cons_descrgm != value)
            {
               m_cons_descrgm = value;
               OnPropertyChanged("CONS_DescRGM");
            }

         }
      }


      /// <summary>
      /// Gets or sets el valor de: GEST_Codigo.
      /// </summary>
      [DataMember]
      public Int32 GEST_Codigo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_TabGES.
      /// </summary>
      [DataMember]
      public String GEST_TabGES { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_CodGES.
      /// </summary>
      [DataMember]
      public String GEST_CodGES { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_DescGES.
      /// </summary>
      [DataMember]
      public String GEST_DescGES { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_Fecha.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> GEST_Fecha { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_Observacion.
      /// </summary>
      [DataMember]
      public String GEST_Observacion { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_TabGESProxima.
      /// </summary>
      [DataMember]
      public String GEST_TabGESProxima { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_CodGESProxima.
      /// </summary>
      [DataMember]
      public String GEST_CodGESProxima { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_DescGESProxima.
      /// </summary>
      [DataMember]
      public String GEST_DescGESProxima { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_FechaProximaGestion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> GEST_FechaProximaGestion { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_TiempoProximaGestion.
      /// </summary>
      [DataMember]
      public Nullable<TimeSpan> GEST_TiempoProximaGestion { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_CodResultado.
      /// </summary>
      [DataMember]
      public String GEST_CodResultado { get; set; }
      /// <summary>
      /// Gets or sets el valor de: GEST_DescResultado.
      /// </summary>
      [DataMember]
      public String GEST_DescResultado { get; set; }

      #endregion
   }
}
