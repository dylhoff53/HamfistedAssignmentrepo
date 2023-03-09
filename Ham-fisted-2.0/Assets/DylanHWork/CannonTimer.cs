using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTimer : MonoBehaviour
{
    public GameObject cannon1;
    public GameObject cannon2;
    public GameObject cannon3;
    public GameObject cannon4;
    public float timer = 1f;
    public float interval;
    public int mutiplier;
    public int shotCounter;
    // Update is called once per frame
    void Update()
    {
        timer -= interval * Time.deltaTime * mutiplier;
        if(timer <= 0.5f && shotCounter == 0)
        {
            cannon1.GetComponent<Launcher>().Fire();
            cannon3.GetComponent<Launcher>().Fire();
            shotCounter++;
        } else if(timer <= 0f)
        {
            cannon2.GetComponent<Launcher>().Fire();
            cannon4.GetComponent<Launcher>().Fire();
            shotCounter = 0;
            timer = 1f;
        }
    }


}
