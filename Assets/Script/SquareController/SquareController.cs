using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int Range;
    int Range1;

    private int Range2;
    public int Distance;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Square();
        
    }
    void Square()
    {
         if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.x == 0)
        {
            this.gameObject.transform.position += new Vector3(1, 0, 0);
            

        }
        else if (this.gameObject.transform.position.x == 1 && this.gameObject.transform.position.y == -1)
        {
            this.gameObject.transform.position += new Vector3(0, -1, 0);

        }
        else if (this.gameObject.transform.position.x == 1 && this.gameObject.transform.position.y == 0)
        {
            //test conflict
            this.gameObject.transform.position += new Vector3(0, -1, 0);

        }




    }



}
       

