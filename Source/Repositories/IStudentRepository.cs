using Source.Models;

namespace Source.Repositories;

public interface IStudentRepository : IRepository<Student>
{
    Student? GetById(Guid id);
}
