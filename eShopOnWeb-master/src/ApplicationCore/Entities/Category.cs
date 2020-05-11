using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDelete { get; set; }
        public Category(string title, string summary, string description, bool status, bool isDelete)
        {
            Title = title;
            Summary = summary;
            Description = description;
            Status = status;
            IsDelete = isDelete;
        }
    }
}
