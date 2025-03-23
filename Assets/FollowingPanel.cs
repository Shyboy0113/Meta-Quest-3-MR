using UnityEngine;

public class FollowingPanel : MonoBehaviour
{
    public Transform playerCamera;   // VR ī�޶�, ���� XR Rig �ȿ� �ִ� Main Camera
    public float distance = 2f;      // �÷��̾�� UI ������ �Ÿ�
    public float height = -0.2f;     // ī�޶� �������� �ణ �Ʒ��� ��ġ��Ű�� �� ���⿡ ���ƿ�
    public float followSpeed = 5f;   // �ε巴�� ������� �ϱ� ����

    void Update()
    {
        // ��ǥ ��ġ: ī�޶� �ٶ󺸴� ���� ����
        Vector3 targetPosition = playerCamera.position + playerCamera.forward * distance;
        targetPosition.y += height;

        // �ε巴�� ��ġ �̵�
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * followSpeed);

        // �׻� ī�޶� �ٶ󺸰� ȸ��
        Quaternion targetRotation = Quaternion.LookRotation(transform.position - playerCamera.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * followSpeed);
    }
}

