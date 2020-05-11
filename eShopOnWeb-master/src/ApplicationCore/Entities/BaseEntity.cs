using System;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    // This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    // Using non-generic integer types for simplicity and to ease caching logic
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime CreateDate { get; protected set; }
        public virtual DateTime UpdateDate { get; protected set; }
        public virtual string CreateBy { get; protected set; }
        public virtual string UpdateBy { get; protected set; }
    }
}
