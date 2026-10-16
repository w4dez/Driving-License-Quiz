using System.Collections.Generic;

namespace quiz;

public class CreateCRUD<T>
{
    public void Create(T item)
    {
        quiz.GenericsList<T>.Items.Add(item);
    }

}
