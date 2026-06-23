namespace BLL.Services.Interfaces
{
    public interface IAuthService
    {
        bool LoginAndLoadSession(string username, string rawPassword);
    }
}