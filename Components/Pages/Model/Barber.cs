namespace ProjectBarber.Components.Pages.Model
{
    public class Barber
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? Category { get; set; }  // e.g., Haircut, Beard, Facial
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; } // Path to image
    }

    public class SelectedService
    {
        public Barber? Service { get; set; }
        public int Quantity { get; set; } = 1;
    }

    
        public class CartItemDto
        {
            public string? ServiceName { get; set; }
            public int Quantity { get; set; }
        }
    

}
