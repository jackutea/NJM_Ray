using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_cs;

namespace NJM;

public unsafe static class Program {

    public static void Main() {

        Context* ctx = (Context*)Marshal.AllocHGlobal(sizeof(Context));
        Init(ctx);

        Raylib.InitWindow(ctx->windowWidth, ctx->windowHeight, "忍者明");
        Raylib.SetTargetFPS(60);

        Vector2 pos = new Vector2();

        while (!Raylib.WindowShouldClose()) {

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RAYWHITE);
            float dt = Raylib.GetFrameTime();

            // Input

            // Logic
            pos += Vector2.UnitX * dt * 100;

            // Draw: World
            ctx->camera->Follow(pos, ctx->windowWidth, ctx->windowHeight);
            Raylib.BeginMode2D(ctx->camera->camera);

            Raylib.DrawCircleV(new Vector2(), 10, Color.BLUE);
            Raylib.DrawCircleV(pos, 10, Color.RED);

            Raylib.EndMode2D();

            // Draw: UI
            Raylib.DrawText("njm", 10, 10, 20, Color.BLACK);

            Raylib.EndDrawing();

        }

        Free(ctx);

        Raylib.CloseWindow();
    }

    static void Init(Context* ctx) {
        // Window
        ctx->windowWidth = 320;
        ctx->windowHeight = 180;
        // Camera
        ctx->camera = Factory.Camera_Create();
    }

    static void Free(Context* ctx) {
        Marshal.FreeHGlobal((IntPtr)ctx->camera);
        Marshal.FreeHGlobal((IntPtr)ctx);
    }

}