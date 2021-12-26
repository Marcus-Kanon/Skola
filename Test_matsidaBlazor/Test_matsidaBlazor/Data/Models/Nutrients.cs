namespace Test_matsidaBlazor.Data.Models
{
    public class Nutrients
    {

        public int Id { get; set; }
        public double VitA { get; set; }
        public double VitB { get; set; }
        public double VitC { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
