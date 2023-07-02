using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class MoveGun : MonoBehaviour
{
    Vector2 first, second;
    public float speed = 5;
    float width;
    // Start is called before the first frame update
    void Start()
    {
        width = (float)Screen.width / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                first = Camera.main.ScreenToViewportPoint(new Vector2(Input.mousePosition.x, 0));
            }
            if(touch.phase == TouchPhase.Moved)
            {
                var pos = transform.position;
                second = Camera.main.ScreenToViewportPoint(new Vector2(Input.mousePosition.x, 0));
                Vector3 diff = second - first;
                transform.position += diff * Time.deltaTime * speed;
                first = second;
            }
        }
    }
}
