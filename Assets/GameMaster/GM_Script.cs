using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GM_Script : MonoBehaviour
{

    public List<GameObject> BrickList= new List<GameObject>();

    // Use this for initialization
    void Start ()
	{
        BrickList.Add(Resources.Load("Brick Blue") as GameObject);
        BrickList.Add(Resources.Load("Brick Green") as GameObject);
        BrickList.Add(Resources.Load("Brick Yellow") as GameObject);

        for (int i = 0; i < 12; i++)
        {
            Instantiate(BrickList[0], new Vector3(-370+62*i, 250), Quaternion.identity);
        }

        //Instantiate(BrickList[0], new Vector3(-370, 250),Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
