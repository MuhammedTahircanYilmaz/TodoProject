namespace TodoProject.Service;
public interface IValidationService
{
    public bool CheckValidIdForm(string answer);
    public bool CheckValidNameForm(string answer);
    public bool CheckValidEmailForm(string answer);
    public bool CheckValidAgeForm(string answer);
    public bool CheckValidPasswordForm(string answer);
    public bool CheckNullOrEmpty(string answer);
    public bool CheckNumerical(string answer);
    public bool CheckText(string answer);
    public bool CheckEmailAcceptedCharacters(string answer);
    public bool CheckEmailDomainName(string answer);
    public bool CheckPasswordCharacters(string answer);


}