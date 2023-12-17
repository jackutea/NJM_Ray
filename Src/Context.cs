using System.Runtime.InteropServices;
using Raylib_cs;

namespace NJM;

public unsafe struct Context {
    public int windowWidth;
    public int windowHeight;
    public CameraEntity *camera;

}
