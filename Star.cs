namespace WebApplication1
{
    public class Star
    {
        public double Id { get; set; }
        public string? Name { get; set; }

        public Star(double id)
        {
            Id = id;
        }

        public double Shine()
        {
            if(Id != -1)
                return Id;
            else
                throw new InvalidOperationException();
        }

        public void FadeOut()
        {
            Id = -1;//adds condition for throwing new InvalidOperationException();
        }
    }
}
