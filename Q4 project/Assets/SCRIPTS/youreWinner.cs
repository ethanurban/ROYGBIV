using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youreWinner : MonoBehaviour {

    //PLAYERS
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    //LAVA
    public GameObject lava;
    //UI ELEMENTS
    public GameObject wintext1;
    public GameObject wintext2;
    public GameObject wintext3;
    public GameObject wintext4;

    //player out elements GONNA REPLACE THESE WITH ANNOUNCER SOUNDS MAYBE
    public GameObject p1out;
    public GameObject p2out;
    public GameObject p3out;
    public GameObject p4out;

    //music
    public GameObject winMusic;
    public AudioSource gameMusic;

    //Exit Button
    public GameObject EXIT;






    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (p1.transform.position.y < lava.transform.position.y)
        {
            if (p2.transform.position.y < lava.transform.position.y)
            {
                if (p3.transform.position.y < lava.transform.position.y)
                {
                    //PLAYER 4 WINS
                    Debug.Log("player 4 wins");
                    wintext4.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    //mute music
                    gameMusic.mute = true;

                    EXIT.gameObject.SetActive(true);

                }

                else if (p4.transform.position.y < lava.transform.position.y)

                {
                    //PLAYER 3 WINS
                    Debug.Log("player 3 wins");
                    wintext3.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    //mute music
                    gameMusic.mute = true;

                    EXIT.gameObject.SetActive(true);
                }
            }

            else if (p3.transform.position.y < lava.transform.position.y && p4.transform.position.y < lava.transform.position.y)
            {
                //PLAYER 2 WINS
                Debug.Log("player 2 wins");
                wintext2.gameObject.SetActive(true);

                //win music
                winMusic.gameObject.SetActive(true);

                //mute music
                gameMusic.mute = true;

                EXIT.gameObject.SetActive(true);
            }

        }

        else if (p3.transform.position.y < lava.transform.position.y && p4.transform.position.y < 628 && p2.transform.position.y < lava.transform.position.y)

        {
            //PLAYER 1 WINS
            Debug.Log("player 1 wins");
            wintext1.gameObject.SetActive(true);


            //win music
            winMusic.gameObject.SetActive(true);

            //mute music
            gameMusic.mute = true;

            EXIT.gameObject.SetActive(true);
        }







        //PLAYER IS OUT functions

        //player one out!
        if (p1.transform.position.y < lava.transform.position.y)
        {
            p1.GetComponent<Rigidbody>().detectCollisions = false;
            //PLAYER ONE OUT SOUND
        }

        //player two out!
        if (p2.transform.position.y < lava.transform.position.y)
        {
            p2.GetComponent<Rigidbody>().detectCollisions = false;
            //PLAYER 2 OUT SOUND
        }

        //player three out!
        if (p3.transform.position.y < lava.transform.position.y)
        {
            p3.GetComponent<Rigidbody>().detectCollisions = false;
            //PLAYER 3 OUT SOUND
        }

        //player four out!
        if (p4.transform.position.y < lava.transform.position.y)
        {
            p4.GetComponent<Rigidbody>().detectCollisions = false;
            //PLAYER 4 OUT SOUND
        }
    }
}
