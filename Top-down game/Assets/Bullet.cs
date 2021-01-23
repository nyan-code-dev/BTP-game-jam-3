using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public LayerMask terrainLayer;

    private Vector3 pastPos;

    // Start is called before the first frame update
    void Start()
    {
        pastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(pastPos, transform.position, Vector3.Magnitude(transform.position - pastPos), terrainLayer);
        if (hit)
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(Vector2.up * speed, Space.Self);
        pastPos = transform.position;
    }
}
