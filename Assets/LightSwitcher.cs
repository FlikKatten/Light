using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    private Light _light;

    private void Start()
    {
        _light = GetComponent<Light>();
    }

    public void EnableLight(bool enable)
    {
        _light.enabled = enable;
    }
}
