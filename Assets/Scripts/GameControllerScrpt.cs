using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScrpt : MonoBehaviour
{

    public GameObject bloodyScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void zombieAttack(bool zombieIsThere)
    {
        bloodyScreen.gameObject.SetActive(true);
        StartCoroutine(wait2sec());
    }

    IEnumerator wait2sec()
    {
        yield return new WaitForSeconds(2f);
        bloodyScreen.gameObject.SetActive(false);
    }
}
