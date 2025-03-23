using UnityEngine;

public class FollowingPanel : MonoBehaviour
{
    public Transform playerCamera;   // VR 카메라, 보통 XR Rig 안에 있는 Main Camera
    public float distance = 2f;      // 플레이어와 UI 사이의 거리
    public float height = -0.2f;     // 카메라 기준으로 약간 아래에 위치시키는 게 보기에 좋아요
    public float followSpeed = 5f;   // 부드럽게 따라오게 하기 위함

    void Update()
    {
        // 목표 위치: 카메라가 바라보는 방향 앞쪽
        Vector3 targetPosition = playerCamera.position + playerCamera.forward * distance;
        targetPosition.y += height;

        // 부드럽게 위치 이동
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * followSpeed);

        // 항상 카메라를 바라보게 회전
        Quaternion targetRotation = Quaternion.LookRotation(transform.position - playerCamera.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * followSpeed);
    }
}

