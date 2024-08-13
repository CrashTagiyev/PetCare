namespace Domain.Models.AuthModels.Tokens
{
	public class RefreshToken
	{
		public string Token { get; set; }
		public DateTime ExpireTime { get; set; }= DateTime.Now.AddMinutes(15); /*15 minute*/
		public DateTime CreateTime { get; set; } = DateTime.Now;
	}
}
