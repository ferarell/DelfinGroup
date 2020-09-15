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
    public partial class Cab_Operacion
    {
        #region [ Variables Adicionales ]

        private String m_Cliente;
        private String m_CONS_CodEstadosTR;
        public String m_monedastr;
        public decimal m_cope_valorcosto;
        public decimal m_cope_valorvta;
        public decimal m_cope_profit;
        private ObservableCollection<Det_Operacion> m_itemsDet_Operacion;
        private ObservableCollection<Det_Operacion> m_itemsDet_Operacion_eliminados;
        private ObservableCollection<Det_Operacion_Servicio> m_itemsDet_Operacion_Servicio;
        private ObservableCollection<Det_Operacion_Servicio> m_itemsDet_Operacion_Servicio_Eliminados;

        #endregion

        #region [ Propiedades Adicionales ]

        [DataMember]
        public String Cliente
        {
            get { return m_Cliente; }
            set { m_Cliente = value; }
        }

        [DataMember]
        public String CONS_CodEstadoSTR
        {
            get { return m_CONS_CodEstadosTR; }
            set { m_CONS_CodEstadosTR = value; }
        }

        [DataMember]
        public String MonedaSTR
        {
           get { return m_monedastr; }
           set { m_monedastr = value; }
        }
        [DataMember]
        public ObservableCollection<Det_Operacion> ItemsDet_Operacion
        {
            get { return m_itemsDet_Operacion; }
            set { m_itemsDet_Operacion = value; }
        }

        [DataMember]
        public ObservableCollection<Det_Operacion_Servicio> ItemsDet_Operacion_Servicio_Eliminados
        {
           get { return m_itemsDet_Operacion_Servicio_Eliminados; }
           set { m_itemsDet_Operacion_Servicio_Eliminados = value; }
        }

        [DataMember]
        public ObservableCollection<Det_Operacion_Servicio> ItemsDet_Operacion_Servicio
        {
            get { return m_itemsDet_Operacion_Servicio; }
            set { m_itemsDet_Operacion_Servicio = value; }
        }


        [DataMember]
        public ObservableCollection<Det_Operacion> ItemsDet_Operacion_Eliminados
        {
           get { return m_itemsDet_Operacion_eliminados; }
           set { m_itemsDet_Operacion_eliminados = value; }
        }

       [DataMember]
        public Decimal COPE_ValorCosto
        {
            get { return m_cope_valorcosto; }
           set { m_cope_valorcosto = value; }
        }
       [DataMember]
        public Decimal COPE_ValorVenta
        {
           get { return m_cope_valorvta; }
           set { m_cope_valorvta = value; }
        }
       [DataMember]
       public Decimal COPE_Profit
        {
            get { return m_cope_profit; }
           set { m_cope_profit = value; }
        }
          
          
        [DataMember]
        public String Transportista { set; get; }

        [DataMember]
        public String Agente { set; get; }

        [DataMember]
        public String CCOT_NumDoc { get; set; }

        [DataMember]
        public String COPE_Nave { get; set; }

        [DataMember]
        public String COPE_Viaje { get; set; }

        [DataMember]
        public String COPE_MBL { get; set; }

        [DataMember]
        public DateTime? COPE_FechaArribo { get; set; }

        [DataMember]
        public Int16? COPE_CantidadDias { get; set; }

        [DataMember]
        public Decimal? COPE_Kilos { get; set; }

        [DataMember]
        public Decimal? COPE_Volumen { get; set; }

        [DataMember]
        public Boolean COPE_PrecioSada { get; set; }

        [DataMember]
        public String Situacion_fact_clie { get; set; }

        [DataMember]
        public String Situacion_fact_Prov { get; set; }

        [DataMember]
        public DateTime? DDOV_FecEmbarque { get; set; }

        [DataMember]
        public DateTime? NVIA_FecETA_IMPO_ETD_EXPO { get; set; }

    #endregion
	}
}
