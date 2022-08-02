using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveThing : MonoBehaviour
{
    private XRRig XRRig;
    private CharacterController CharacterController;
    private CharacterControllerDriver driver;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    protected virtual void UpdateCharacterController()
    {
        if (XRRig == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(XRRig.cameraInRigSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = XRRig.cameraInRigSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}