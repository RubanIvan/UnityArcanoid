using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GM_Script : MonoBehaviour
{

    public List<GameObject> BrickList= new List<GameObject>();
    public List<GameObject> BackGroundList = new List<GameObject>();

    
    // Use this for initialization
    void Start ()
    {
        //Загружаем фоны
        BackGroundInit();

        BrickList.Add(Resources.Load("Brick Blue") as GameObject);
        BrickList.Add(Resources.Load("Brick Green") as GameObject);
        BrickList.Add(Resources.Load("Brick Yellow") as GameObject);

        

        for (int i = 0; i < 11; i++)
        {
            Instantiate(BrickList[0], new Vector3(-341+62*i     ,200-26*0), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i ,200-26*1), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i ,200-26*2), Quaternion.identity);

            Instantiate(BrickList[0], new Vector3(-341 + 62 * i, 200 - 26 * 3), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i, 200 - 26 * 4), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i, 200 - 26 * 5), Quaternion.identity);

            Instantiate(BrickList[0], new Vector3(-341 + 62 * i, 200 - 26 * 6), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i, 200 - 26 * 7), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i, 200 - 26 * 8), Quaternion.identity);
        }

        Instantiate(BackGroundList[Random.Range(0,BackGroundList.Count)]);


        Instantiate(Resources.Load("Platform/PlatformNormal") as GameObject);

        //this.GetComponent<WallScript>().CreateWall();


    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Прогружаем все фоновые картинки
    void BackGroundInit()
    {
        BackGroundList.Add(Resources.Load("BG/BG_Quad_1") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_2") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_3") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_4") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_5") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_6") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_7") as GameObject);
        BackGroundList.Add(Resources.Load("BG/BG_Quad_8") as GameObject);
    }

}
