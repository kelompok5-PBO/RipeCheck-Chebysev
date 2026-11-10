namespace RipeCheck.Web.Models
{
    public interface IClassifier
    {
        string[] Labels { get; }
        Fruit Classify(string imagePath);
    }
}