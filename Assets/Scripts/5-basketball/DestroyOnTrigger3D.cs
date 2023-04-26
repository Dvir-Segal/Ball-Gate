using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it tringgers a 3D collider with the given tag.
 */
public class DestroyOnTrigger3D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemy") {
            Destroy(this.gameObject);
            // Destroy(other.gameObject);
        }
        if (other.tag== "goal") {
            print("bi");
            if (SceneManager.GetActiveScene().name=="Ball&Gate_1"){
                SceneManager.LoadScene("Ball&Gate_2");
            }
            else{
                SceneManager.LoadScene("Ball&Gate_3");
            }
                
        }

    }

    private void Update() {

    }
}
