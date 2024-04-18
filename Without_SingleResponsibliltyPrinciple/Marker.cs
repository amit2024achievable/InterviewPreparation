using System.Diagnostics;

namespace Without_SingleResponsibliltyPrinciple
{
    // Marker Specifications
    public class Marker
    {
        public string? _markerName;
        public string? _color;
        public string? _brand;
        public double _baseprice;
        public DateTime? _todaysDate  = DateTime.Now;
        public int _quatity;


        public Marker(string? markerName, string? color, string? brand, int quatity)
        {
            this._markerName = markerName;
            this._color = color;
            this._brand = brand;
            this._quatity = quatity;
            if (brand == "Natraj")
            {
                this._baseprice = 20d;
            }
            else if (brand == "DOMS")
            {
                this._baseprice = 30d;
            }
            
        }
    }
}
