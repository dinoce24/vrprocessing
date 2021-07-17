using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalcontronal : MonoBehaviour
{
    public GameObject menu;
    public bool flag;
    public int check = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 4)
        {
            check = 3;
        }
        if(check ==0)
        {
            check = 1;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            menu.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            menu.SetActive(false);
        }
        if (flag == false)
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                check -= 1;
                if(check == 2)
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().z = 0;
                }
                else if(check == 1)
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().y = 0;
                }
            }
            if(Input.GetKeyUp(KeyCode.A))
            {
                GameObject.Find("scriptloader").GetComponent<menucontrol>().flag = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                check += 1;
                if (check == 2)
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().y = 1;
                }
                else if (check == 3)
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().z = 1;
                }
            }
            if(Input.GetKeyUp(KeyCode.D))
            {
                GameObject.Find("scriptloader").GetComponent<menucontrol>().flag = false;
            }
            if (check == 1)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Xplus();
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Xmins();
                }
            }
            else if (check ==2)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Yplus();
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Ymins();
                }
            }
            else if (check == 3)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Zplus();
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    GameObject.Find("scriptloader").GetComponent<menucontrol>().Zmins();
                }
            }
        }
    }
}
