using UnityEngine;
using System.Collections;

public class TurretRotatie : MonoBehaviour {

	void start()
    {
        
    }
	
	void Update ()
    {
        Cursor.visible = false;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if(plane.Raycast(ray,out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustHeightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustHeightPoint);
        }
	}
}
