using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public int vaccines;

    // Start is called before the first frame update
    void Start()
    {

    }

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        /*     if (Input.GetKeyDown(KeyCode.RightArrow))
             {
                 rb.MovePosition(rb.position + Vector2.right);
             }
             else if (Input.GetKeyDown(KeyCode.LeftArrow))
             {
                 rb.MovePosition(rb.position + Vector2.left);
             }
             else if (Input.GetKeyDown(KeyCode.UpArrow))
             {
                 rb.MovePosition(rb.position + Vector2.up);
             }
             if (Input.GetKeyDown(KeyCode.DownArrow))
             {
                 rb.MovePosition(rb.position + Vector2.down);
             }
     */
        Vector2 swipeDir = new Vector2(
            (Swipe.swipedRight ? 1 : 0) - (Swipe.swipedLeft ? 1 : 0),
            (Swipe.swipedUp ? 1 : 0) - (Swipe.swipedDown ? 1 : 0)
        );
        transform.position += new Vector3(swipeDir.x, swipeDir.y, 0);



    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("Game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        if (col.tag == "vAccine")
        {
            Destroy(col.gameObject);
            vaccines += 1;
            /*cherryText.text = cherries.ToString();*/
        }
    }
}
