namespace RipeCheck.Web.Models
{
    public class Tomato : Fruit
    {
        public Tomato(string ripeness, double confidence)
            : base("Tomat", ripeness, confidence) { }

        public override int GetShelfLifeDays()
        {
            switch (Ripeness)
            {
                case "mentah": return 7;
                case "matang": return 4;
                default: return 0;
            }
        }
    }
}