using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.Models;


namespace QuanLyCafe.BLL.Interfaces
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}
