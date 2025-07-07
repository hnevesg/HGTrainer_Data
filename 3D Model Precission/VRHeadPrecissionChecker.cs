using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class VRHeadPrecisionChecker : MonoBehaviour
{
    private InputDevice hmdDevice;
    public Collider headCollider;
    
    void Start()
    {
        var headDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HeadMounted, headDevices);

        if (headDevices.Count > 0)
        {
            hmdDevice = headDevices[0];
        }
        else
        {
            Debug.LogWarning("No HMD device found.");
        }
        LogHeight();
    }

    private void LogHeight()
    {
        for (int i = 0; i < 5; i++)
        {
            if (hmdDevice.isValid &&
                hmdDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 hmdPos))
            {
                float hmdHeight = hmdPos.y;
                float collider = headCollider.bounds.center.y;
                float coll_error = Mathf.Abs(collider - hmdHeight);

                Debug.Log($"HMD Height: {hmdHeight:F5} m");
                Debug.Log($"Model Collider Height: {collider:F5} m");
                Debug.Log($"Collider Difference (Error): {coll_error:F5} m");
                i++;
            }
        }
    }
}