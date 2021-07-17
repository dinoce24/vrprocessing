using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class controlleft : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Behaviour_Pose pose;
    public SteamVR_Action_Boolean teleport = SteamVR_Input.GetBooleanAction("teleport");
    public SteamVR_Action_Vector2 switche = SteamVR_Input.GetVector2Action("switche");
    public Vector2 switchedown;
    public bool teleportdown;
    bool keyflag  = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyflag == false)
        {
            if (teleport.GetStateDown(pose.inputSource) == true)
            {
                teleportdown = true;
            }
            else
            {
                teleportdown = false;
            }
            keyflag = true;
        }
        if(teleport.GetStateUp(pose.inputSource) == true)
        {
            keyflag = false;
        }
        if (switche.GetActive(pose.inputSource) == true)
        {
            switchedown = switche.axis;
        }
    }
}
