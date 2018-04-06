namespace DietHolder2ClientWPF.Interfaces
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        decimal ProductPrice { get; set; }
        double ProductCarboValue { get; set; }
        double ProductProteinValue { get; set; }
        double ProductFatValue { get; set; }
    }
}
