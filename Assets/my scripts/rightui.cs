using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightui : MonoBehaviour
{
    public GameObject menu;
    public Rigidbody righthandrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(menu.activeSelf == true)
        {
            menu.transform.localPosition = righthandrigidbody.transform.localPosition + new Vector3(0,20,0);
        }
    }
}
