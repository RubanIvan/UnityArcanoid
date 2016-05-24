using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GM_Script : MonoBehaviour
{
    //Количество жизней игрока
    public int PlayerLife;

    //список кубиков
    public List<GameObject> BrickList = new List<GameObject>();
    //список задних фонов
    public List<GameObject> BackGroundList = new List<GameObject>();

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
    //стенка убивающая мячик
    public GameObject WallBallKiller;

    //префаб на платформу
    public GameObject PlatformNormal;

    //Платформа игрока
    public GameObject PlayerPlatform;


    //отрисовывает кол-во жизней игрока
    public GameObject LifeIndicator;

    // Use this for initialization
    void Start()
    {
        //Загружаем фоны
        BackGroundInit();

        //Загружаем стенки
        WallInit();

        //отображаем стенки
        CreateWall();

        //Подгружаем кубики
        BrickInit();

        //Отображаем жизни игрока
        LifeIndicatorInit();


        for (int i = 0; i < 11; i++)
        {
            Instantiate(BrickList[0], new Vector3(-341 + 62 * i, 200 - 26 * 0), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i, 200 - 26 * 1), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i, 200 - 26 * 2), Quaternion.identity);

            Instantiate(BrickList[0], new Vector3(-341 + 62 * i, 200 - 26 * 3), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i, 200 - 26 * 4), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i, 200 - 26 * 5), Quaternion.identity);

            Instantiate(BrickList[0], new Vector3(-341 + 62 * i, 200 - 26 * 6), Quaternion.identity);
            Instantiate(BrickList[1], new Vector3(-341 + 62 * i, 200 - 26 * 7), Quaternion.identity);
            Instantiate(BrickList[2], new Vector3(-341 + 62 * i, 200 - 26 * 8), Quaternion.identity);
        }

        Instantiate(BackGroundList[Random.Range(0, BackGroundList.Count)]);


        PlatformNormal = Resources.Load("Platform/PlatformNormal") as GameObject;
        PlayerPlatform = Instantiate(PlatformNormal);

        //this.GetComponent<WallScript>().CreateWall();


    }

    // Update is called once per frame
    void Update()
    {

    }

    //Загружаем кубики
    private void BrickInit()
    {
        BrickList.Add(Resources.Load("Brick Blue") as GameObject);
        BrickList.Add(Resources.Load("Brick Green") as GameObject);
        BrickList.Add(Resources.Load("Brick Yellow") as GameObject);
    }

    //Загружаем стенки
    private void WallInit()
    {
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
        WallBallKiller = Resources.Load("Wall/WallBallKiller") as GameObject;
    }

    //создаем стенки
    public void CreateWall()
    {

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
            o = Instantiate(brick);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
            i++;
            o = Instantiate(totem);
            o.transform.parent = wl.transform;
            o.transform.localPosition = new Vector3(-16, 300 - i * 32);
        }

        //создаем правую стенку
        Instantiate(wl, new Vector3(384, -32), Quaternion.identity);
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
            o.transform.localPosition = new Vector3(-368 + i * 32, 16);

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

        //создаем объект и привязываемся к событию
        Instantiate(WallBallKiller).GetComponent<WallBallKiller>().BallKilled += OnBallKilled;


    }

    public void LifeIndicatorInit()
    {
        LifeIndicator = Instantiate(Resources.Load("LifeIndicator/LifeIndicator") as GameObject);
        for (int i = 0; i < PlayerLife; i++)
        {
            LifeIndicator.GetComponent<LifeIndicator>().AddLife();
        }
    }

    void OnBallKilled()
    {
        Debug.Log("BallKilled");
        LifeIndicator.GetComponent<LifeIndicator>().RemoveLife();

        Destroy(PlayerPlatform);
        PlayerPlatform = Instantiate(PlatformNormal);

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
