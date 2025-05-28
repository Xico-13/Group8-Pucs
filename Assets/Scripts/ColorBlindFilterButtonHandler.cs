using UnityEngine;
using ColorblindFilter.Scripts;  // Ajusta para o teu namespace

public class ColorBlindFilterButtonHandler : MonoBehaviour
{
    [SerializeField] private ColorblindFilter colorblindFilterInstance;

    public void TurnOff()
    {
        colorblindFilterInstance.SetUseFilter(false);
    }

    public void SetProtanopia()
    {
        colorblindFilterInstance.SetUseFilter(true);
        colorblindFilterInstance.ChangeBlindType(BlindnessType.Protanopia);
    }

    public void SetDeuteranopia()
    {
        colorblindFilterInstance.SetUseFilter(true);
        colorblindFilterInstance.ChangeBlindType(BlindnessType.Deuteranopia);
    }

    public void SetTritanopia()
    {
        colorblindFilterInstance.SetUseFilter(true);
        colorblindFilterInstance.ChangeBlindType(BlindnessType.Tritanopia);
    }
}
