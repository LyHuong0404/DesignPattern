public abstract class Shape
    {
        private string id;

        protected string type;

        public string Id { get => id; set => id = value; }

        public string Type { get => type; }

        public abstract void draw();

        public Shape()
        {

        }

        public Shape ShallowCopy()
        {
            return MemberwiseClone() as Shape;
        }

    }