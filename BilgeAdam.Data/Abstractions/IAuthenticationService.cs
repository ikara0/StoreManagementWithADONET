using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Abstractions
{
    public interface IAuthenticationService
    {
        bool CheckUser(CheckUserDto dto);
        bool RegisterUser(NewUserDto dto);
        List<SecurityQuestionOptionDto> GetSecurityQuestions();
        bool AddNewUser(NewUserDto dto);
        UserQuestionDto GetUserByEmail(string text);
        bool UpdateUserPasswordDto(UpdateUserPasswordDto dto);
    }
}
