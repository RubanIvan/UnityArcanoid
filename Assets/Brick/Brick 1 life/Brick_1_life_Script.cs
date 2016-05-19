using UnityEngine;
using System.Collections;

public class Brick_1_life_Script : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Next Animation");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BallTag")
        {
            //Destroy(this.gameObject);
            this.GetComponent<Animator>().SetBool("IsDead",true);
        }
    }


    //вызывается по окончании анимации
    public void EndAnim()
    {
        gameObject.SetActive(false);
        this.GetComponent<Animator>().SetBool("IsDead", false);
    }
}
