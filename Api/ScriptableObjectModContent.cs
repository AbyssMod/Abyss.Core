using JetBrains.Annotations;
using UnityEngine;

namespace Abyss.Api;

/// <summary>
/// A localized mod content that is based on a ScriptableObject
/// </summary>
/// <typeparam name="T"></typeparam>
[PublicAPI]
public abstract class ScriptableObjectModContent<T> : LocalizedModContent where T : ScriptableObject
{
    /// <summary>
    /// The instance of T that this class is associated with
    /// </summary>
    public T Item { get; set; } = null!;

    public virtual void Edit(T item)
    {
    }

    /// <inheritdoc />
    public override void Register()
    {
        Item = ScriptableObject.CreateInstance<T>();
        Item.name = Id;
    }
}