namespace RipeCheck.Web.Models
{
    public class Banana : Fruit
    {
        public Banana(string ripeness, double confidence)
            : base("Pisang", ripeness, confidence) { }

        public override int GetShelfLifeDays()
        {
            switch (Ripeness)
            {
                case "mentah": return 5;
                case "matang": return 2;
                default: return 0;
            }
        }
    }
}