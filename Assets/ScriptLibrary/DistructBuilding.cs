using UnityEngine;
using System.Collections;

public class DistructBuilding : MonoBehaviour {
    public float BuildingHealth = 0;
    public GameObject Box; 
    void Start ()
    {
        Box = this.gameObject;
    }

	void Update ()
    {
        if (BuildingHealth > 0)
        {
            RemoveRigidBody();
        }
        else
        {
            AddRigidBody();
            this.transform.parent = null;
        }
    }
    void AddRigidBody()
    {
        if(!Box.GetComponent<Rigidbody>())
        {
            Box.AddComponent<Rigidbody>();
        }
    }
    void RemoveRigidBody()
    {
        if(Box.GetComponent<Rigidbody>())
        {
            Destroy(Box.GetComponent<Rigidbody>());
        }
    } 
}
