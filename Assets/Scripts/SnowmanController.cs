using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanController : MonoBehaviour
{
    private CapsuleCollider gravityArea;
    [SerializeField] private List<GameObject> affectedTargets;

    // Start is called before the first frame update
    void Start(){
        this.gameObject.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update(){
        
    }


}
