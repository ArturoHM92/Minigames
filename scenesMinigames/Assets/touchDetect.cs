using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchDetect : MonoBehaviour
{
    // Start is called before the first frame update
    int life;
    int slam=0;
    void Start()
    {
        life=Random.Range(3,10);
    }

    // Update is called once per frame
    void Update()
    {
       // Code for OnMouseDown in the iPhone. Unquote to test.
          RaycastHit hit = new RaycastHit();
          for (int i = 0; i < Input.touchCount; ++i)
              if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
                  // Construct a ray from the current touch coordinates
                  Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                  if (Physics.Raycast(ray, out hit)){
                      if(hit.transform.name=="Cube"){
                                slam++;
                                    Debug.Log(life);
                                    Debug.Log(slam);

                                if(slam==life){
                                    Debug.Log("muerte");
                                    slam=0;
                                    life=Random.Range(3,10);
                                }
                      }

                  }
              }
      }
    
}
