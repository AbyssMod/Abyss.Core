using UnityEngine.Events;
using UnityEngine.Localization.Events;

// ReSharper disable once CheckNamespace
namespace UnityEngine.Localization.Events;

/// <inheritdoc />
public class UnityEventMonoBehavior<T> : UnityEvent<T> where T : MonoBehaviour
{

}