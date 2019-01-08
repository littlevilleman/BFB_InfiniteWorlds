using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {

    public bool persist;
    public FieldController FieldController;

    //inicializar FieldController 
    private void Awake()
    {
        FieldController = GameObject.Find("Field").GetComponent<FieldController>();
    }
	
	// Update is called once per frame
	void Update () {

        persistence();
    }

    public void persistence()
    {
        if (persist)
        {
            Vector2 p = transform.position;

            //comprobar posicion respecto a las dimensiones de Field
            if (p.x > FieldController.getFieldWidth() / 2)
            {
                p.x -= FieldController.getFieldWidth();
            }
            else if (p.x < -FieldController.getFieldWidth() / 2)
            {
                p.x += FieldController.getFieldWidth();
            }

            if (p.y > FieldController.getFieldHeight() / 2)
            {
                p.y -= FieldController.getFieldHeight();
            }
            else if (p.y < -FieldController.getFieldHeight() / 2)
            {
                p.y += FieldController.getFieldHeight();
            }

            //actualizar posicion
            transform.position = p;
        }
    }
}
