using CodeAcademy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeAcademy.Service.Services.Interfaces.GroupService
{
    internal interface IGroupService
    {
        public Task<string> CreateAsync();
        public Task<string> RemoveAsync();
        public Task<string> UpdateAsync();

        public Task<Qroup>GetAsync(int id);
        public Task<List<Qroup>> GetAllAsync();   

        public Task<List<Student>> GetStudentsByGroupAsync(string no);


    }
}
