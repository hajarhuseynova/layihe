
using CodeAcademy.Service.Services.Implementations.GroupService;

GroupService groupservice = new GroupService();

string resulr= await groupservice.CreateAsync();

Console.WriteLine(resulr);  