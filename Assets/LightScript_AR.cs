using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LightScript_AR : MonoBehaviour
{
    public Light _light;
    public Button TurnOnOff;

    void Start()
    {
        _light.enabled = false;
        TurnOnOff.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
        {
            if (_light.enabled == false)
            {
                _light.enabled = true;
            }

            else
            {
                _light.enabled = false;
            }
        }
}