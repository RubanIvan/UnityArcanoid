using UnityEngine;
using System.Collections;

public class Platformcontrol : MonoBehaviour {

    public float Speed;             // The fastest the player can travel in the x axis.

    //находится ли мяч в игре
    private bool BallInGame = false;
    //ссылка на мяч
    private GameObject Ball;

    // Use this for initialization
    void Start ()
    {
        Ball = GameObject.FindGameObjectWithTag("BallTag");
    }
	
	// Update is called once per frame
	void Update() {

        float move = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

	    if (transform.position.x > 310)
	    {
            transform.position=new Vector3(310,transform.position.y);
        }

        if (transform.position.x < -310)
        {
            transform.position = new Vector3(-310, transform.position.y);
        }

        //пока мяч не в игре он является потомком платформы и двигается вместе с ней
	    if (BallInGame==false)
	    {
	        if (Input.GetAxis("Jump") != 0 || Input.GetAxis("Submit") != 0 || Input.GetAxis("Fire1") != 0)
	        {
                //освобождаем мяч и даем ему ускорение
                Ball.transform.parent = null;
                Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 250f);
	            BallInGame = true;
	        }
       }

    }

   

}
