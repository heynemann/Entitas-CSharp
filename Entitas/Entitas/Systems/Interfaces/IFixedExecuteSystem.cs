namespace Entitas {

    /// Implement this interface if you want to create a system which should be
    /// executed in a fixed interval
    public interface IFixedExecuteSystem : ISystem {
        void FixedExecute();
    }
}
