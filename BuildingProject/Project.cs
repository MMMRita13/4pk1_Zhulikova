//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildingProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public decimal ID_Project { get; set; }
        public string Nname { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal Supervisor { get; set; }
        public decimal Materials { get; set; }
    
        public virtual Materials Materials1 { get; set; }
        public virtual Supervisors Supervisors { get; set; }
    }
}
