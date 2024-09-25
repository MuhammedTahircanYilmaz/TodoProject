using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Model;
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

        Console.WriteLine("User Added: ");

        Console.WriteLine(user);
    }

    public void Delete()
    {
        UserEntity user = GetUserInfo();

        userEntityRepository.Delete(user);

        Console.WriteLine("User Deleted: ");

        Console.WriteLine(user);
    }

    public void GetAll()
    {
        List<UserEntity> users = userEntityRepository.GetAll();
        Console.WriteLine("Users are:");
        users.ForEach(u => Console.WriteLine(u));
    }

    public void GetByEmail()
    {
        string email = GetEmail();
        UserEntity user = userEntityRepository.GetByEmail(email);
        Console.WriteLine("The user you searched is: ");
        Console.WriteLine(user);
    }

    public void GetById()
    {
        int id = GetId();
        UserEntity user = userEntityRepository.GetById(id);
        Console.WriteLine("The user you searched is: ");
        Console.WriteLine(user);
    }

    public void Update()
    {
        UserEntity user;
        UserEntity updatedUser;

        GetUpdatedUser(out user, out updatedUser);
        userEntityRepository.Update(updatedUser);

        PrintUserUpdate(user,updatedUser);
    }

    public UserEntity GetUserInfo()
    {
        int id = GetNextId();
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

    public int GetId()
    {
        int id = 0;
        //ask for ID
        //answer = Console.ReadLine();
        //if CheckValidIdForm()
                //if CheckIdExists()
                   //id = Convert.Toint32(answer)

        //while id == 0;
            //cw("please input valid input")
            // answer = Console.ReadLine()
            //if CheckValidIdForm(answer)
                //if CheckIdExists(answer)
                   //id = Convert.Toint32(answer)
                
        //return id;


            










        //CheckValidIdForm
            //if CheckNullOrEmpty(answer)
                //return false
            //if !CheckNumber(answer)
                //return false
            //if (Convert.ToInt32(answer) <= 0)
                //return false
            //return true


        //bool CheckIdExists(Convert.ToInt32(answer))
            //if GetById(answer) == null
                //return false
            //return true

       
        //CheckNullorEmpty(answer)
            //if null||empty||blank
                //return false
            //return true
            //CheckNumber(answer)
                //foreach(char c in answer) {if not num return false}
                //return true
            //ifCheckdigit
        
            // if text, return false
            // if 
        Console.WriteLine("Please input the User Id");
        List<UserEntity> users = userEntityRepository.GetAll();
        string answer = validationService.CheckAnswer(Console.ReadLine());
        bool isDigit = validationService.CheckNumerical(answer);
        while (!isDigit)
        {
            Console.WriteLine("The User Id Has to be a number. Please input a valid Id");
            answer = validationService.CheckAnswer(Console.ReadLine());
            isDigit = validationService.CheckNumerical(answer);

        }
            bool idExists = CheckExistingId();
        while(!idExists)
        {

        }

    }

    public int GetNextId()
    {
        List<UserEntity> users = userEntityRepository.GetAll();
        int nextId = users.OrderBy(x => x.Id).Last().Id+1;
        return nextId;
    }

   
    public string GetName()
    {
        throw new NotImplementedException();
    }

    public string GetLastName()
    {
        throw new NotImplementedException();
    }

    public short GetAge()
    {
        throw new NotImplementedException();
    }

    public string GetEmail()
    {
        throw new NotImplementedException();
    }

    public string GetPassword()
    {
        throw new NotImplementedException();
    }

    public void GetUpdatedUser(out UserEntity user, out UserEntity updatedUser)
    {
        throw new NotImplementedException();
    }

    public void PrintUserUpdate(UserEntity user, UserEntity updatedUser)
    {
        throw new NotImplementedException();
    }
}
