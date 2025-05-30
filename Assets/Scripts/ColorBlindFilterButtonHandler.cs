using UnityEngine;

public class ColorBlindFilterButtonHandler : MonoBehaviour
{
    public ColorblindFilter.Scripts.ColorblindFilter filter;

    public void SetOff()
    {
        filter.SetUseFilter(false);
    }

    public void SetProtanopia()
    {
        filter.SetUseFilter(true);
        filter.ChangeBlindType(ColorblindFilter.Scripts.BlindnessType.Protanopia);
    }

    public void SetDeuteranopia()
    {
        filter.SetUseFilter(true);
        filter.ChangeBlindType(ColorblindFilter.Scripts.BlindnessType.Deuteranopia);
    }

    public void SetTritanopia()
    {
        filter.SetUseFilter(true);
        filter.ChangeBlindType(ColorblindFilter.Scripts.BlindnessType.Tritanopia);
    }
}