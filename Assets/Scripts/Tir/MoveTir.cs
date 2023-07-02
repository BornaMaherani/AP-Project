using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTir : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        //pos.y = (pos.y + rapid);
        transform.Translate((transform.up * speed * Time.deltaTime));
        if (transform.position.y >= 5 && gameObject.name == "newTir")
        {
            Destroy(gameObject);
        }
    }
}
