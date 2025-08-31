using UnityEngine;

public class AnimationBehavior : MonoBehaviour
{

    [SerializeField] private AnimationCurve _animationCurve;
    [SerializeField] private float _speed;

    private float elapsedTime = 0f;

    private Transform _transform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        float t = (elapsedTime % 2f) / 2f;

        float curveValue = _animationCurve.Evaluate(t);

        transform.position = 3f * curveValue * Vector3.up;
    }
}
