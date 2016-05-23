using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallScript : MonoBehaviour
{
    //кубики стены
    public List<GameObject> WallBrick;
    //кубики тотемов
    public List<GameObject> WallTotem;
    //кубики лиц
    public List<GameObject> WallFace;


    //вертикальная стена
    public GameObject WallVert;

    //горизонтальная стена
    public GameObject WallHor;

	//// Use this for initialization
	void Start () {
        WallBrick.Add(Resources.Load("Wall/WallBrick_0") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_1") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_2") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_3") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_4") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_5") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_6") as GameObject);
        WallBrick.Add(Resources.Load("Wall/WallBrick_7") as GameObject);
        
        WallTotem.Add(Resources.Load("Wall/WallTotem_0") as GameObject);
        WallTotem.Add(Resources.Load("Wall/WallTotem_1") as GameObject);
        WallTotem.Add(Resources.Load("Wall/WallTotem_2") as GameObject);
        WallTotem.Add(Resources.Load("Wall/WallTotem_3") as GameObject);
        WallTotem.Add(Resources.Load("Wall/WallTotem_4") as GameObject);

        WallFace.Add(Resources.Load("Wall/WallFace_0") as GameObject);
        WallFace.Add(Resources.Load("Wall/WallFace_1") as GameObject);
        WallFace.Add(Resources.Load("Wall/WallFace_2") as GameObject);
        WallFace.Add(Resources.Load("Wall/WallFace_3") as GameObject);

        WallVert = Resources.Load("Wall/WallVert") as GameObject;
        WallHor = Resources.Load("Wall/WallHor") as GameObject;

	    CreateWall();
	}
	
	
    public void CreateWall()
    {
        //Start();
        //берем случайный кубик стены
        GameObject brick = WallBrick[Random.Range(0, WallBrick.Count)];
        //берем случайный тотем
        GameObject totem = WallTotem[Random.Range(0, WallTotem.Count)];

        //создаем левую стенку
        GameObject wl = Instantiate(WallVert);

        #region Вертикальные стены
        GameObject o;
        for (int i = 0; i < 18; i++)
        {
            o = Instantiate(brick);
            o.transform.parent = wl.transform;
            o.transform.localPosition=new Vector3(-16, 300 - i * 32);
            i++;
            o = Instantiate(brick);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
            i++;
            o = Instantiate(brick);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
            i++;
            o = Instantiate(brick);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
            i++;
            o = Instantiate(totem);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
        }
        
        //создаем правую стенку
        Instantiate(wl,new Vector3(384,-32),Quaternion.identity );
        #endregion

        #region Верхняя стена

        //создаем верхнюю стенку
        GameObject wh = Instantiate(WallHor);
        //добавляем в углы лица
        GameObject face = Instantiate(WallFace[Random.Range(0, WallFace.Count)]);
        face.transform.parent = wh.transform;
        face.transform.localPosition = new Vector3(368, 16);
        o = Instantiate(face);
        o.transform.parent = wh.transform;
        o.transform.localPosition = new Vector3(-400, 16);

        //блоки
        for (int i = 0; i < 10; i++)
        {
            o = Instantiate(brick);
            o.transform.parent = wh.transform;
            o.transform.localPosition = new Vector3(-368 + i*32,16);

            o = Instantiate(brick);
            o.transform.parent = wh.transform;
            o.transform.localPosition = new Vector3(368 - i * 32, 16);
        }

        //лица по центру
        o = Instantiate(face);
        o.transform.parent = wh.transform;
        o.transform.localPosition = new Vector3(-368 + 10 * 32, 16);
        o = Instantiate(face);
        o.transform.parent = wh.transform;
        o.transform.localPosition = new Vector3(-368 + 11 * 32, 16);
        o = Instantiate(face);
        o.transform.parent = wh.transform;
        o.transform.localPosition = new Vector3(-368 + 12 * 32, 16);
        o = Instantiate(face);
        o.transform.parent = wh.transform;
        o.transform.localPosition = new Vector3(-368 + 13 * 32, 16);
        #endregion


    }
}
