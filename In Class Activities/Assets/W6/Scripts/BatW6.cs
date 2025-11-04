using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform target;

    public void startChase() {
        enabled = true;
    }

    public void stopChase() {
        enabled = false;
    }

    private void Update() {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position, 
            speed * Time.deltaTime);
    }
}
