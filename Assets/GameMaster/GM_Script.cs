using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GM_Script : MonoBehaviour
{

    public List<GameObject> BrickList= new List<GameObject>();

    // Use this for initialization
    void Start ()
	{
        //BrickList = new List<GameObject>();
        BrickList.Add(Resources.Load("Brick Blue") as GameObject);
        BrickList.Add(Resources.Load("Brick Green") as GameObject);
        BrickList.Add(Resources.Load("Brick Yellow") as GameObject);


        Instantiate(BrickList[0], new Vector3(-370, 250),Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
