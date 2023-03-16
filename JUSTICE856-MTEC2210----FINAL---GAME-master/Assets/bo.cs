using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponet))
        {
            enemyComponet.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
    
    
