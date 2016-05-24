using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LifeIndicator : MonoBehaviour
{
    //ссылка на жизнь
    public GameObject LifeCell;

    //храним жизни игрока
    public List<GameObject> LifeList; 

	// Use this for initialization
	void Start ()
	{
        LifeCell = Resources.Load("LifeIndicator/PlatformLifeCell") as GameObject;
    }

    //Добавить жизнь
    public void AddLife()
    {
        if(LifeCell==null)Start();
        GameObject life;
        life = Instantiate(LifeCell);
        life.transform.parent = this.transform;
        LifeList.Add(life);
        life.transform.localPosition = new Vector3(LifeList.Count * 55 , 0 );
    }

    //Удаляем жизнь из списка и запускаем анимацию с авто уничтожением
    public void RemoveLife()
    {
        //GameObject life = LifeList.Last();
        //GameObject life = LifeList[LifeList.Count - 1];
        //if (life != null)
        //{
        //    LifeList.RemoveAt(LifeList.Count - 1);
        //    life.GetComponent<Animator>().SetTrigger("IsDead");
        //}
    }
	
}
