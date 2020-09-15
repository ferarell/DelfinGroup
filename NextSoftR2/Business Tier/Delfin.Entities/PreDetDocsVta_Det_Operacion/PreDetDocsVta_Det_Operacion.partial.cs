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
	public partial class PreDetDocsVta_Det_Operacion
	{
        #region [ Variables Adicionales ]
        private bool m_Agregar;
        private Boolean m_Trasanct = true;
        private Boolean m_Tarjas;
        private Decimal m_importe;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Boolean Tarjas
        {
            get { return m_Tarjas; }
            set { m_Tarjas = value; }
        }
        [DataMember]
	    public Decimal DOPE_Venta { set; get; }

        [DataMember]
        public String CTAR_Tipo { set; get; }

        [DataMember]
        public bool Agregar
        {
            get { return m_Agregar; }
            set { m_Agregar = value; }
        }
        [DataMember]
        public Decimal Importe
        {
           get { return m_importe; }
           set { m_importe = value; }
        }
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
        [DataMember]
        public Int32 SERV_Codigo { set; get; }

        [DataMember]
        public Int32 DTAJ_Item { set; get; }
        
        [DataMember]
        public Int32 TARJ_Codigo { set; get; }

        [DataMember]
        public Decimal DOPE_PrecioTotVta { set; get; }

        [DataMember]
        public Decimal ENTC_ValTarja { set; get; }

        [DataMember]
        public Decimal ENTC_ValRebate { set; get; }

        
        #endregion
	}
}
