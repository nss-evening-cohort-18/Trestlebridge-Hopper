namespace trestleBridge.Interfaces
{
    public interface IFacility<T>
    {
        void AddResource(T resource);
        void AddResource(List<T> resource);
    }
}