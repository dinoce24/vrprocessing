using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontrol : MonoBehaviour
{
    public GameObject menu;
    public GameObject[] optionals;
    public GameObject[] menus;
    public Material uncheck;
    public Material check;
    public int x =1;
    public int y=0;
    public int z=0;
    public int optional=0;
    public string optionalcheck;
    public string menucheck;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        optional = 100 * x + 10 * y + z;
        optionalcheck = "opt" + x.ToString() + "." + y.ToString() + "." + z.ToString();
        menucheck = "menu" + x.ToString() + "." + y.ToString() + "." + z.ToString();
        if (flag == false)
        {
            Resetmaterials();
            GameObject.Find(optionalcheck).GetComponent<MeshRenderer>().material = check;
            flag = true;
        }
    }
    public void Xplus()
    {
        x += 1;
        if(x>3)
        {
            x = 1;
        }
        flag = false;
    }
    public void Xmins()
    {
        x -= 1;
        if (x <= 0)
        {
            x = 3;
        }
        flag = false;
    }
    public void Yplus()
    {
        y += 1;
        if (x == 1)
        {
            if (y > 3)
            {
                y = 1;
            }
        }
        flag = false;
    }
    public void Ymins()
        {
            y = y - 1;
            if(x==2)
            {
                if (y <= 0)
                {
                    y = 3;
                }
            }
        flag = false;
    }
    public void Zplus()
    {
       z = z + 1;
            if((x==1)&&(y==1))
                if(z>5)
                {
                    z = 1;
                }
        flag = false;
    }
    public void Zmins()
        {
            z = z - 1;
            if((x==1)&&(y==1))
            {
                if(z<=0)
                {
                    z = 5;
                }
            }
        flag = false;
    }
    public void Resetmaterials()
    {
        optionals = GameObject.FindGameObjectsWithTag("optional");
        for (int i = 0; i < optionals.GetLength(0); i++)
        {
            optionals[i].GetComponent<MeshRenderer>().material = uncheck;
        }
    }
}

