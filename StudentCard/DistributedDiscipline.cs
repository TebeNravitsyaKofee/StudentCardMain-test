//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentCard
{
    using System;
    using System.Collections.Generic;
    
    public partial class DistributedDiscipline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DistributedDiscipline()
        {
            this.Load = new HashSet<Load>();
        }
    
        public int ID_distrubuted_dis { get; set; }
        public Nullable<int> ID_teacher { get; set; }
        public Nullable<int> ID_discipline { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Teacher Teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Load> Load { get; set; }
    }
}
