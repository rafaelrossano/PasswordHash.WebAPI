namespace PasswordHash.WebAPI.Resources
{
    public sealed record RegisterResource(string Username, string Email, string Password);
}
