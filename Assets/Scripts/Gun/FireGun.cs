using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class FireGun : MonoBehaviour
{
    public GameObject tir;
    List<GameObject> all = new List<GameObject>();
    public float delay = 0.001f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * 20;
        if (timer > delay)
        {
            MyFunction();
            timer -= delay;
        }
    }
    void MyFunction()
    {
        var pos = transform.position;
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject child in all)
            {
                if (child.CompareTag("muzzle"))
                {
                    pos = child.GetComponent<Transform>().position;
                }
            }
            var newTir = Instantiate(tir, new Vector2(pos.x, pos.y), Quaternion.identity);
            newTir.name = "newTir";
        }
    }

}
