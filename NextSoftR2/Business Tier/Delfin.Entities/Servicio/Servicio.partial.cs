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

namespace Delfin.Entities
{
   public partial class Servicio
   {
      private String m_viaRegimenServicio;
      /// <summary>
      /// Gets or sets el valor de: SERV_CodigoStr.
      /// </summary>
      [DataMember]
      public String SERV_CodigoStr
      {
         get { return SERV_Codigo.ToString(); }
         set
         {
            Int32 _serv_codigo;
            if (!String.IsNullOrEmpty(value) && Int32.TryParse(value, out _serv_codigo))
            { SERV_Codigo = _serv_codigo; }
            else
            { SERV_Codigo = -1; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescRGM.
      /// </summary>
      [DataMember]
      public String CONS_DescRGM { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescVIA.
      /// </summary>
      [DataMember]
      public String CONS_DescVIA { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescLNG.
      /// </summary>
      [DataMember]
      public String CONS_DescLNG { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescBAS.
      /// </summary>
      [DataMember]
      public String CONS_DescBAS { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_DescUNT.
      /// </summary>
      [DataMember]
      public String TIPO_DescUNT { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_DescMND.
      /// </summary>
      [DataMember]
      public String TIPO_DescMND { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_DescDET.
      /// </summary>
      [DataMember]
      public String TIPO_DescDET { get; set; }

      /// <summary>
      /// Gets or sets el valor de: VIA - SERVICIO - NOMBRE_SPA.
      /// </summary>
      [DataMember]
      public String ViaRegimenServicio
      {
         get
         {
            m_viaRegimenServicio = "";
            if (!String.IsNullOrEmpty(SERV_Nombre_SPA))
            { m_viaRegimenServicio += SERV_Nombre_SPA + " - "; }
            if (!String.IsNullOrEmpty(CONS_DescVIA))
            { m_viaRegimenServicio += CONS_DescVIA + " - "; }
            if (!String.IsNullOrEmpty(CONS_DescRGM))
            { m_viaRegimenServicio += CONS_DescRGM; }

            return m_viaRegimenServicio;
         }
         set
         {
            if (m_viaRegimenServicio != value)
            {
               m_viaRegimenServicio = value;
               OnPropertyChanged("ViaRegimenServicio");
            }
         }
      }

      [DataMember]
      public String SERV_MessageError { get; set; }
      
      [DataMember]
      public String CENT_Desc { get; set; }

      public String Documentos { get; set; }

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA
      /// LISTA DE DETALLES DE SERVICIO
      /// </summary>

      [DataMember]
      public ObservableCollection<ServiciosDocumentos> ServiciosDocumentos { get; set; }

      [DataMember]
      public ObservableCollection<ServiciosDocumentos> ServiciosDocumentosDelete { get; set; }

        [DataMember]
        public ObservableCollection<ServiciosLineaNegocio> ServiciosLineaNegocio { get; set; }

        [DataMember]
        public ObservableCollection<ServiciosLineaNegocio> ServiciosLineaNegocioDelete { get; set; }



        //[DataMember]
        //public ObservableCollection<ServiciosRegimenVia> ServiciosRegimenVia { get; set; }

        //[DataMember]
        //public ObservableCollection<ServiciosRegimenVia> ServiciosRegimenViaDelete { get; set; }



    }
}
