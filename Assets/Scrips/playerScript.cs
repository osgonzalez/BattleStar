using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    private Rigidbody rb;
    public float speed=1;
    public float rotateSpeed = 1;

    public float timeToChangeColor = 2;
    private float nextTimeChangeColor = 0;

    public GameObject shoot;
    public float shootCadence = 0.5f;
    private float nextTimeForShoot = 0;
    private Renderer render;

	private Color [] colorList;

  
    // Use this for initialization
    void Start () {
		colorList = new Color[]{
								new Color(200,200,200),
								new Color(255,0,0),
								new Color(0,255,0),
								new Color(0, 0, 255)};
        rb = this.GetComponent<Rigidbody>();
        render = this.GetComponent<Renderer>();
        rb.freezeRotation = true;
    }
	
	// Update is called once per frame
	void Update () {

        //ColorChange

        /*if (Time.time > nextTimeChangeColor)
        {
            nextTimeChangeColor = Time.time + timeToChangeColor;
            render.material.color = new Color(Random.value, Random.value, Random.value);
        }
		*/
        //movement

        float movHor= Input.GetAxis("Horizontal");
        float movVer = Input.GetAxis("Vertical");

        //rb.AddForce((new Vector3(movHor, 0, movVer)) * speed * Time.deltaTime);
        rb.velocity =(new Vector3(movHor, 0, movVer)) * speed ;


        //para mantener fija la rotacion en direciones indeseadas se limina la x y la z
        //rb.rotation = new Quaternion(0,rb.rotation.y,0, rb.rotation.w);
       


        if (Input.GetKey("l"))
        {
            rb.rotation = Quaternion.Euler((rb.rotation.eulerAngles + new Vector3(0, rotateSpeed, 0)));
        }

        if (Input.GetKey("k"))
        {
            rb.rotation = Quaternion.Euler((rb.rotation.eulerAngles + new Vector3(0, -rotateSpeed, 0)));
        }

		if (Input.GetKey("1") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[1];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("2") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[2];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("3") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[3];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("4") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[0];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}

        if (Input.GetKey("space") && nextTimeForShoot<Time.time)
        {
            nextTimeForShoot = Time.time + shootCadence;
            
            Instantiate(shoot, (this.transform.position + (this.transform.forward * 1)),this.transform.rotation);

         
           
        }

    }
}
