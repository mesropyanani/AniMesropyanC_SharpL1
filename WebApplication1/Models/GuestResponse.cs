namespace WebApplication1.Models
{
    public class GuestResponse
    {
	
		public string Name { get; set; }
		
		//[RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter a valid email address")]
	
		public string Email { get; set; }
		
		public string Phone { get; set; }
		
		public bool? WillAttend { get; set; }

	}
}
