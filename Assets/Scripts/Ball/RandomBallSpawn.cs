using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallSpawn : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-2, 2), 5.4f);
        var position = new Vector2(Random.Range(-2f, 2f), Random.Range(-0.8f, 0));
        rb.AddForce(position * 2, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
