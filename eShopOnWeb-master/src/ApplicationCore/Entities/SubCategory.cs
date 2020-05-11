using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class SubCategory : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDelete { get; set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public SubCategory(string title, string summary, string description, bool status, bool isDelete, int categoryId)
        {
            Title = title;
            Summary = summary;
            Description = description;
            Status = status;
            IsDelete = isDelete;
            CategoryId = categoryId;
        }
    }
}
