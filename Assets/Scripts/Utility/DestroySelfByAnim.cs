using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfByAnim : MonoBehaviour {
    [SerializeField]
    private Animator anim;
     
    void Awake()
    {
        anim = GetComponent<Animator>();
        AnimatorClipInfo[] animInfos = anim.GetCurrentAnimatorClipInfo(0);
        Destroy(this.gameObject, animInfos[0].clip.length);
    }
}
