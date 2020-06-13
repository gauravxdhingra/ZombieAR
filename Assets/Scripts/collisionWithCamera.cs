using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithCamera : MonoBehaviour
{

    // public GameObject MainCamera;
    public bool zombieIsThere;
    // public GameObject bloodyScreen;
    float timer;
    int timeBetweenAttack;
    private GameControllerScrpt gameController;

    // Use this for initialization
    void Start()
    {
        timeBetweenAttack = 2;

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if(gameControllerObject!=null){
            gameController = gameControllerObject.GetComponent <GameControllerScrpt> ();
        }
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (zombieIsThere && timer >= timeBetweenAttack)
        {
            Attack();
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ARCamera")
        {
            zombieIsThere = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "ARCamera")
        {
            zombieIsThere = false;
        }
    }

    void Attack()
    {
        timer = 0f;
        GetComponent<Animator>().Play("Z_Attack");
        gameController.zombieAttack(zombieIsThere);
        // bloodyScreen.gameObject.SetActive(true);
        // StartCoroutine(wait2sec());
    }

    // IEnumerator wait2sec()
    // {
    //     yield return new WaitForSeconds(2f); 
    //     bloodyScreen.gameObject.SetActive(false);
    // }
}
