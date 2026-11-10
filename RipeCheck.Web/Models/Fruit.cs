using System;

namespace RipeCheck.Web.Models
{
    public abstract class Fruit
    {
        private double _confidence;

        // Auto-property (get/set otomatis)
        public string Name { get; set; }
        public string Ripeness { get; set; }   // mentah, matang, busuk

        // Property dengan get/set manual + validasi
        public double Confidence
        {
            get { return _confidence; }
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Confidence harus 0 sampai 1");
                _confidence = value;
            }
        }

        protected Fruit(string name, string ripeness, double confidence)
        {
            Name = name;
            Ripeness = ripeness;
            Confidence = confidence;
        }

        // Abstract method: wajib di-override subclass
        public abstract int GetShelfLifeDays();

        public string Describe()
        {
            return $"{Name} | {Ripeness} ({Confidence * 100:0}%) | sisa umur simpan: {GetShelfLifeDays()} hari";
        }
    }
}