using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Abyss.UI;

internal class ModsMenuButton : Button
{
    /// <inheritdoc />
    public override void OnPointerClick(PointerEventData eventData)
    {
        AbyssLogger.Error("click");
    }
}