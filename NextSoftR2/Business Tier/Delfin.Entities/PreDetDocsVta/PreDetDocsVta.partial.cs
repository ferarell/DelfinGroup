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
	public partial class PreDetDocsVta
	{
        #region [ Variables Adicionales ]
        private String m_Descripcion;
        private String m_Moneda;
        private Decimal m_Importe;
        private bool m_Agregar;
        private Boolean m_Trasanct = true;
        private Boolean m_Tarjas;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Boolean Tarjas
        {
            get { return m_Tarjas; }
            set { m_Tarjas = value; }
        }
        public String Servicio
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }
        public String Moneda
        {
           get { return m_Moneda; }
           set { m_Moneda = value; }
        }
        public Decimal Importe
        {
           get { return m_Importe; }
           set { m_Importe = value; }
        }
        [DataMember]
        public bool Agregar
        {
            get { return m_Agregar; }
            set { m_Agregar = value; }
        }
        [DataMember]
        public String CTAR_Tipo { set; get; }

        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }

        [DataMember]
	    public Decimal DDOV_ValorTotal { set; get; }


        [DataMember]
        public Decimal DDOV_ValorTotalD { set; get; }

        [DataMember]
        public Int32 SOPE_Item { set; get; }

        [DataMember]
        public Int32 DTAJ_Item { set; get; }

	    #endregion
	}
}
