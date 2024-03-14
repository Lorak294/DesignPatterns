
namespace DesignPatterns.Builder
{
    public abstract class FunctionalBuilder<TObject,TSelf>
        where TObject : new()
        where TSelf : FunctionalBuilder<TObject,TSelf>
    {
        private readonly List<Func<TObject,TObject>> _actions = new List<Func<TObject,TObject>>();

        protected TSelf AddAction(Action<TObject> action)
        {
            _actions.Add(obj => { action(obj); return obj; });
            return (TSelf)this;
        }

        protected TSelf Do(Action<TObject> action) => AddAction(action);

        public TObject Build() => _actions.Aggregate(new TObject(), (obj, func) => func(obj));
    }
}
