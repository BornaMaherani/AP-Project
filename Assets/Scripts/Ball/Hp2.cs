using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp2 : MonoBehaviour
{
    public GameObject b1;
    public GameObject b2;
    public int Hp = 6;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
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
            if (gameObject.name == "Toop2")
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
            var pos = transform.position;
            var ball1 = Instantiate(b1, new Vector2(pos.x, pos.y), Quaternion.identity);
            ball1.name = "newBall";
            var position = new Vector2(Random.Range(-1f, -0.2f), Random.Range(-0.6f, 0));
            rb1.AddForce(position * 2, ForceMode2D.Impulse);
            var ball2 = Instantiate(b1, new Vector2(pos.x, pos.y), Quaternion.identity);
            ball2.name = "newBall";
            position = new Vector2(Random.Range(0.2f, 1f), Random.Range(-0.6f, 0));
            rb2.AddForce(position * 2, ForceMode2D.Impulse);

        }
    }
}
