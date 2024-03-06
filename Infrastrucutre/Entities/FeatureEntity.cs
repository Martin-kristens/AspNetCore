namespace Infrastrucutre.Entities;

public class FeatureEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public ICollection<FeatureBoxEntity> FeaturesBoxes { get; set; } = [];
}
