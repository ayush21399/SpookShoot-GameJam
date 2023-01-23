using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pla;
    void Start()
    {
        pla = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(pla.transform.position);
        transform.position += transform.forward * 15f * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bul" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
