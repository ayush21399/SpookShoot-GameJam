using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playershoot : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 spa;
    public GameObject bull;
    public Transform point;

    //health
    int health = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bull, point.position, transform.rotation);

        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ene")
        {

            health = health - 10;
            if (health < 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(0);
            }
        }
    }

}
