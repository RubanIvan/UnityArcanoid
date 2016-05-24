using UnityEngine;
using System.Collections;

public class LifeCellScript : MonoBehaviour
{
    //случайный промежуток времени с которым будет биться сердце
    private float HeartBreatTime;
    private float elapseTime;

	// Use this for initialization
	void Start () {
        HeartBreatTime = Random.Range(1f, 5f);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    elapseTime += Time.deltaTime;
	    if (elapseTime > HeartBreatTime)
	    {
	        elapseTime = 0;
            HeartBreatTime = Random.Range(1f, 20f);
            this.GetComponent<Animator>().SetTrigger("HeartBeat");
        }

	}

    

    //вызывается по окончании анимации
    public void EndAnim()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
        //this.GetComponent<Animator>().SetBool("IsDead", false);
    }

}
