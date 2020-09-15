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
	public partial class Entidad_Servicio
	{
        #region [ Variables Adicionales ]
        private Int32 m_ESER_Cantidad;
        private String m_TIPO_TabMnd;
        private String m_TIPO_CodMnd;
        private String m_CONS_TabBas;
        private String m_CONS_CodBas;
        private String m_TIPO_CodTipo;
        private String m_CONS_CodTipo;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public String CONS_CodBas
        {
            get { return m_CONS_CodBas; }
            set { 
               
               if (m_CONS_CodBas != value)
               {
                  m_CONS_CodBas = value;
                  OnPropertyChanged("CONS_CodBas");
               }

            }
        }
        [DataMember]
        public string CONS_TabBas
        {
            get { return m_CONS_TabBas; }
            set { 
               
               if (m_CONS_TabBas != value)
               {
                  m_CONS_TabBas = value;
                  OnPropertyChanged("CONS_TabBas");
               }
            }
        }
        [DataMember]
        public String TIPO_CodMnd
        {
            get { return m_TIPO_CodMnd; }
            set { 
               
               if (m_TIPO_CodMnd != value)
               {
                  m_TIPO_CodMnd = value;
                  OnPropertyChanged("TIPO_CodMnd");
               }
            }
        }
        [DataMember]
        public String TIPO_TabMnd
        {
            get { return m_TIPO_TabMnd; }
            set { 
               if (m_TIPO_TabMnd != value)
               {
                  m_TIPO_TabMnd = value;
                  OnPropertyChanged("TIPO_TabMnd");
               }
            }
        }
        [DataMember]
        public Int32 ESER_Cantidad
        {
            get { return m_ESER_Cantidad; }
            set { 
               
               if (m_ESER_Cantidad != value)
               {
                  m_ESER_Cantidad = value;
                  OnPropertyChanged("ESER_Cantidad");
               }
            }
        }
        //[DataMember]
        //public String CONS_CodTipo
        //{
        //    get { return m_CONS_CodTipo; }
        //    set { m_CONS_CodTipo = value; }
        //}
        //[DataMember]
        //public String TIPO_CodTipo
        //{
        //    get { return m_TIPO_CodTipo; }
        //    set { m_TIPO_CodTipo = value; }
        //}
        [DataMember]
        public String CONS_TabVIA { get; set; }
        [DataMember]
        public String CONS_CodVIA { get; set; }
        [DataMember]
        public String CONS_TabRGM { get; set; }
        [DataMember]
        public String CONS_CodRGM { get; set; }
        [DataMember]
        public String CONS_TabLNG { get; set; }
        [DataMember]
        public String CONS_CodLNG { get; set; }

        [DataMember]
        public String SERV_Nombre { get; set; }
        [DataMember]
        public String TIPO_DescMND { get; set; }
        [DataMember]
        public String CONS_DescBAS { get; set; }
        [DataMember]
        public String CONS_DescVIA { get; set; }
        [DataMember]
        public String CONS_DescLNG { get; set; } 
        [DataMember]
        public String CONS_DescRGM { get; set; }
        
        #endregion
	}
}
