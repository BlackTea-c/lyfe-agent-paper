using UnityEngine;

namespace Lyfe.Creator.v1
{
    public class LyfeCreator_v1_Spawn : MonoBehaviour
    {
        public LyfeCreator_v1_WorldShape shape;
        
#if UNITY_EDITOR
        [UnityEditor.DrawGizmo(UnityEditor.GizmoType.NotInSelectionHierarchy | UnityEditor.GizmoType.Selected |
                               UnityEditor.GizmoType.InSelectionHierarchy)]
        private static void DrawGizmo(LyfeCreator_v1_Spawn source, UnityEditor.GizmoType type)
        {
            if (source.shape != null)
            {
                LyfeCreator_v1_WorldShape.DrawGizmo(source.shape);
                return;
            }

            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(source.transform.position, 0.25f);
        }
#endif
    }
}
