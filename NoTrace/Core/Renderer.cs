namespace NoTrace.Core
{
    /// <summary>
    /// The base class which all renderers inherit from.
    /// </summary>
    public abstract class Renderer
    {
        /// <summary>
        /// The settings with which to render each frame.
        /// </summary>
        public RenderSettings Settings { private set; get; }
        /// <summary>
        /// The scene to render.
        /// </summary>
        public RenderScene Scene { private set; get; }

        protected RenderCamera Camera { private set; get; }

        /// <summary>
        /// Sets the renderer's new settings.
        /// </summary>
        /// <param name="NewSettings"></param>
        public void SetData( RenderSettings NewSettings )
        {
            this.Settings = NewSettings;
            this.Camera = new RenderCamera( NewSettings );
        }

        /// <summary>
        /// Sets the renderer's new scene to render.
        /// </summary>
        /// <param name="NewScene"></param>
        public void SetData( RenderScene NewScene )
        {
            this.Scene = NewScene;
        }

        /// <summary>
        /// Sets both the renderer's scene to render, as the renderer's new settings.
        /// </summary>
        /// <param name="NewScene"></param>
        /// <param name="NewSettings"></param>
        public void SetData( RenderScene NewScene, RenderSettings NewSettings )
        {
            this.SetData( NewScene );
            this.SetData( NewSettings );
        }

        /// <summary>
        /// Renders a single frame using the renderer's data.
        /// </summary>
        public RendererImage Render( )
        {
            RendererImage Image = new RendererImage( this.Settings.Resolution );

            this.PerformRender( ref Image );

            return Image;
        }

        /// <summary>
        /// Performs the actual rendering.
        /// </summary>
        protected abstract void PerformRender( ref RendererImage Result );
    }
}
