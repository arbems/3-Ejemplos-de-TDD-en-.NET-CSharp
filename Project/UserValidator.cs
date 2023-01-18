using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

public class UserValidator
{
    public bool IsAdmin(User user)
    {
        return user.Role == "admin";
    }
}