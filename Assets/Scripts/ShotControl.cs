using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotControl : MonoBehaviour
{
    public Transform targetPoint;

    [SerializeField] private float checkRadius=0.1f;

    [SerializeField] private LayerMask mask1;
    [SerializeField] private LayerMask mask2;
    [SerializeField] private LayerMask mask3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll((Vector2)targetPoint.position, checkRadius, mask1);
            for (int i = 0; i<colliders.Length; i++)
            {
                if (colliders[i].tag == "Hat")
                {
                    Debug.Log("Hat hit");
                    gameObject.GetComponent<Points>().addPoints(2);
                }
                if (colliders[i].tag == "Body")
                {
                    Debug.Log("Hit");
                    gameObject.GetComponent<Points>().addPoints(1);
                }
                return;
            }

            Collider2D[] colliders2 = Physics2D.OverlapCircleAll((Vector2)targetPoint.position, checkRadius, mask2);
            for (int i = 0; i < colliders2.Length; i++)
            {
                if (colliders2[i].tag == "Hat")
                {
                    Debug.Log("Hat hit");
                    gameObject.GetComponent<Points>().addPoints(2);
                }
                if (colliders2[i].tag == "Body")
                {
                    Debug.Log("Hit");
                    gameObject.GetComponent<Points>().addPoints(1);
                }
                return;
            }

            Collider2D[] colliders3 = Physics2D.OverlapCircleAll((Vector2)targetPoint.position, checkRadius, mask3);
            for (int i = 0; i < colliders3.Length; i++)
            {
                if (colliders3[i].tag == "Hat")
                {
                    Debug.Log("Hat hit");
                    gameObject.GetComponent<Points>().addPoints(2);
                }
                if (colliders3[i].tag == "Body")
                {
                    Debug.Log("Hit");
                    gameObject.GetComponent<Points>().addPoints(1);
                }
                return;
            }
        }
    }
}
