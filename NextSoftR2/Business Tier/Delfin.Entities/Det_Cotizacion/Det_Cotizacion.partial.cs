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
    public partial class Det_Cotizacion
    {
        #region [ Variables Adicionales ]
        private Decimal m_DCOT_Venta20;
        private Decimal m_DCOT_VentaSada20;
        private Decimal m_DCOT_Venta40;
        private Decimal m_DCOT_VentaSada40;
        private Decimal m_DCOT_VentaHBL;
        private Decimal m_DCOT_VentaSadaHBL;

        private Decimal m_DCOT_Costo20;
        private Decimal m_DCOT_CostoSada20;
        private Decimal m_DCOT_Costo40;
        private Decimal m_DCOT_CostoSada40;
        private Decimal m_DCOT_CostoHBL;
        private Decimal m_DCOT_CostoSadaHBL;

        private Boolean m_Trasanct = true;
        private string m_ENTC_RazonSocial;
        private String m_CONS_Desc_SPA;
        private String m_CONS_CodTipo;
        private String m_CONS_CodTipoTipo;
        private String m_TIPE_Descripcion;
        private String m_CONS_Desc_TRA;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Decimal DCOT_Venta20
        {
            get { return m_DCOT_Venta20; }
            set { m_DCOT_Venta20 = value; }
        }
        [DataMember]
        public Decimal DCOT_VentaSada20
        {
            get { return m_DCOT_VentaSada20; }
            set { m_DCOT_VentaSada20 = value; }
        }
        [DataMember]
        public Decimal DCOT_Venta40
        {
            get { return m_DCOT_Venta40; }
            set { m_DCOT_Venta40 = value; }
        }
        [DataMember]
        public Decimal DCOT_VentaSada40
        {
            get { return m_DCOT_VentaSada40; }
            set { m_DCOT_VentaSada40 = value; }
        }
        [DataMember]
        public Decimal DCOT_VentaHBL
        {
            get { return m_DCOT_VentaHBL; }
            set { m_DCOT_VentaHBL = value; }
        }
        [DataMember]
        public Decimal DCOT_VentaSadaHBL
        {
            get { return m_DCOT_VentaSadaHBL; }
            set { m_DCOT_VentaSadaHBL = value; }
        }

        [DataMember]
        public Decimal DCOT_Costo20
        {
           get { return m_DCOT_Costo20; }
           set { m_DCOT_Costo20 = value; }
        }
        [DataMember]
        public Decimal DCOT_CostoSada20
        {
           get { return m_DCOT_CostoSada20; }
           set { m_DCOT_CostoSada20 = value; }
        }
        [DataMember]
        public Decimal DCOT_Costo40
        {
           get { return m_DCOT_Costo40; }
           set { m_DCOT_Costo40 = value; }
        }
        [DataMember]
        public Decimal DCOT_CostoSada40
        {
           get { return m_DCOT_CostoSada40; }
           set { m_DCOT_CostoSada40 = value; }
        }
        [DataMember]
        public Decimal DCOT_CostoHBL
        {
           get { return m_DCOT_CostoHBL; }
           set { m_DCOT_CostoHBL = value; }
        }
        [DataMember]
        public Decimal DCOT_CostoSadaHBL
        {
           get { return m_DCOT_CostoSadaHBL; }
           set { m_DCOT_CostoSadaHBL = value; }
        }

        [DataMember]
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
        [DataMember]
        public string ENTC_RazonSocial
        {
            get { return m_ENTC_RazonSocial; }
            set { m_ENTC_RazonSocial = value; }
        }
        [DataMember]
        public String CONS_Desc_SPA
        {
            get { return m_CONS_Desc_SPA; }
            set { m_CONS_Desc_SPA = value; }
        }
        [DataMember]
        public String CONS_CodTipo
        {
            get { return m_CONS_CodTipo; }
            set { m_CONS_CodTipo = value; }
        }
        [DataMember]
        public String CONS_CodTipoTipo
        {
            get { return m_CONS_CodTipoTipo; }
            set { m_CONS_CodTipoTipo = value; }
        }
       
        [DataMember]
        public String TIPE_Descripcion
        {
            get { return m_TIPE_Descripcion; }
            set { m_TIPE_Descripcion = value; }
        }
        [DataMember]
        public Int32 DCOT_Fila { get; set; }
        [DataMember]
        public String CONS_Desc_TRA
        {
            get { return m_CONS_Desc_TRA; }
            set { m_CONS_Desc_TRA = value; }
        }
        [DataMember]
        public String ORIGEN { get; set; }
        [DataMember]
        public String DESTINO { get; set; }

        [DataMember]
        public String CCOT_NumDoc { get; set; }
        #endregion
    }
}
