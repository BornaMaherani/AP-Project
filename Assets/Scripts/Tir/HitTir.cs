using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("toop"))
        {
            var hp = collision.gameObject.GetComponent<HP>();
            hp.hpDeacres();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("toop2")) {
            var hp2 = collision.gameObject.GetComponent<Hp2>();
            hp2.hpDeacres();
            Destroy(gameObject);
        }
    }
}
