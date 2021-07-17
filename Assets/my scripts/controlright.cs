using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class controlright : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Behaviour_Pose pose;
    public SteamVR_Action_Boolean teleport = SteamVR_Input.GetBooleanAction("teleport");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
