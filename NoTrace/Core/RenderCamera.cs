
using NoTrace.Core.Maths;
using NoTrace.Objects;

namespace NoTrace.Core
{
    public class RenderCamera
    {
        public Vector3 Position
        {
            set
            {
                m_Position = value;
                this.SetUpPositionMatrix(  );
            }
            get { return m_Position; }
        }

        private RenderSettings Settings;
        private Matrix4x4 mPos;
        private Matrix4x4 mRot;
        private Matrix4x4 Projection;
        private Vector3 m_Position;
        private float AspectRatio;
        private float FOVDivided;

        public RenderCamera( RenderSettings Settings )
        {
            this.Settings = Settings;

            this.Projection = Matrix4x4.CreateProjection( Settings.FieldOfView, Settings.FieldOfView, 1, 1000 );
            this.AspectRatio = Settings.Resolution.X / Settings.Resolution.Y;
            this.FOVDivided = 0.5f / MathHelper.Tan( Settings.FieldOfView / 2, false );
        }

        public Vector3 GetDirectionFromPixel( float X, float Y )
        {
            float XDiff = ( X / this.Settings.Resolution.X ) * 2 - 1;
            float YDiff = ( Y / this.Settings.Resolution.Y ) * 2 - 1;

            return this.mRot.Forward * FOVDivided +
                          this.mRot.Right * ( X / this.Settings.Resolution.X - 0.5f ) *
                          this.AspectRatio -
                          this.mRot.Up * ( Y / this.Settings.Resolution.Y - 0.5f );
        }

        /// <summary>
        /// Creates a ray pointing in the pixel's direction.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public Ray GetRayFromPixel( float X, float Y )
        {
            return new Ray { Start = this.Position, Direction = this.GetDirectionFromPixel( X, Y ) };
        }

        private void SetUpPositionMatrix( )
        {
            mPos = Matrix4x4.CreateTranslation( this.Position );
        }

        private void SetUpRotationMatrix()
        {
        }
    }
}
