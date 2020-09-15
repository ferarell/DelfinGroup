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
	public partial class Det_CNTR
   {
      #region [ Variables ]
      
      #endregion

      #region [ Propiedades ]
      private String m_pack_desc;

      public String PACK_Desc
      {
         get { return m_pack_desc; }
         set {
            if (m_pack_desc != value)
            { m_pack_desc = value; }
         }
      }
      
      #endregion
   }
}
