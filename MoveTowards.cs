using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform SquareTransform;
    #region  transform rigitbody

    public Transform CircleTransform;
    public Rigidbody2D CircleRigitbody;
    public Transform CircleTransform1;
    public Rigidbody2D CircleRigitbody1;
    
    #endregion
    public float Speed;

    void Update()
    {
        Vector3 position = Vector3.MoveTowards(CircleTransform.position,SquareTransform.position,Speed * Time.deltaTime);
        CircleRigitbody.MovePosition(position);
        
        Vector3 position1 = Vector3.MoveTowards(CircleTransform1.position,SquareTransform.position,Speed * Time.deltaTime);
        CircleRigitbody1.MovePosition(position1);
    }
}
