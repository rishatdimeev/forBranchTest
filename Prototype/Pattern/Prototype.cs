namespace Prototype
{
    abstract class Prototype
    {
        public int Id { get; set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }
}