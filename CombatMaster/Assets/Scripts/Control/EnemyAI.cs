using Unity.Mathematics.Geometry;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] private AnimationCurve _animationCurve;

    public Transform checkPoint1;
    public Transform checkPoint2;

    private bool checkPoint = false;

    public float speed = 0.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(_animationCurve[1].time);
    }

    // Update is called once per frame
    void Update()
    {

        float t = Mathf.PingPong(Time.time, _animationCurve[1].time);
        speed = _animationCurve.Evaluate(t);
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
