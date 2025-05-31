using UnityEngine;
using ColorblindFilter.Scripts; // Certifica-te que este é o namespace correto

public class ColorBlindFilterButtonHandler : MonoBehaviour
{
    public ColorblindFilter.Scripts.ColorblindFilter colorblindFilter;

    public void SetOff()
    {
        colorblindFilter.SetUseFilter(false);
    }

    public void SetProtanopia()
    {
        colorblindFilter.SetUseFilter(true);
        colorblindFilter.ChangeBlindType(BlindnessType.Protanopia);
    }

    public void SetDeuteranopia()
    {
        colorblindFilter.SetUseFilter(true);
        colorblindFilter.ChangeBlindType(BlindnessType.Deuteranopia);
    }

    public void SetTritanopia()
    {
        colorblindFilter.SetUseFilter(true);
        colorblindFilter.ChangeBlindType(BlindnessType.Tritanopia);
    }
}
