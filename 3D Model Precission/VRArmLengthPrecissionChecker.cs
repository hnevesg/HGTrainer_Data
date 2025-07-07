using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class VRArmLengthPrecissionChecker : MonoBehaviour
{
    public Transform leftHand;
    public Transform rightHand;

    private InputDevice leftController;
    private InputDevice rightController;

    void Start()
    {
        var leftDevices = new List<InputDevice>();
        var rightDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, leftDevices);
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightDevices);

        if (leftDevices.Count > 0) leftController = leftDevices[0];
        if (rightDevices.Count > 0) rightController = rightDevices[0];
    }

    public void MeasureArmPrecission()
    {
        float virtualHandsDistance = Vector3.Distance(rightHand.position, leftHand.position);

        // Real controller distances
        Vector3 leftCtrlPos, rightCtrlPos;
        float realHandsDistance = -1f;

        if (leftController.TryGetFeatureValue(CommonUsages.devicePosition, out leftCtrlPos) &&
            rightController.TryGetFeatureValue(CommonUsages.devicePosition, out rightCtrlPos))
        {
            realHandsDistance = Vector3.Distance(leftCtrlPos, rightCtrlPos);
        }

        Debug.Log($"Virtual Hand Distance:  {virtualHandsDistance:F3} m");
        Debug.Log($"Real Hand Distance: {realHandsDistance:F3} m | Δ: {Mathf.Abs(virtualHandsDistance - realHandsDistance):F3} m");
    }
}