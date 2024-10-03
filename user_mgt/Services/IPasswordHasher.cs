namespace user_mgt.Services
{
    public interface IPasswordHasher
    {

        String Hash(String password);
        bool Verify(string passwordHash, string inputPassword);

    }
}
