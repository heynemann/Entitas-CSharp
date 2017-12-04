using Entitas;

public class FixedExecuteSystemSpy : IFixedExecuteSystem {

    public int didExecute { get { return _didExecute; } }

    int _didExecute;

    public void FixedExecute() {
        _didExecute += 1;
    }
}
