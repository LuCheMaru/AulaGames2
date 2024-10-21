using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugRaycast : MonoBehaviour
{
    //desenha um raio do alcance
    private void OnDrawGizmos()
    {
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 10;
        Gizmos.DrawRay(transform.position, direction);
    }
}