using UnityEngine;

public class REM : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -10f && gameObject.CompareTag("Clone") )
        {
            Destroy(gameObject);
        }
    }

    // 굳.
}
