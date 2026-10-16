namespace quiz;

public class ReadCRUD<T>
{
  public T? Read()
  {
    if (quiz.GenericsList<T>.Items.Count == 0)
      return default;

    return quiz.GenericsList<T>.Items[0];
  }
}
