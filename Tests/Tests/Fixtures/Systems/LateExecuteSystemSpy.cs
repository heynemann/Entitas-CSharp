using Entitas;

public class LateExecuteSystemSpy : ILateExecuteSystem {

    public int didExecute { get { return _didExecute; } }

    int _didExecute;

    public void LateExecute() {
        _didExecute += 1;
    }
}
