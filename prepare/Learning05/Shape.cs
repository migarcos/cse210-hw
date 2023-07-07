    public class Shape
    {
        private string _color, _name;

        public Shape(string name, string color = "white") // Constructor
        {
            _name = name;
            _color = color;
        }
        public void SetColor(string color) // Setter
        {
            _color = color;
        }
        public string GetColor() // Getter
        {
            return _color;
        }
        public virtual double GetArea()
        {
            return 1;
        }
        public string GetName()
        {
            return _name;
        }
    
    }