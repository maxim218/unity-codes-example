using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    void Start() {
        StartCoroutine( KillMe() );
    }

    private IEnumerator KillMe() {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
