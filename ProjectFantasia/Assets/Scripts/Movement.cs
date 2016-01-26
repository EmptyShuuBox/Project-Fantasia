using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public int PlayerMoveSpeed = 0;
    Vector3 WalkAmt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // 8 way movement for the player.
        if(Input.GetKey(KeyCode.W))
        {
            WalkAmt.y = PlayerMoveSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.A))
            {
                WalkAmt.x = -PlayerMoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                WalkAmt.x = PlayerMoveSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            WalkAmt.x = -PlayerMoveSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.S))
            {
                WalkAmt.y = -PlayerMoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                WalkAmt.y = PlayerMoveSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            WalkAmt.y = -PlayerMoveSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.A))
            {
                WalkAmt.x = -PlayerMoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                WalkAmt.x = PlayerMoveSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            WalkAmt.x = PlayerMoveSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.S))
            {
                WalkAmt.y = -PlayerMoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                WalkAmt.y = PlayerMoveSpeed * Time.deltaTime;
            }
        }
        else
        {
            
            WalkAmt.x = 0;
            WalkAmt.y = 0;
        }
        transform.Translate(WalkAmt);

    }
}
