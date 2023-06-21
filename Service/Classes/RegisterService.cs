using Service.Models;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Classes
{
    public class RegisterService
    {
        private readonly FinalContext _context;


        public string ErrorMessage { get; set; }

        public RegisterService(FinalContext context)
        {
            _context = context;
        }


        public string GetRegisters()
        {
            throw new NotImplementedException();
        }

        public bool CheckUserFromDatabase(string email, string password)
        {
            var user = _context.Registers.FirstOrDefault(u => u.Email == email);

            if (user != null && user.Paswordd == password)
            {
                return true;
            }

            return false;
        }
    }
}
