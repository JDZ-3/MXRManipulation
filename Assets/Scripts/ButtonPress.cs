using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta;
using Meta.HandInput;
using ResultTracker;

public class ButtonPress : Interaction
{
    public GameObject[] objs;
    private HandFeature _handFeature;

    protected override bool CanEngage(Hand handProxy)
    {
        return GrabbingHands.Count == 1;
    }

    protected override void Engage()
    {
        _handFeature = GrabbingHands[0];

        //rigidbody should be kinematic as to not interfere with grab translation
        SetIsKinematic(true);

        SetGrabOffset(_handFeature.Position);
    }

    protected override bool CanDisengage(Hand handProxy)
    {
        if (_handFeature != null && handProxy.Palm == _handFeature)
        {
            foreach (var hand in GrabbingHands)
            {
                if (hand != _handFeature)
                {
                    _handFeature = hand;
                    SetGrabOffset(_handFeature.Position);
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    protected override void Disengage()
    {
        SetIsKinematic(false);
        _handFeature = null;
        
        objs[0].SetActive(false);
        objs[1].SetActive(true);

        if (objs[1].name == "[Study]")
            objs[1].GetComponent<dataTracker>().beginGame();
    }

    protected override void Manipulate()
    {
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
