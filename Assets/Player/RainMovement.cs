using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RainMovement : MonoBehaviour {

    public float speed = 0.13f;
    public int score;
    public int min_score;
    public Transform pos;
	public Camera cam;
    public float aspect_ratio;
    public Text countText;
    public GameObject shark;
    public GameObject rain;

	// Use this for initialization
	void Start () {
        //pos = this.GetComponent<Transform>();
        score = 0;
        min_score = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update () {
        // Get keys
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        pos.SetPositionAndRotation(new Vector3(pos.position.x + x * speed, pos.position.y + y * speed, pos.position.z), new Quaternion());

        // Check out of bounds
        if (pos.position.x * (10f/16f) >= cam.orthographicSize) { // Pos X
            pos.SetPositionAndRotation(new Vector3(cam.orthographicSize * 16f/10f, pos.position.y, pos.position.z), new Quaternion());
        }
        if (pos.position.x * (10f/16f) <= cam.orthographicSize * -1) { // Neg X
            pos.SetPositionAndRotation(new Vector3(cam.orthographicSize * -1 * 16f/10f, pos.position.y, pos.position.z), new Quaternion());
        }
        if (pos.position.y >= cam.orthographicSize) { // Pos Y
            pos.SetPositionAndRotation(new Vector3(pos.position.x, cam.orthographicSize, pos.position.z), new Quaternion());
        }
        if (pos.position.y <= cam.orthographicSize * -1) { // Neg Y
            pos.SetPositionAndRotation(new Vector3(pos.position.x, cam.orthographicSize * -1, pos.position.z), new Quaternion());
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Instantiate(shark).GetComponent<fish_movement>().cam = cam;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Instantiate(rain).GetComponent<rain_movement>().cam = cam;
        }
    }

    public void UpdateScore (int delta) {
        score += delta;
        if (score < min_score) {
            score = min_score;
            return;
        }
        speed += delta / 60f;
        cam.orthographicSize += 0.1f*delta;
        pos.localScale += new Vector3(0.0005f*delta,0.0005f*delta,0);
        SetCountText();
    }

    void SetCountText () //function that updates the count
   {
        countText.text = "Size: " + score.ToString();

    }
}
