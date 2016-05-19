using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class Brick_2_life_Script : MonoBehaviour
{
    //ссылка на конечный автомат анимаций
    private Animator animator;

    //кол-во жизни у кубика
    public int life=1;

    // Use this for initialization
    private void Start()
    {
        animator = GetComponent<Animator>();
        life = 1;
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
            Debug.Log("******************************");
            if (life == 1)
            {
                life--;
                animator.SetInteger("State", 1);
            }
            else
            {
                animator.SetInteger("State", 2);
            }
        }
    }


    //вызывается по окончании анимации
    public void EndAnim()
    {
        gameObject.SetActive(false);
        life = 1;
        animator.SetInteger("State",0);
    }
}
