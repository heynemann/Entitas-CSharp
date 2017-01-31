//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public ListArrayComponent listArray { get { return (ListArrayComponent)GetComponent(VisualDebuggingComponentsLookup.ListArray); } }
    public bool hasListArray { get { return HasComponent(VisualDebuggingComponentsLookup.ListArray); } }

    public void AddListArray(System.Collections.Generic.List<string>[] newListArray) {
        var component = CreateComponent<ListArrayComponent>(VisualDebuggingComponentsLookup.ListArray);
        component.listArray = newListArray;
        AddComponent(VisualDebuggingComponentsLookup.ListArray, component);
    }

    public void ReplaceListArray(System.Collections.Generic.List<string>[] newListArray) {
        var component = CreateComponent<ListArrayComponent>(VisualDebuggingComponentsLookup.ListArray);
        component.listArray = newListArray;
        ReplaceComponent(VisualDebuggingComponentsLookup.ListArray, component);
    }

    public void RemoveListArray() {
        RemoveComponent(VisualDebuggingComponentsLookup.ListArray);
    }
}