//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Школьный_портал
{
    using System;
    using System.Collections.Generic;
    
    public partial class Literature_grades
    {
        public int Id { get; set; }
        public int id_Day { get; set; }
        public Nullable<int> id_Teacher { get; set; }
        public Nullable<int> id_Student { get; set; }
        public string Grades { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        public virtual Students Students { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
