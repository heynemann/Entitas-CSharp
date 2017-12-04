namespace Entitas {

    /// Implement this interface if you want to create a system which should be
    /// executed every frame, after all the IExecuteSystem systems.
    public interface ILateExecuteSystem : ISystem {
        void LateExecute();
    }
}
