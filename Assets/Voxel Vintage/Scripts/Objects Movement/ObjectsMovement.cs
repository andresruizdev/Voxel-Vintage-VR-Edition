using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    private float speed;

    private void Start()
    {
        speed = 1f;
        StartCoroutine(GravityMovement());
        StartCoroutine(TurningCoroutine());
    }
    #region TurningCoroutine
    private IEnumerator TurningCoroutine()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.Rotate(Vector3.up * speed, Space.World);
            yield return new WaitForSeconds(0.0001f);
        }
        StartCoroutine(TurningCoroutine());
    }
    #endregion

    #region GravityMovement
    private IEnumerator GravityMovement()
    {
        for (int i = 0; i < 200; i++)
        {
            if (i < 100)
            {
                transform.position += new Vector3(0, 0.01f, 0);
            }
            else if (i > 99)
            {
                transform.position -= new Vector3(0, 0.01f, 0);
            }
            yield return new WaitForSeconds(.00001f);
        }
        StartCoroutine(GravityMovement());
    }
    #endregion
}
