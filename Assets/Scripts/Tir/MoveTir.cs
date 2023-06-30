using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTir : MonoBehaviour
{
    public float rapid = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.y = (pos.y + 0.05f) * rapid;
        transform.position = new Vector2(pos.x, pos.y);
    }
}
