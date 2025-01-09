using UnityEngine;

public class LightScript : MonoBehaviour
{
    
    public Light _light;

    void Start()
    {
        _light.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
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
}