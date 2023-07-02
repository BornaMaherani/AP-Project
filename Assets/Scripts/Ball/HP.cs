using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int Hp = 2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void hpDeacres()
    {
        Hp -= 1;
        if (Hp <= 0)
        {
            RandomTimeSpawn.count--;
            if (gameObject.name == "ToopLvl1")
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
            
        }
    }
}
