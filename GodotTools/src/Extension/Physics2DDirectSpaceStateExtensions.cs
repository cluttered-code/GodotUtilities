using Godot;
using GodotTools.Util;

namespace GodotTools.Extension
{
    public static class Physics2DDirectSpaceStateExtensions
    {
        /// <summary>
        /// Returns a RaycastResult if there is a collision, otherwise returns null.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="exclude"></param>
        /// <param name="collisionLayer"></param>
        /// <param name="collideWithBodies"></param>
        /// <param name="collideWithAreas"></param>
        /// <returns></returns>
        public static RaycastResult Raycast(this Physics2DDirectSpaceState state, Vector2 from, Vector2 to, Godot.Collections.Array exclude = null, int collisionLayer = int.MaxValue, bool collideWithBodies = true, bool collideWithAreas = false)
        {
            var raycastDict = state.IntersectRay(from, to, exclude, collisionLayer, collideWithBodies, collideWithAreas);
            if (raycastDict != null && raycastDict.Count > 0)
            {
                return RaycastResult.FromResultDictionary(raycastDict);
            }
            return null;
        }
    }
}