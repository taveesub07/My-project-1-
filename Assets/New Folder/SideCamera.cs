using UnityEngine;

public class SideCamera : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player == null)
            return;

        // ให้กล้องเลื่อนตาม X ของผู้เล่น
        Vector3 targetPosition = new Vector3(
            player.position.x,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );

        // กล้องมองตรงไปด้านหน้า
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}