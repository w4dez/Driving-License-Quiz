namespace quiz;

public class DeleteCRUD<T>
{
  public bool Delete()
  {
    if (quiz.GenericsList<T>.Items.Count == 0)
      return false;

    quiz.GenericsList<T>.Items.RemoveAt(0);
    return true;
  }
}
