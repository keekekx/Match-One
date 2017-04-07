//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity burstModeEntity { get { return GetGroup(InputMatcher.BurstMode).GetSingleEntity(); } }

    public bool isBurstMode {
        get { return burstModeEntity != null; }
        set {
            var entity = burstModeEntity;
            if(value != (entity != null)) {
                if(value) {
                    CreateEntity().isBurstMode = true;
                } else {
                    DestroyEntity(entity);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly BurstModeComponent burstModeComponent = new BurstModeComponent();

    public bool isBurstMode {
        get { return HasComponent(InputComponentsLookup.BurstMode); }
        set {
            if(value != isBurstMode) {
                if(value) {
                    AddComponent(InputComponentsLookup.BurstMode, burstModeComponent);
                } else {
                    RemoveComponent(InputComponentsLookup.BurstMode);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherBurstMode;

    public static Entitas.IMatcher<InputEntity> BurstMode {
        get {
            if(_matcherBurstMode == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.BurstMode);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherBurstMode = matcher;
            }

            return _matcherBurstMode;
        }
    }
}
