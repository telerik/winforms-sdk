namespace ERP.Repository
{
    public interface ISavableObject
    {
        void Save(bool isAddingItem);
        void Delete();
        void Cancel();
    }
}
