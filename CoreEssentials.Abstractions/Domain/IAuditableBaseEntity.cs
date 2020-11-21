using System;

namespace CoreEssentials.Abstractions.Domain
{
    internal interface IAuditableBaseEntity : IBaseEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
    }
}