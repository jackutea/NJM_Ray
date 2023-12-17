using System.Numerics;
using Raylib_cs;

namespace NJM;

public unsafe struct CameraEntity {

    public Camera2D camera;

    public void Follow(Vector2 pos, int windowWidth, int windowHeight) {
        camera.Target = pos;
        camera.Offset = new Vector2(windowWidth / 2, windowHeight / 2);
    }

}