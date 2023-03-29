using CodeAcademy.Core.Enums;
using CodeAcademy.Core.Models;
using CodeAcademy.Service.Services.Interfaces.GroupService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Service.Services.Implementations.GroupService
{
  public class GroupService : IGroupService
    {
        public async Task<string> CreateAsync()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter StudentLimit count");
            string StudentLimitstr=Console.ReadLine();
         int.TryParse(StudentLimitstr, out int StudentLimit);   

            if(StudentLimit<10 || StudentLimit > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Student limit must be between 10 and 20!";
            }
            Console.WriteLine("Choose one of them:");
            var Enums = Enum.GetValues(typeof(GroupCategory));
            foreach (var item in Enums )
            {
                Console.WriteLine((int)item+"."+item);
            }
           int.TryParse(Console.ReadLine(), out int groupCategory);    
          
            try
            {
                Enums.GetValue(groupCategory);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                return "GroupCategory is not valid";
            }

            Qroup group = new Qroup((GroupCategory) groupCategory,StudentLimit);

            Console.ForegroundColor = ConsoleColor.Green;
            return "Succesfully";
        }

        public async Task<List<Qroup>> GetAllAsync()
        {
           
        }

        public async Task<Qroup> GetAsync(int id)
        {
            
        }

        public async Task<List<Student>> GetStudentsByGroupAsync(string no)
        {
        
        }

        public async Task<string> RemoveAsync()
        {
            
        }

        public async Task<string> UpdateAsync()
        {
         
        }
    }
}
