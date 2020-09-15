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
	public partial class CabPerfilAsientos
   {

      #region Propiedades

      [DataMember]
      public ObservableCollection<DetPerfilAsientos> ListDetPerfilAsientos { get; set; }

      [DataMember]
      public ObservableCollection<DetPerfilAsientos> ListDetPerfilAsientosEliminados { get; set; }

      #endregion
   }
}
