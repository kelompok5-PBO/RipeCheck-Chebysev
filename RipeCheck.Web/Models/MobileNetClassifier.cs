namespace RipeCheck.Web.Models
{
    public class MobileNetClassifier : IClassifier
    {
        public string[] Labels { get; } = { "mentah", "matang", "busuk" };

        public Fruit Classify(string imagePath)
        {
            // Placeholder: nanti diganti pemanggilan model ML asli
            return new Banana("matang", 0.92);
        }
    }
}