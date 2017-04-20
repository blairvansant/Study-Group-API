using StudyGroup.API.Models;

namespace StudyGroup.API.DAL
{
    public interface IAppleGetter
    {
        Apple GetById(int id);

    }
}