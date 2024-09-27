namespace TodoProject.Service;

internal class ValidationService : IValidationService
{
    public bool CheckValidIdForm(string answer)
    {
        if (CheckNullOrEmpty(answer))
        {
            Console.WriteLine("This field cannot be empty or blank");
            return false;
        }
        if (!CheckNumerical(answer))
        {
            Console.WriteLine("This field has to be numerical, please try again");
            return false;
        }
        if (Convert.ToInt32(answer) <= 0)
        {
            Console.WriteLine("The Id cannot be lower than or equal to zero");
            return false;
        }
        return true;
    }
    public bool CheckNullOrEmpty(string answer)
    {
        if (string.IsNullOrEmpty(answer))
        {
            return true;
        }
        if (string.IsNullOrWhiteSpace(answer))
        {
            return true;
        }
        return false;
    }

    public bool CheckNumerical(string answer)
    {
        //List<char> numericals = new List<char>() { '0','1','2','3','4','5','6','7','8','9','-'};
        string numericals = "0123456789-";
        foreach (char c in answer)
        {
            if (!numericals.Contains(c))
            {
                return false;
            }
        }
        return true;
    }

    public bool CheckPasswordCharacters(string answer)
    {
        bool hasNums = false;
        bool hasSymbols = false;
        bool hasLetters = false;
        
        string symbols = "+-*/,.&%";
        string numbers = "0123456789";
        string letters = "abcçdefgğhıijklmnoöpqrsştuüvxwyz";
        
        foreach (char c in answer.ToLower())
        {
            if (symbols.Contains(c))
            {
                hasSymbols = true;
            }
            else if(numbers.Contains(c))
            {
                hasNums = true;
            }
            else if (letters.Contains(c))
            {
                hasLetters = true;
            }
        }

        if(!hasNums)
        {
            Console.WriteLine("The Password has to contain at least one number");
            return false;
        }
        if (!hasSymbols)
        {
            Console.WriteLine("The Password has to contain at least one of the following symbols: +-*/.,&%");
            return false;
        }
        if (!hasLetters)
        {
            Console.WriteLine("The Password has to contain at least one letter");
            return false;
        }
        return true;
    }
    public bool CheckValidNameForm(string answer)
    {
        if (CheckNullOrEmpty(answer))
        {
            Console.WriteLine("This field cannot be empty or blank");
            return false;
        }
        if (!CheckText(answer))
        {
            Console.WriteLine("This field has to be only text");
            return false;
        }
        return true;
    }

    public bool CheckText(string answer)
    {
        //List<Char> letters = new List<Char>() {'a','b','c','ç','d','e','f','g','ğ','h','ı','i','j','k','l','m','n','o','ö','p','q','r','s','ş','t','u','ü','v','x','w','y','z',' '};
        string letters = "abcçdefgğhıijklmnoöpqrsştuüvxwyz ";
        foreach (char c in answer.ToLower())
        {
            if (!letters.Contains(c))
            {
                return false;
            }
        }
        return true;
    }

    public bool CheckValidEmailForm(string answer)
    {
        if (answer.StartsWith("@"))
        {
            Console.WriteLine("The Email cannot start with an '@' symbol");
            return false;
        }
        if (!CheckEmailAcceptedCharacters(answer))
        {
            return false;
        }
        if (!CheckEmailDomainName(answer))
        {
            return false;
        }
        return true;
    }

    public bool CheckValidAgeForm(string answer)
    {
        if (CheckNullOrEmpty(answer))
        {
            return false;
        }
        else if (!CheckNumerical(answer))
        {
            return false;
        }
        else if (Convert.ToInt16(answer) <= 0)
        {
            Console.WriteLine("The user cannot be 0 years old or younger");
            return false;
        }
        return true;
    }

    public bool CheckValidPasswordForm(string answer)
    {
        if(answer.Length < 8)
        {
            Console.WriteLine("The password must be over 8 characters long");
            return false;
        }
        if (!CheckPasswordCharacters(answer))
        {
            return false;
        }
        return true;
    }
    public bool CheckEmailAcceptedCharacters(string answer)
    {
        int counter = 0;
        string acceptedCharacters = "0123456789.abcdefghijklmnopqrstuvxwyz@";
        
        foreach(char c in answer)
        {
            if (!acceptedCharacters.Contains(c))
            {
                Console.WriteLine("the email contains a character that is not accepted");
                return false;
            }
            if (c == '@')
            {
                counter++;
            }
        } 

        if (counter < 1)
        {
            Console.WriteLine("There should be an '@' symbole before the domain name");
            return false;
        }
        else if(counter > 1)
        {
            Console.WriteLine("There can only be one '@' symbol in the email");
            return false;
        }

        return true;
    }

    public bool CheckEmailDomainName(string email)
    {
        if (!email.EndsWith(".com") && !email.EndsWith(".net") && !email.EndsWith(".org"))
        {
            Console.WriteLine("The domain name ends with an invalid ending");
            return false;
        }
        return true;
    }
}