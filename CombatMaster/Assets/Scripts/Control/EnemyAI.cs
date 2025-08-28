using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform checkPoint1;
    public Transform checkPoint2;

    private bool checkPoint = false;

    public float speed = 0.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, checkPoint1.position, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, checkPoint1.position) < 1)
            {
                checkPoint = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, checkPoint2.position, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, checkPoint2.position) < 1)
            {
                checkPoint = true;
            }
        }
    }
}
