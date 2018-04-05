using Meta;
using Meta.HandInput;
using UnityEngine;

public class CloneGrab : Interaction
{
    [SerializeField] GameObject _prefab;
    [SerializeField] private float _speed = 1.0f;

    private HandFeature _handFeature;
    private GameObject _heldGameObject;

    protected override void Engage()
    {
        _handFeature = GrabbingHands[0];

        if (_heldGameObject == null)
        {
            _heldGameObject = Instantiate(_prefab);
        }

        _heldGameObject.transform.position = _handFeature.transform.position;
        _heldGameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    protected override void Disengage()
    {
        if (_handFeature == null || _heldGameObject == null)
        {
            return;
        }

        var newVec = _handFeature.transform.position - Camera.main.transform.position;
        newVec = newVec.normalized * _speed;
        _heldGameObject.GetComponent<Rigidbody>().velocity = newVec;
        _heldGameObject.SendMessage("Detach");
        _heldGameObject = null;
    }
    
    protected override void Manipulate()
    {
        if (_handFeature == null || _heldGameObject == null)
        {
            return;
        }

        _heldGameObject.transform.position = _handFeature.transform.position;
    }
}