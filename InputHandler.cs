using UnityEngine;
using Diros.Rigging;

namespace Diros.Plugin;

public class InputHandler : MonoBehaviour
{
    private void Update()
    {
        Rig rig = Rig.Instance;
        if (rig == null) return;

        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movement += rig.body.forward;
        if (Input.GetKey(KeyCode.S))
            movement -= rig.body.forward;
        if (Input.GetKey(KeyCode.A))
            movement -= rig.body.right;
        if (Input.GetKey(KeyCode.D))
            movement += rig.body.right;

        if (movement.magnitude > 0.1f)
        {
            movement.Normalize();
            rig.rigidbody.linearVelocity = movement * 5f;
        }
    }
}
