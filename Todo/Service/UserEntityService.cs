using TodoProject.Exceptions;
using TodoProject.Model;
using TodoProject.Model.ReturnModels;
using TodoProject.Repository;

namespace TodoProject.Service;

public class UserEntityService : IUserEntityService
{
    UserEntityRepository userEntityRepository = new UserEntityRepository();
    ValidationService validationService = new ValidationService();
    public void Add()
    {
        UserEntity user = GetUserInfo();
        userEntityRepository.Add(user);
        PrintAddedUser(user);        
    }

    public void Update()
    {
        UserEntity user;
        UserEntity updatedUser;

        GetUpdatedUser(out user, out updatedUser);
        userEntityRepository.Update(updatedUser);

        PrintUpdatedUser(user, updatedUser);
    }

    public void Delete()
    {
        UserEntity user = GetUserInfo();

        userEntityRepository.Delete(user);

        PrintDeletedUser(user);
    }

    public ReturnModel<UserEntity> GetAll()
    {
        List<UserEntity> users = userEntityRepository.GetAll();
        Console.WriteLine("Users are:");
        users.ForEach(u => Console.WriteLine(u));
    }

    public ReturnModel<UserEntity> GetByEmail()
    {
        string email = GetEmail();
        try
        {
            UserEntity user = userEntityRepository.GetByEmail(email);
            return new ReturnModel<UserEntity>
            {
                Data = user,
                Message = $"The User with the Email \"{email}\" has been found",
                Success = true
            };
        }
        catch(UserNotFoundException ex)
        {
            return new ReturnModel<UserEntity>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }
    }

    public ReturnModel<UserEntity> GetById()
    {
        long id = GetId();
        try
        {
            UserEntity user = userEntityRepository.GetById(id);
            return new ReturnModel<UserEntity>
            {
                Data = user,
                Message = $"The User with the Id \"{id}\" has been found",
                Success = true
            };
        }
        catch(UserNotFoundException ex)
        {
            return new ReturnModel<UserEntity>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }
    }

    public UserEntity GetUserInfo()
    {
        long id = GetId();
        string name = GetName();
        string lastName = GetLastName();
        short age = GetAge();
        string email = GetEmail();
        string password = GetPassword();

        UserEntity user = new UserEntity(
            id: id,
            name: name,
            lastName: lastName,
            age: age,
            email: email,
            password: password);

        return user;
    }

    public long GetId()
    {
        long id = 0;
        Console.WriteLine("Please input the user Id: ");
        string answer = Console.ReadLine();
        if (validationService.CheckValidIdForm(answer))
        {

            long idCandidate = Convert.ToInt32(answer);

            if (CheckIdExists(idCandidate))
            {
                id = idCandidate;
                return id;
            }
        }

        while (id == 0)
        {
            Console.WriteLine("Please input the User Id: ");
            answer = Console.ReadLine();
            if (validationService.CheckValidIdForm(answer))
            {
                long idCandidate = Convert.ToInt32(answer);
                if (CheckIdExists(idCandidate))
                {
                    id = idCandidate;
                }
            }
        }
        return id;
    }

    public long GetNextId()
    {
        List<UserEntity> users = userEntityRepository.GetAll();
        long nextId = users.OrderBy(x => x.Id).Last().Id + 1;
        return nextId;
    }

    public string GetName()
    {
        string name = "";
        Console.WriteLine("Please input User Name: ");
        string answer = Console.ReadLine();
        if (validationService.CheckValidNameForm(answer))
        {
            name = answer;
            return name;
        }

        while (name == "")
        {
            Console.WriteLine("Please input User Name: ");
            answer = Console.ReadLine();
            if (validationService.CheckValidNameForm(answer))
            {
                name = answer;
            }
        }

        return name;
    }

    public string GetLastName()
    {
        string lastName = "";
        Console.WriteLine("Please input User Last Name: ");
        string answer = Console.ReadLine();
        if (validationService.CheckValidNameForm(answer))
        {
            lastName = answer;
            return lastName;
        }

        while (lastName == "")
        {
            Console.WriteLine("Please input User Last Name: ");
            answer = Console.ReadLine();
            if (validationService.CheckValidNameForm(answer))
            {
                lastName = answer;
            }
        }

        return lastName;
    }

    public short GetAge()
    {
        short age = 0;
        Console.WriteLine("Please input User Age:");
        string answer = Console.ReadLine();
        if (validationService.CheckValidAgeForm(answer))
        {
            age = Convert.ToInt16(answer);
            return age;
        }

        while(age == 0)
        {
            Console.WriteLine("Please input User Age:");
            answer = Console.ReadLine();
            if (validationService.CheckValidAgeForm(answer))
            {
                age = Convert.ToInt16(answer);
            }
        }

        return age;
    }

    public string GetEmail()
    {
        string email = "";
        Console.WriteLine("Please input User Email: ");
        string answer = Console.ReadLine();
        if (validationService.CheckValidEmailForm(answer))
        {
            email = answer;
            return email;
        }

        while (email == "")
        {
            Console.WriteLine("Please input User Email: ");
            answer = Console.ReadLine();
            if (validationService.CheckValidEmailForm(answer))
            {
                email = answer;
            }
        }
        return email;
    }

    public string GetPassword()
    {
        string password = "";
        Console.WriteLine("Please input User Password:");    
        string answer = Console.ReadLine();
        
        if (validationService.CheckValidPasswordForm(answer))
        {
            password = answer;
            return password;
        }

        while (password == "")
        {
            Console.WriteLine("Please input User Password:");
            answer = Console.ReadLine();

            if (validationService.CheckValidPasswordForm(answer))
            {
                password = answer;
                
            }
        }
        return password; 
    }

    public void GetUpdatedUser(out UserEntity user, out UserEntity updatedUser)
    {
        UserEntity updatedUserInformation = GetUserInfo();
        if (!CheckEmailExists(updatedUserInformation.Email))
        {
            Console.WriteLine("The user you are looking for does not exist in the database.");
        }
        else
        {
            updatedUser = updatedUserInformation;
            user = userEntityRepository.GetByEmail(updatedUserInformation.Email);
            return;
        }
        user = null;
        updatedUser = null;
        return;


        //GetUpdatedUser(out user, out updatedUser);
        //userEntityRepository.Update(updatedUser);

        //PrintUserUpdate(user, updatedUser);
    }

    public void PrintAddedUser(UserEntity user)
    {
        Console.WriteLine("The Following User has been added to the Database: ");

        Console.WriteLine(user);
    }

    public void PrintUpdatedUser(UserEntity user, UserEntity updatedUser)
    {
        Console.WriteLine("The Following User's information has been updated");
        Console.WriteLine(user);
        Console.WriteLine("The Updated Values:");
        Console.WriteLine(updatedUser);
    }
    
    public void PrintDeletedUser(UserEntity user)
    {
        Console.WriteLine("The following User has been removed from the Database");
        Console.WriteLine(user);

    }
    
    private void PrintUser(UserEntity user)
    {
        Console.WriteLine("The user you searched is: ");
        Console.WriteLine(user);
    }
    
    public bool CheckEmailExists(string email)
    {
        if(userEntityRepository.GetByEmail(email) == null)
        {
            return false;
        }
        return true;
    }
    
    public bool CheckIdExists(long id)
    {
        if (userEntityRepository.GetById(id) == null)
        {
            return false;
        }
        return true;

    }
}
