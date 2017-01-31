//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public BoundsComponent bounds { get { return (BoundsComponent)GetComponent(VisualDebuggingComponentsLookup.Bounds); } }
    public bool hasBounds { get { return HasComponent(VisualDebuggingComponentsLookup.Bounds); } }

    public void AddBounds(UnityEngine.Bounds newBounds) {
        var component = CreateComponent<BoundsComponent>(VisualDebuggingComponentsLookup.Bounds);
        component.bounds = newBounds;
        AddComponent(VisualDebuggingComponentsLookup.Bounds, component);
    }

    public void ReplaceBounds(UnityEngine.Bounds newBounds) {
        var component = CreateComponent<BoundsComponent>(VisualDebuggingComponentsLookup.Bounds);
        component.bounds = newBounds;
        ReplaceComponent(VisualDebuggingComponentsLookup.Bounds, component);
    }

    public void RemoveBounds() {
        RemoveComponent(VisualDebuggingComponentsLookup.Bounds);
    }
}