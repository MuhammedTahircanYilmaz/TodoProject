using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Model;

public sealed class UserEntity : Entity
{
    public UserEntity()
    {

    }

    public UserEntity(int id, string name, string lastName, short age, string email, string password)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Age = age;
        Email = email;
        Password = password;
    }

    public string Name { get; set; }

    public string LastName { get; set; }

    public short Age { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}

