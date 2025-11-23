using EcommerceDev.Core.Entities;

public class ProductCategory : BaseEntity
{
    public ProductCategory(string title, string subCategory) : base()
    {
        Title = title;
        SubCategory = subCategory;
    }

    public string Title { get; set; }
    public string SubCategory { get; set; }
}
