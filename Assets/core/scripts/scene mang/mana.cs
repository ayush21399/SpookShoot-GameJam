using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mana : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string SampleScene)
    {
        Application.LoadLevel(SampleScene);
    }

    public void quit()
    {
        Application.Quit();
    }
}
