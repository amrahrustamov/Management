using Management.Core.Entities.Base;

namespace Management.Core.Entities;

public class Department:BaseEntity,IAuditable
{
    
    public string Name { get; set; }
    public DateTime CreatedDate { get ; set; }
    public DateTime LastModifiedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public bool IsDeleted { get; set; }
}
