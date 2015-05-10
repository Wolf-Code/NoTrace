using System.Collections.Generic;

namespace NoTrace.Core
{
    /// <summary>
    /// The scene containing objects which the renderer has to render.
    /// </summary>
    public class RenderScene
    {
        /// <summary>
        /// The list of objects in the scene.
        /// </summary>
        public List<RendererObject> Objects { private set; get; }

        public RenderScene( )
        {
            this.Objects = new List<RendererObject>( );
        }

        /// <summary>
        /// Adds a renderer object to the scene.
        /// </summary>
        /// <param name="Object"></param>
        public void AddRendererObject( RendererObject Object )
        {
            // No duplicates in the list.
            if ( !this.Objects.Contains( Object ) )
                this.Objects.Add( Object );
        }
    }
}
