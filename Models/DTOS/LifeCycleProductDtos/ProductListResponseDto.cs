namespace homework.Models.DTOS.LifeCycleProductDtos;
public class ProductListResponseDto
{
    public List<ProductDto>? Products { get; set; }
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}