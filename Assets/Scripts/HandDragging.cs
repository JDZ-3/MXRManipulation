using Meta;
using Meta.HandInput;
using UnityEngine;
using ResultTracker;

namespace DraggedObj
{
    public class HandDragging : Interaction
    {
        [SerializeField] GameObject obj;
        [SerializeField] private float speed = 1.0f;

        private HandFeature hf;
        private GameObject heldObj;

        public Vector3 lastPosition;
        public bool practice = false;

        private dataTracker results;
        private float DragSpeed;
        private float DragScale;
        private bool draggingEnabled;
        private Vector3 initPos;

        void Start()
        {
            draggingEnabled = true;
            DragSpeed = 5f;
            DragScale = 5f;
            initPos = this.transform.position;
            if (!practice)
                results = GameObject.Find("[Study]").GetComponent<dataTracker>();
        }

        public void SetDragging(bool enabled)
        {
            draggingEnabled = enabled;
        }

        //public void OnManipulationStarted(ManipulationEventData eventData)
        //{
        //    InputManager.Instance.PushModalInputHandler(gameObject);
        //    lastPosition = transform.position;
        //    if (!practice)
        //    {
        //        Debug.Log("Touching");
        //        results.Num_clicks++;
        //        results.startInteraction();
        //    }
        //}

        //public void OnManipulationUpdated(ManipulationEventData eventData)
        //{
        //    if (draggingEnabled)
        //    {
        //        Drag(eventData.CumulativeDelta);
        //    }
        //}

        //public void OnManipulationCompleted(ManipulationEventData eventData)
        //{
        //    InputManager.Instance.PopModalInputHandler();
        //    if (!practice)
        //    {
        //        results.endInteraction(this.gameObject.name);
        //        results.Distance = Vector3.Distance(initPos, this.transform.position);
        //    }
        //}

        //public void OnManipulationCanceled(ManipulationEventData eventData)
        //{
        //    InputManager.Instance.PopModalInputHandler();
        //    if (!practice)
        //    {
        //        results.endInteraction(this.gameObject.name);
        //        results.Distance = Vector3.Distance(initPos, this.transform.position);
        //    }
        //}

        void Drag()
        {
            heldObj.transform.position = hf.transform.position;
        }

        protected override void Engage()
        {
            hf = GrabbingHands[0];
            if (heldObj == null)
                heldObj = Instantiate(obj);

            lastPosition = transform.position;
            heldObj.transform.position = hf.transform.position;

            if (!practice)
            {
                results.Num_clicks++;
                results.startInteraction();
            };
        }

        protected override void Disengage()
        {
            if (hf == null || heldObj == null)
                return;

            heldObj.SendMessage("Detach");
            heldObj = null;

            if (!practice)
            {
                results.endInteraction(this.gameObject.name, initPos);
                results.Distance = Vector3.Distance(initPos, this.transform.position);
            }
        }

        protected override void Manipulate()
        {
            if (hf == null || heldObj == null)
                return;

            if (draggingEnabled)
            {
                Drag();
            }
        }
    }
}