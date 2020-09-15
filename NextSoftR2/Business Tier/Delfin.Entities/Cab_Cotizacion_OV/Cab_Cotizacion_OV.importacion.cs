using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Infrastructure.Aspect.Attributes;

namespace Delfin.Entities
{
    /// <summary>
    /// Atributos para la importacion del Excel sobre el Costo Flete Hapag
    /// </summary>
    public partial class Cab_Cotizacion_OV
    {
        #region [ Variables ]

        String m_mbl;
        String m_contenedor;
        String m_puertoorigen;
        String m_nave;
        String m_nroviaje;
        Nullable<DateTime> m_feceta;
        Decimal m_flete;

        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: MBL.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 1)]
        public String MBL
        {
            get { if (m_mbl != null && m_mbl.Length > 50) { m_mbl = m_mbl.Substring(0, 50); } return m_mbl; }
            set { m_mbl = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: Contenedor.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 2)]
        public String Contenedor
        {
            get { if (m_contenedor != null && m_contenedor.Length > 20) { m_contenedor.Substring(0, 20); } return m_contenedor; }
            set { m_contenedor = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: PuertoOrigen.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 3)]
        public String PuertoOrigen
        {
            get { if (m_puertoorigen != null && m_puertoorigen.Length > 7) { m_puertoorigen.Substring(0, 7); } return m_puertoorigen; }
            set { m_puertoorigen = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: Nave.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 4)]
        public String Nave
        {
            get { if (m_nave != null && m_nave.Length > 50) { m_nave.Substring(0, 50); } return m_nave; }
            set { m_nave = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: NroViaje.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 5)]
        public String NroViaje
        {
            get { if (m_nroviaje != null && m_nroviaje.Length > 50) { m_nroviaje.Substring(0, 50); } return m_nroviaje; }
            set { m_nroviaje = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: FecETA.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 6)]
        public Nullable<DateTime> FecETA
        {
            get { return m_feceta; }
            set { m_feceta = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: Flete.
        /// </summary>
        [DataMember]
        [TableValueParameter(Export = true, Orden = 7)]
        public Decimal Flete
        {
            get { return m_flete; }
            set { m_flete = value; }
        }

        #endregion
    }
}