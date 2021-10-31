using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;

public class VRToggle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleVR();
        }
    }

    void ToggleVR()
    {
        if (XRSettings.loadedDeviceName == "cardboard")
        {
            StartCoroutine(LoadDevice("None"));
        }
        else
        {
            StartCoroutine(LoadDevice("cardboard"));
        }
    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = true;
    }
}
