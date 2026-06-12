namespace MathEx_Blazor.Data;

public class Card
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Tags { get; set; }
}