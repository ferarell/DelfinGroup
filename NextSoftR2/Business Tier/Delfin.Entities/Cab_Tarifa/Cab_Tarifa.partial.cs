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
	public partial class Cab_Tarifa
	{
        #region [ Variables Adicionales ]
        private ObservableCollection<Det_Tarifa> m_itemsDet_Tarifa;
        private ObservableCollection<Det_Tarifa_Servicio> m_itemsDet_Tarifa_Servicio;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public ObservableCollection<Det_Tarifa> ItemsDet_Tarifa
        {
            get { return m_itemsDet_Tarifa; }
            set { m_itemsDet_Tarifa = value; }
        }
        [DataMember]
        public ObservableCollection<Det_Tarifa_Servicio> ItemsDet_Tarifa_Servicio
        {
            get { return m_itemsDet_Tarifa_Servicio; }
            set { m_itemsDet_Tarifa_Servicio = value; }
        }

        [DataMember]
        public String LNaviera { get; set; }
        [DataMember]
        public String AgMaritimo { get; set; }
        [DataMember]
        public String DepTemporal { get; set; }
        [DataMember]
        public String DepVacio { get; set; }
        [DataMember]
        public String AgAduanera { get; set; }
        [DataMember]
        public String Transporte { get; set; }
        #endregion
    }
}
