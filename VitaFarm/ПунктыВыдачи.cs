//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VitaFarm
{
    using System;
    using System.Collections.Generic;
    
    public partial class ПунктыВыдачи
    {
        public ПунктыВыдачи()
        {
            this.Талоны = new HashSet<Талоны>();
        }
    
        public int UID { get; set; }
        public string Название { get; set; }
        public string Город { get; set; }
        public string Улица { get; set; }
        public string Здание { get; set; }
    
        public virtual ICollection<Талоны> Талоны { get; set; }
    }
}
