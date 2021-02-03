using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        Debug.Log("hit");
    }
}
