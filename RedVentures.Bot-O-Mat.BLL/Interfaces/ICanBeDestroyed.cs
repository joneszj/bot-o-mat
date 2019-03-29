namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface ICanBeDestroyed
    {
        ICanBeDestroyed Destroy();
        ICanBeDestroyed DestroyedBy(int id);
        bool IsActive { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}
