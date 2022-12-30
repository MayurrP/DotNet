namespace Membership;

public static class AuthManager
{

    public static bool Validate(string email, string password)
    {
        return email == "mayur@gmail.com" && password == "pass";
    }

    public static bool Register(string firstName, string lastName, string email,
                                string contactNumber, string location)
    {
        bool status = false;
        try
        {
            User appUser = new User();
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.Email = email;
            appUser.ContactNumber = contactNumber;
            appUser.Location = location;
            status = true;
        }
        catch (System.Exception)
        {
            throw;
        }
        finally
        {

        }
        return status;
    }

}