using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_cs;

namespace NJM;

public unsafe static class Factory {

    public static CameraEntity* Camera_Create() {
        CameraEntity* camera = (CameraEntity*)Marshal.AllocHGlobal(sizeof(CameraEntity));
        Camera2D camera2D = new Camera2D {
            Target = Vector2.Zero,
            Offset = Vector2.Zero,
            Rotation = 0,
            Zoom = 1
        };
        camera->camera = camera2D;
        return camera;
    }

}