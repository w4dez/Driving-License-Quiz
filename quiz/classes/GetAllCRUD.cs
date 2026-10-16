using System.Collections.Generic;

namespace quiz;

public class GetAllCRUD<T>
{
    public IReadOnlyList<T> GetAll()
    {
        return quiz.GenericsList<T>.Items.AsReadOnly();
    }
}
