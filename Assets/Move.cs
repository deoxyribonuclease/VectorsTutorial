using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 dir;
    public float speed = 2f;
    void Start() {
      //  dir = goal.transform.position - this.transform.position;
      //  this.transform.position = this.transform.position + dir;
        //this.transform.Translate(dir);
    }

    private void LateUpdate() {
        dir = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (dir.magnitude > 2)
        {
            Vector3 velocity = dir.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
