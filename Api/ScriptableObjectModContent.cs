using JetBrains.Annotations;
using UnityEngine;

namespace Abyss.Api;

/// <summary>
/// A localized mod content that is based on a ScriptableObject
/// </summary>
/// <typeparam name="T">The type of ScriptableObject to base it on</typeparam>
[PublicAPI]
public abstract class ScriptableObjectModContent<T> : LocalizedModContent where T : ScriptableObject
{
    /// <summary>
    /// The instance of T that this class is associated with
    /// </summary>
    public T Item { get; set; } = null!;

    /// <summary>
    /// Allows you to edit the item before it is registered, if inheriting from this class, you must manually call it in your <see cref="Register"/> method
    /// </summary>
    /// <param name="item"></param>
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