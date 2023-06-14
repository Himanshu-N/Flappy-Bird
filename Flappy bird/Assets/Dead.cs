using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EndScreen;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        EndScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
