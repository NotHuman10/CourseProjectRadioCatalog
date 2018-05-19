using System;

namespace RadioCatalog.LIB
{
    public struct RadioComponent
    {
        string _model, _name, _specs, _maxval;

        public string Model
        {
            get { return _model; }
            private set
            {
                if (value == null)
                    _model = "";
                else if (value.Length > 12)
                    _model = value.Substring(0, 12);
                else _model = value;
            }
        }
        public string Name
        {
            get { return _name; }
            private set
            {
                if (value == null)
                    _name = "";
                else if (value.Length > 20)
                    _name = value.Substring(0, 20);
                else _name = value;
            }
        }
        public string Specs
        {
            get { return _specs; }
            private set
            {
                if (value == null)
                    _specs = "";
                else if (value.Length > 40)
                    _specs = value.Substring(0, 30);
                else _specs = value;
            }
        }
        public string MaxVal
        {
            get { return _maxval; }
            private set
            {
                if (value == null)
                    _maxval = "";
                if (value.Length > 20)
                    _maxval = value.Substring(0, 30);
                else _maxval = value;
            }
        }
        public float Price { get; }

        public RadioComponent(string model, string name, string specs,
            string maxValues, float price) : this()
        {
            Model = model;
            Name = name;
            Specs = specs;
            MaxVal = maxValues;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Model} {Name} {Specs} {MaxVal} {Price.ToString()}";
        }
    }
}