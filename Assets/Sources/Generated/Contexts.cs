//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if(_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public GameContext game { get; set; }
    public GameStateContext gameState { get; set; }
    public InputContext input { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { game, gameState, input }; } }

    public Contexts() {
        game = new GameContext();
        gameState = new GameStateContext();
        input = new InputContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach(var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string Position = "Position";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, IntVector2>(
            Position,
            game.GetGroup(GameMatcher.Position),
            (e, c) => ((PositionComponent)c).value));
    }
}

public static class ContextsExtensions {

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithPosition(this GameContext context, IntVector2 value) {
        return ((Entitas.EntityIndex<GameEntity, IntVector2>)context.GetEntityIndex(Contexts.Position)).GetEntities(value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if(!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContexObservers() {
        CreateContextObserver(game);
        CreateContextObserver(gameState);
        CreateContextObserver(input);
    }

    public void CreateContextObserver(Entitas.IContext context) {
        try {
            if(UnityEngine.Application.isPlaying) {
                var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
                UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
            }
        } catch(System.Exception) {
        }
    }

#endif
}
