public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }          // цена
    public int TotalCount { get; set; }  // количество единиц данного товара

    public int CompanyId { get; set; }
    public Company? Company { get; set; }
}