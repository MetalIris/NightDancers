using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimator2 : MonoBehaviour
{
    private Vector3 targetPosition;
    private Vector3 startPosition;

    public AnimationCurve Easing;


    private void Start()
    {
        startPosition = transform.position;
        targetPosition = transform.position + Vector3.down * 20;

        StartCoroutine(MoveCoroutine2());
    }


    float EasingSquared(float x)
    {
        return x * x;
    }
    IEnumerator MoveCoroutine2()
    {
        while (true)
        {
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector3.Lerp(startPosition, targetPosition, Easing.Evaluate(i));

                yield return null;
            }

            transform.position = targetPosition;
            yield return new WaitForSecondsRealtime(2);
        }
    }
}
