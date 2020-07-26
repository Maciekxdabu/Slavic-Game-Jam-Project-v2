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

    public int PointsHat, PointsHead, PointsBody;
    //public float PointsHat_1, PointsHead_1, PointsBody_1;

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
                    gameObject.GetComponent<Points>().addPoints(PointsHat);
                }
                if (colliders[i].tag == "Head")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsHead);
                }
                if (colliders[i].tag == "Body")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsBody);
                }
                colliders[i].GetComponent<DieScript>().Die();
                return;
            }

            Collider2D[] colliders2 = Physics2D.OverlapCircleAll((Vector2)targetPoint.position, checkRadius, mask2);
            for (int i = 0; i < colliders2.Length; i++)
            {
                if (colliders2[i].tag == "Hat")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsHat);
                }
                if (colliders2[i].tag == "Head")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsHead);
                }
                if (colliders2[i].tag == "Body")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsBody);
                }
                colliders2[i].GetComponent<DieScript>().Die();
                return;
            }

            Collider2D[] colliders3 = Physics2D.OverlapCircleAll((Vector2)targetPoint.position, checkRadius, mask3);
            for (int i = 0; i < colliders3.Length; i++)
            {
                if (colliders3[i].tag == "Hat")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsHat);
                }
                if (colliders3[i].tag == "Head")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsHead);
                }
                if (colliders3[i].tag == "Body")
                {
                    gameObject.GetComponent<Points>().addPoints(PointsBody);
                }
                colliders3[i].GetComponent<DieScript>().Die();
                return;
            }
        }
    }
}
