using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bezier_Curves : MonoBehaviour
{
    // Start is called before the first frame update
    public float tParam, speedModifier;
    public Vector2 objectPosition, initialPosition;
    public bool coroutineAllowed,first;
    public GameObject ChildObj;

    void Start()
    {
        tParam = 0f;
        speedModifier = 0.3f;
        coroutineAllowed = true;
        first = true;        
 
        //StartCoroutine(GoByTheRoute());

    }


    void Update()
    {
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute());
        }
    }
        
    private IEnumerator GoByTheRoute(){
        coroutineAllowed = false;
        Vector2 r1 = transform.position;         
        Vector2 r2 = new Vector2(Random.Range(-5, 5), Random.Range(-4, 4));
        Vector2 r3 = new Vector2(Random.Range(-5, 5), Random.Range(-4, 4));
        Vector2 r4 = new Vector2(Random.Range(-5, 5), Random.Range(-4, 4));

        initialPosition = r4;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * r1 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * r2 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * r3 + Mathf.Pow(tParam, 3) * r4;

            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0f;

        coroutineAllowed = true;

    }
}
