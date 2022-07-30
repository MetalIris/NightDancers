using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimator : MonoBehaviour
{
    private Vector3 targetPosition;
    private Vector3 startPosition;


    private void Start()
    {
        startPosition = transform.position;
        targetPosition = transform.position + Vector3.up * 20;

        StartCoroutine(MoveCoroutine());
    }


    float EasingSquared(float x)
    {
        return x*x;
    }
    IEnumerator MoveCoroutine()
    {
        while(true)
        {
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector3.Lerp(startPosition, targetPosition, EasingSquared(i));

                yield return null;
            }

            transform.position = targetPosition;
            yield return new WaitForSecondsRealtime(4);
        }
    }
}
