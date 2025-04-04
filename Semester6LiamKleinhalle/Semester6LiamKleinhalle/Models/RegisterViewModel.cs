namespace Semester6LiamKleinhalle.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string Klas { get; set; }  // Voeg hier de klas van de student toe
        public string ConfirmPassword { get; set; }
      
    }
}
