namespace Management.Core.Entities.Base;

public interface IAuditable
{
    DateTime CreatedDate { get; set; }
    DateTime LastModifiedDate { get; set; }
    DateTime DeletedDate { get; set; }
    bool IsDeleted { get; set; }
}
