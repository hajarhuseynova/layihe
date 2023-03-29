using CodeAcademy.Core.Repositories.GroupRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeAcademy.Data.Repositories.GroupRepository
{
    internal class GroupRepository:Repository<Group>,IGroupRepository
    {
    }
}
